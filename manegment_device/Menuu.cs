namespace manegment_device;

public partial class Menuu : Form
{
    private List<DeviceInfo> _devices = new();
    private DeviceInfo? _selectedDevice;

    public Menuu()
    {
        InitializeComponent();
        // TODO: replace LoadMockDevices() with a real query service (a class like Login_query)
        // that reads devices + readings from the "device" database.
        LoadMockDevices();
    }

    private void Menuu_Load(object sender, EventArgs e)
    {
        UIHelpers.ApplyCircleRegion(pnlLogo);
        UIHelpers.ApplyCircleRegion(btnAddDevice);
        SetupHistoryGrid();
        RenderDeviceList(_devices);
    }

    private void SetupHistoryGrid()
    {
        dgvHistory.Columns.Clear();
        dgvHistory.Columns.Add("colTime", "Ngày giờ");
        dgvHistory.Columns.Add("colIp", "Máy trạm");
        dgvHistory.Columns.Add("colTds", "TDS");
        dgvHistory.Columns.Add("colPh", "pH");
    }

    // ---------------------------------------------------------------
    // Mock data - remove once wired to a real DB-backed service
    // ---------------------------------------------------------------
    private void LoadMockDevices()
    {
        var rnd = new Random();
        _devices = new List<DeviceInfo>
        {
            MakeMockDevice("Máy Trạm 1", "192.168.1.10", true, rnd),
            MakeMockDevice("Máy Trạm 2", "192.168.1.20", false, rnd),
            MakeMockDevice("Trạm Cảm Biến 1", "192.168.2.5", true, rnd),
        };
    }

    private DeviceInfo MakeMockDevice(string name, string ip, bool online, Random rnd)
    {
        var device = new DeviceInfo { Name = name, Ip = ip, IsOnline = online };
        var now = DateTime.Now;
        for (int i = 24; i >= 0; i--)
        {
            device.History.Add(new DeviceReading
            {
                Time = now.AddHours(-i),
                Tds = 200 + rnd.Next(-30, 60),
                Ph = Math.Round(6.5 + rnd.NextDouble() * 1.5, 1),
                Temperature = Math.Round(24 + rnd.NextDouble() * 3, 1)
            });
        }
        return device;
    }

    // ---------------------------------------------------------------
    // Device list (left card)
    // ---------------------------------------------------------------
    private void RenderDeviceList(IEnumerable<DeviceInfo> devices)
    {
        flpDeviceList.Controls.Clear();
        foreach (var device in devices)
        {
            flpDeviceList.Controls.Add(BuildDeviceItem(device));
        }
    }

    private Panel BuildDeviceItem(DeviceInfo device)
    {
        var item = new Panel
        {
            Size = new Size(340, 62),
            Margin = new Padding(0, 0, 0, 8),
            BackColor = Color.FromArgb(250, 251, 253),
            Cursor = Cursors.Hand,
            Tag = device
        };

        var lblName = new Label
        {
            AutoSize = true,
            BackColor = Color.Transparent,
            Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
            ForeColor = Color.FromArgb(50, 50, 50),
            Location = new Point(14, 8),
            Text = device.Name,
            Cursor = Cursors.Hand
        };

        var lblIp = new Label
        {
            AutoSize = true,
            BackColor = Color.Transparent,
            Font = new Font("Segoe UI", 8.5F),
            ForeColor = Color.FromArgb(140, 140, 140),
            Location = new Point(14, 26),
            Text = $"IP: {device.Ip}",
            Cursor = Cursors.Hand
        };

        var lblStatus = new Label
        {
            AutoSize = true,
            BackColor = Color.Transparent,
            Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
            ForeColor = device.IsOnline ? Color.FromArgb(56, 176, 87) : Color.FromArgb(200, 80, 80),
            Location = new Point(14, 42),
            Text = device.IsOnline ? "● Đang hoạt động" : "● Ngắt kết nối",
            Cursor = Cursors.Hand
        };

        item.Controls.Add(lblName);
        item.Controls.Add(lblIp);
        item.Controls.Add(lblStatus);
        item.Paint += Card_Paint;

        void OpenHandler(object? s, EventArgs e) => OpenDeviceDetail(device);
        item.Click += OpenHandler;
        lblName.Click += OpenHandler;
        lblIp.Click += OpenHandler;
        lblStatus.Click += OpenHandler;

        return item;
    }

    private void txtSearchDevice_TextChanged(object sender, EventArgs e)
    {
        string keyword = txtSearchDevice.Text.Trim().ToLower();
        var filtered = string.IsNullOrEmpty(keyword)
            ? _devices
            : _devices.Where(d => d.Name.ToLower().Contains(keyword) || d.Ip.Contains(keyword));
        RenderDeviceList(filtered);
    }

    // ---------------------------------------------------------------
    // Detail overlay (popup card)
    // ---------------------------------------------------------------
    private void OpenDeviceDetail(information_device device)
    {
        _selectedDevice = device;
        lblDetailTitle.Text = $"Chi tiết Máy: {device.Name} - {device.Ip}";

        var latest = device.Latest;
        lblStatTdsValue.Text = latest != null ? $"{latest.Tds:0} ppm" : "--";
        lblStatPhValue.Text = latest != null ? $"{latest.Ph:0.0}" : "--";
        lblStatTempValue.Text = latest != null ? $"{latest.Temperature:0.0} °C" : "--";

        FillHistoryGrid(device);

        tabDetail.SelectedTab = tabCurrent;
        pnlDetailOverlay.Visible = true;
        pnlDetailOverlay.BringToFront();
        pnlChart.Invalidate();
    }

    private void FillHistoryGrid(DeviceInfo device)
    {
        dgvHistory.Rows.Clear();
        foreach (var reading in Enumerable.Reverse(device.History))
        {
            dgvHistory.Rows.Add(
                reading.Time.ToString("dd/MM/yyyy HH:mm"),
                device.Ip,
                $"{reading.Tds:0}",
                $"{reading.Ph:0.0}");
        }
    }

    private void btnCloseDetail_Click(object sender, EventArgs e)
    {
        pnlDetailOverlay.Visible = false;
        _selectedDevice = null;
    }

    // ---------------------------------------------------------------
    // Mini line chart (TDS + pH over the selected device's history)
    // ---------------------------------------------------------------
    private void pnlChart_Paint(object sender, PaintEventArgs e)
    {
        if (_selectedDevice == null || _selectedDevice.History.Count < 2) return;

        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var history = _selectedDevice.History;
        var bounds = new Rectangle(40, 10, pnlChart.Width - 60, pnlChart.Height - 40);

        double maxTds = history.Max(h => h.Tds);
        double minTds = history.Min(h => h.Tds);
        double maxPh = history.Max(h => h.Ph);
        double minPh = history.Min(h => h.Ph);
        if (maxTds - minTds < 1) maxTds += 1;
        if (maxPh - minPh < 0.1) maxPh += 0.1;

        using var axisPen = new Pen(Color.FromArgb(230, 230, 230));
        for (int i = 0; i <= 4; i++)
        {
            int y = bounds.Top + bounds.Height * i / 4;
            g.DrawLine(axisPen, bounds.Left, y, bounds.Right, y);
        }

        PointF[] tdsPoints = BuildPoints(history, bounds, h => h.Tds, minTds, maxTds);
        PointF[] phPoints = BuildPoints(history, bounds, h => h.Ph, minPh, maxPh);

        using var tdsPen = new Pen(Color.FromArgb(64, 158, 255), 2);
        using var phPen = new Pen(Color.FromArgb(250, 180, 40), 2);
        if (tdsPoints.Length > 1) g.DrawLines(tdsPen, tdsPoints);
        if (phPoints.Length > 1) g.DrawLines(phPen, phPoints);

        using var font = new Font("Segoe UI", 8F);
        using var tdsBrush = new SolidBrush(Color.FromArgb(64, 158, 255));
        using var phBrush = new SolidBrush(Color.FromArgb(250, 180, 40));
        g.FillEllipse(tdsBrush, bounds.Left, bounds.Bottom + 14, 8, 8);
        g.DrawString("TDS", font, tdsBrush, bounds.Left + 12, bounds.Bottom + 10);
        g.FillEllipse(phBrush, bounds.Left + 60, bounds.Bottom + 14, 8, 8);
        g.DrawString("pH", font, phBrush, bounds.Left + 72, bounds.Bottom + 10);
    }

    private PointF[] BuildPoints(List<DeviceReading> history, Rectangle bounds, Func<DeviceReading, double> selector, double min, double max)
    {
        var points = new PointF[history.Count];
        for (int i = 0; i < history.Count; i++)
        {
            float x = bounds.Left + bounds.Width * i / (float)(history.Count - 1);
            double ratio = (selector(history[i]) - min) / (max - min);
            float y = bounds.Bottom - (float)(ratio * bounds.Height);
            points[i] = new PointF(x, y);
        }
        return points;
    }

    private void Card_Paint(object sender, PaintEventArgs e)
    {
        if (sender is not Control control) return;
        var bounds = new Rectangle(0, 0, control.Width, control.Height);
        UIHelpers.PaintRoundedCard(e.Graphics, bounds, control.BackColor, 12, Color.FromArgb(235, 235, 235));
    }

    private void DetailOverlay_Paint(object sender, PaintEventArgs e)
    {
        var bounds = new Rectangle(0, 0, pnlDetailOverlay.Width, pnlDetailOverlay.Height);
        UIHelpers.PaintRoundedCard(e.Graphics, bounds, Color.White, 14, Color.FromArgb(225, 225, 225));
    }

    // ---------------------------------------------------------------
    // Sidebar navigation (stub handlers - wire to your other forms)
    // ---------------------------------------------------------------
    private void NavHome_Click(object sender, EventArgs e)
    {
        pnlDetailOverlay.Visible = false;
    }

    private void NavDevices_Click(object sender, EventArgs e)
    {
        // TODO: switch to a dedicated devices-management view
    }

    private void NavAdmin_Click(object sender, EventArgs e)
    {
        // TODO: open admin/account panel
    }

    private void btnAddDevice_Click(object sender, EventArgs e)
    {
        // TODO: open an "add device" dialog and persist it through a service like Login_query
        MessageBox.Show("Mở form thêm thiết bị mới ở đây.", "Thêm thiết bị",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}