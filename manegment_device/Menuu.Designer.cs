using System.ComponentModel;

namespace manegment_device
{
    partial class Menuu
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new System.Windows.Forms.Panel();
            pnlDetailOverlay = new System.Windows.Forms.Panel();
            tabDetail = new System.Windows.Forms.TabControl();
            tabCurrent = new System.Windows.Forms.TabPage();
            pnlStatTds = new System.Windows.Forms.Panel();
            lblStatTdsIcon = new System.Windows.Forms.Label();
            lblStatTdsValue = new System.Windows.Forms.Label();
            lblStatTdsTitle = new System.Windows.Forms.Label();
            pnlStatPh = new System.Windows.Forms.Panel();
            lblStatPhIcon = new System.Windows.Forms.Label();
            lblStatPhValue = new System.Windows.Forms.Label();
            lblStatPhTitle = new System.Windows.Forms.Label();
            pnlStatTemp = new System.Windows.Forms.Panel();
            lblStatTempIcon = new System.Windows.Forms.Label();
            lblStatTempValue = new System.Windows.Forms.Label();
            lblStatTempTitle = new System.Windows.Forms.Label();
            lblChartRange = new System.Windows.Forms.Label();
            pnlChart = new System.Windows.Forms.Panel();
            tabHistory = new System.Windows.Forms.TabPage();
            dgvHistory = new System.Windows.Forms.DataGridView();
            btnCloseDetail = new System.Windows.Forms.Label();
            lblDetailTitle = new System.Windows.Forms.Label();
            pnlLogo = new System.Windows.Forms.Panel();
            lblLogo = new System.Windows.Forms.Label();
            lblOrgName = new System.Windows.Forms.Label();
            pnlNavHome = new System.Windows.Forms.Panel();
            lblNavHomeIcon = new System.Windows.Forms.Label();
            lblNavHomeText = new System.Windows.Forms.Label();
            pnlNavDevices = new System.Windows.Forms.Panel();
            lblNavDevicesIcon = new System.Windows.Forms.Label();
            lblNavDevicesText = new System.Windows.Forms.Label();
            pnlNavAdmin = new System.Windows.Forms.Panel();
            lblNavAdminIcon = new System.Windows.Forms.Label();
            lblNavAdminText = new System.Windows.Forms.Label();
            pnlMain = new System.Windows.Forms.Panel();
            pnlCardList = new System.Windows.Forms.Panel();
            lblCardListTitle = new System.Windows.Forms.Label();
            txtSearchDevice = new ReaLTaiizor.Controls.HopeTextBox();
            flpDeviceList = new System.Windows.Forms.FlowLayoutPanel();
            pnlCardAdd = new System.Windows.Forms.Panel();
            lblCardAddTitle = new System.Windows.Forms.Label();
            btnAddDevice = new ReaLTaiizor.Controls.HopeButton();
            lblCardAddSub = new System.Windows.Forms.Label();
            lblDashboardTitle = new System.Windows.Forms.Label();
            pnlSidebar.SuspendLayout();
            pnlDetailOverlay.SuspendLayout();
            tabDetail.SuspendLayout();
            tabCurrent.SuspendLayout();
            pnlStatTds.SuspendLayout();
            pnlStatPh.SuspendLayout();
            pnlStatTemp.SuspendLayout();
            tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            pnlLogo.SuspendLayout();
            pnlNavHome.SuspendLayout();
            pnlNavDevices.SuspendLayout();
            pnlNavAdmin.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlCardList.SuspendLayout();
            pnlCardAdd.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = System.Drawing.Color.White;
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Controls.Add(lblOrgName);
            pnlSidebar.Controls.Add(pnlNavHome);
            pnlSidebar.Controls.Add(pnlNavDevices);
            pnlSidebar.Controls.Add(pnlNavAdmin);
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Location = new System.Drawing.Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new System.Drawing.Size(230, 750);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlDetailOverlay
            // 
            pnlDetailOverlay.BackColor = System.Drawing.Color.White;
            pnlDetailOverlay.Controls.Add(tabDetail);
            pnlDetailOverlay.Controls.Add(btnCloseDetail);
            pnlDetailOverlay.Controls.Add(lblDetailTitle);
            pnlDetailOverlay.Location = new System.Drawing.Point(26, 35);
            pnlDetailOverlay.Name = "pnlDetailOverlay";
            pnlDetailOverlay.Size = new System.Drawing.Size(500, 480);
            pnlDetailOverlay.TabIndex = 3;
            pnlDetailOverlay.Visible = false;
            pnlDetailOverlay.Paint += DetailOverlay_Paint;
            // 
            // tabDetail
            // 
            tabDetail.Controls.Add(tabCurrent);
            tabDetail.Controls.Add(tabHistory);
            tabDetail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            tabDetail.Location = new System.Drawing.Point(16, 56);
            tabDetail.Name = "tabDetail";
            tabDetail.SelectedIndex = 0;
            tabDetail.Size = new System.Drawing.Size(468, 400);
            tabDetail.TabIndex = 1;
            // 
            // tabCurrent
            // 
            tabCurrent.BackColor = System.Drawing.Color.White;
            tabCurrent.Controls.Add(pnlStatTds);
            tabCurrent.Controls.Add(pnlStatPh);
            tabCurrent.Controls.Add(pnlStatTemp);
            tabCurrent.Controls.Add(lblChartRange);
            tabCurrent.Controls.Add(pnlChart);
            tabCurrent.Location = new System.Drawing.Point(4, 26);
            tabCurrent.Name = "tabCurrent";
            tabCurrent.Padding = new System.Windows.Forms.Padding(3);
            tabCurrent.Size = new System.Drawing.Size(460, 370);
            tabCurrent.TabIndex = 0;
            tabCurrent.Text = "Trạng thái Hiện tại";
            // 
            // pnlStatTds
            // 
            pnlStatTds.BackColor = System.Drawing.Color.FromArgb(((int)((byte)235)), ((int)((byte)244)), ((int)((byte)255)));
            pnlStatTds.Controls.Add(lblStatTdsIcon);
            pnlStatTds.Controls.Add(lblStatTdsValue);
            pnlStatTds.Controls.Add(lblStatTdsTitle);
            pnlStatTds.Location = new System.Drawing.Point(16, 16);
            pnlStatTds.Name = "pnlStatTds";
            pnlStatTds.Size = new System.Drawing.Size(136, 90);
            pnlStatTds.TabIndex = 0;
            pnlStatTds.Paint += Card_Paint;
            // 
            // lblStatTdsIcon
            // 
            lblStatTdsIcon.AutoSize = true;
            lblStatTdsIcon.BackColor = System.Drawing.Color.Transparent;
            lblStatTdsIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblStatTdsIcon.Location = new System.Drawing.Point(12, 10);
            lblStatTdsIcon.Name = "lblStatTdsIcon";
            lblStatTdsIcon.Size = new System.Drawing.Size(30, 20);
            lblStatTdsIcon.TabIndex = 0;
            lblStatTdsIcon.Text = "💧";
            // 
            // lblStatTdsValue
            // 
            lblStatTdsValue.AutoSize = true;
            lblStatTdsValue.BackColor = System.Drawing.Color.Transparent;
            lblStatTdsValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblStatTdsValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            lblStatTdsValue.Location = new System.Drawing.Point(12, 36);
            lblStatTdsValue.Name = "lblStatTdsValue";
            lblStatTdsValue.Size = new System.Drawing.Size(74, 25);
            lblStatTdsValue.TabIndex = 1;
            lblStatTdsValue.Text = "-- ppm";
            // 
            // lblStatTdsTitle
            // 
            lblStatTdsTitle.AutoSize = true;
            lblStatTdsTitle.BackColor = System.Drawing.Color.Transparent;
            lblStatTdsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblStatTdsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)130)), ((int)((byte)130)), ((int)((byte)130)));
            lblStatTdsTitle.Location = new System.Drawing.Point(12, 66);
            lblStatTdsTitle.Name = "lblStatTdsTitle";
            lblStatTdsTitle.Size = new System.Drawing.Size(28, 15);
            lblStatTdsTitle.TabIndex = 2;
            lblStatTdsTitle.Text = "TDS";
            // 
            // pnlStatPh
            // 
            pnlStatPh.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)240)), ((int)((byte)235)));
            pnlStatPh.Controls.Add(lblStatPhIcon);
            pnlStatPh.Controls.Add(lblStatPhValue);
            pnlStatPh.Controls.Add(lblStatPhTitle);
            pnlStatPh.Location = new System.Drawing.Point(164, 16);
            pnlStatPh.Name = "pnlStatPh";
            pnlStatPh.Size = new System.Drawing.Size(136, 90);
            pnlStatPh.TabIndex = 1;
            pnlStatPh.Paint += Card_Paint;
            // 
            // lblStatPhIcon
            // 
            lblStatPhIcon.AutoSize = true;
            lblStatPhIcon.BackColor = System.Drawing.Color.Transparent;
            lblStatPhIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblStatPhIcon.Location = new System.Drawing.Point(12, 10);
            lblStatPhIcon.Name = "lblStatPhIcon";
            lblStatPhIcon.Size = new System.Drawing.Size(30, 20);
            lblStatPhIcon.TabIndex = 0;
            lblStatPhIcon.Text = "🧪";
            // 
            // lblStatPhValue
            // 
            lblStatPhValue.AutoSize = true;
            lblStatPhValue.BackColor = System.Drawing.Color.Transparent;
            lblStatPhValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblStatPhValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            lblStatPhValue.Location = new System.Drawing.Point(12, 36);
            lblStatPhValue.Name = "lblStatPhValue";
            lblStatPhValue.Size = new System.Drawing.Size(28, 25);
            lblStatPhValue.TabIndex = 1;
            lblStatPhValue.Text = "--";
            // 
            // lblStatPhTitle
            // 
            lblStatPhTitle.AutoSize = true;
            lblStatPhTitle.BackColor = System.Drawing.Color.Transparent;
            lblStatPhTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblStatPhTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)130)), ((int)((byte)130)), ((int)((byte)130)));
            lblStatPhTitle.Location = new System.Drawing.Point(12, 66);
            lblStatPhTitle.Name = "lblStatPhTitle";
            lblStatPhTitle.Size = new System.Drawing.Size(23, 15);
            lblStatPhTitle.TabIndex = 2;
            lblStatPhTitle.Text = "pH";
            // 
            // pnlStatTemp
            // 
            pnlStatTemp.BackColor = System.Drawing.Color.FromArgb(((int)((byte)240)), ((int)((byte)235)), ((int)((byte)255)));
            pnlStatTemp.Controls.Add(lblStatTempIcon);
            pnlStatTemp.Controls.Add(lblStatTempValue);
            pnlStatTemp.Controls.Add(lblStatTempTitle);
            pnlStatTemp.Location = new System.Drawing.Point(312, 16);
            pnlStatTemp.Name = "pnlStatTemp";
            pnlStatTemp.Size = new System.Drawing.Size(136, 90);
            pnlStatTemp.TabIndex = 2;
            pnlStatTemp.Paint += Card_Paint;
            // 
            // lblStatTempIcon
            // 
            lblStatTempIcon.AutoSize = true;
            lblStatTempIcon.BackColor = System.Drawing.Color.Transparent;
            lblStatTempIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblStatTempIcon.Location = new System.Drawing.Point(12, 10);
            lblStatTempIcon.Name = "lblStatTempIcon";
            lblStatTempIcon.Size = new System.Drawing.Size(30, 20);
            lblStatTempIcon.TabIndex = 0;
            lblStatTempIcon.Text = "🌡️";
            // 
            // lblStatTempValue
            // 
            lblStatTempValue.AutoSize = true;
            lblStatTempValue.BackColor = System.Drawing.Color.Transparent;
            lblStatTempValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblStatTempValue.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            lblStatTempValue.Location = new System.Drawing.Point(12, 36);
            lblStatTempValue.Name = "lblStatTempValue";
            lblStatTempValue.Size = new System.Drawing.Size(52, 25);
            lblStatTempValue.TabIndex = 1;
            lblStatTempValue.Text = "-- °C";
            // 
            // lblStatTempTitle
            // 
            lblStatTempTitle.AutoSize = true;
            lblStatTempTitle.BackColor = System.Drawing.Color.Transparent;
            lblStatTempTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblStatTempTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)130)), ((int)((byte)130)), ((int)((byte)130)));
            lblStatTempTitle.Location = new System.Drawing.Point(12, 66);
            lblStatTempTitle.Name = "lblStatTempTitle";
            lblStatTempTitle.Size = new System.Drawing.Size(53, 15);
            lblStatTempTitle.TabIndex = 2;
            lblStatTempTitle.Text = "Nhiệt độ";
            // 
            // lblChartRange
            // 
            lblChartRange.AutoSize = true;
            lblChartRange.BackColor = System.Drawing.Color.Transparent;
            lblChartRange.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblChartRange.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            lblChartRange.Location = new System.Drawing.Point(376, 120);
            lblChartRange.Name = "lblChartRange";
            lblChartRange.Size = new System.Drawing.Size(50, 15);
            lblChartRange.TabIndex = 3;
            lblChartRange.Text = "Last 24h";
            // 
            // pnlChart
            // 
            pnlChart.BackColor = System.Drawing.Color.White;
            pnlChart.Location = new System.Drawing.Point(16, 140);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new System.Drawing.Size(432, 210);
            pnlChart.TabIndex = 4;
            pnlChart.Paint += pnlChart_Paint;
            // 
            // tabHistory
            // 
            tabHistory.BackColor = System.Drawing.Color.White;
            tabHistory.Controls.Add(dgvHistory);
            tabHistory.Location = new System.Drawing.Point(4, 26);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new System.Windows.Forms.Padding(3);
            tabHistory.Size = new System.Drawing.Size(460, 370);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "Lịch sử";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.BackgroundColor = System.Drawing.Color.White;
            dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvHistory.Location = new System.Drawing.Point(3, 3);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new System.Drawing.Size(454, 364);
            dgvHistory.TabIndex = 0;
            // 
            // btnCloseDetail
            // 
            btnCloseDetail.BackColor = System.Drawing.Color.Transparent;
            btnCloseDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCloseDetail.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnCloseDetail.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)150)), ((int)((byte)150)), ((int)((byte)150)));
            btnCloseDetail.Location = new System.Drawing.Point(460, 10);
            btnCloseDetail.Name = "btnCloseDetail";
            btnCloseDetail.Size = new System.Drawing.Size(28, 28);
            btnCloseDetail.TabIndex = 2;
            btnCloseDetail.Text = "×";
            btnCloseDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnCloseDetail.Click += btnCloseDetail_Click;
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.BackColor = System.Drawing.Color.Transparent;
            lblDetailTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            lblDetailTitle.Location = new System.Drawing.Point(16, 18);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new System.Drawing.Size(95, 20);
            lblDetailTitle.TabIndex = 3;
            lblDetailTitle.Text = "Chi tiết Máy:";
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)180)), ((int)((byte)40)));
            pnlLogo.Controls.Add(lblLogo);
            pnlLogo.Location = new System.Drawing.Point(20, 24);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new System.Drawing.Size(46, 46);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(46, 46);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "NL";
            lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrgName
            // 
            lblOrgName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            lblOrgName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            lblOrgName.Location = new System.Drawing.Point(78, 26);
            lblOrgName.Name = "lblOrgName";
            lblOrgName.Size = new System.Drawing.Size(140, 44);
            lblOrgName.TabIndex = 1;
            lblOrgName.Text = "Hệ thống Quản lý Thiết bị NL";
            // 
            // pnlNavHome
            // 
            pnlNavHome.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)247)), ((int)((byte)225)));
            pnlNavHome.Controls.Add(lblNavHomeIcon);
            pnlNavHome.Controls.Add(lblNavHomeText);
            pnlNavHome.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlNavHome.Location = new System.Drawing.Point(12, 110);
            pnlNavHome.Name = "pnlNavHome";
            pnlNavHome.Size = new System.Drawing.Size(206, 44);
            pnlNavHome.TabIndex = 2;
            pnlNavHome.Click += NavHome_Click;
            // 
            // lblNavHomeIcon
            // 
            lblNavHomeIcon.AutoSize = true;
            lblNavHomeIcon.BackColor = System.Drawing.Color.Transparent;
            lblNavHomeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavHomeIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblNavHomeIcon.Location = new System.Drawing.Point(16, 11);
            lblNavHomeIcon.Name = "lblNavHomeIcon";
            lblNavHomeIcon.Size = new System.Drawing.Size(32, 21);
            lblNavHomeIcon.TabIndex = 0;
            lblNavHomeIcon.Text = "🏠";
            lblNavHomeIcon.Click += NavHome_Click;
            // 
            // lblNavHomeText
            // 
            lblNavHomeText.AutoSize = true;
            lblNavHomeText.BackColor = System.Drawing.Color.Transparent;
            lblNavHomeText.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavHomeText.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            lblNavHomeText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)196)), ((int)((byte)130)), ((int)((byte)20)));
            lblNavHomeText.Location = new System.Drawing.Point(46, 13);
            lblNavHomeText.Name = "lblNavHomeText";
            lblNavHomeText.Size = new System.Drawing.Size(46, 19);
            lblNavHomeText.TabIndex = 1;
            lblNavHomeText.Text = "Home";
            lblNavHomeText.Click += NavHome_Click;
            // 
            // pnlNavDevices
            // 
            pnlNavDevices.BackColor = System.Drawing.Color.Transparent;
            pnlNavDevices.Controls.Add(pnlDetailOverlay);
            pnlNavDevices.Controls.Add(lblNavDevicesIcon);
            pnlNavDevices.Controls.Add(lblNavDevicesText);
            pnlNavDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlNavDevices.Location = new System.Drawing.Point(12, 162);
            pnlNavDevices.Name = "pnlNavDevices";
            pnlNavDevices.Size = new System.Drawing.Size(206, 44);
            pnlNavDevices.TabIndex = 3;
            pnlNavDevices.Click += NavDevices_Click;
            // 
            // lblNavDevicesIcon
            // 
            lblNavDevicesIcon.AutoSize = true;
            lblNavDevicesIcon.BackColor = System.Drawing.Color.Transparent;
            lblNavDevicesIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavDevicesIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblNavDevicesIcon.Location = new System.Drawing.Point(16, 11);
            lblNavDevicesIcon.Name = "lblNavDevicesIcon";
            lblNavDevicesIcon.Size = new System.Drawing.Size(32, 21);
            lblNavDevicesIcon.TabIndex = 0;
            lblNavDevicesIcon.Text = "📋";
            lblNavDevicesIcon.Click += NavDevices_Click;
            // 
            // lblNavDevicesText
            // 
            lblNavDevicesText.AutoSize = true;
            lblNavDevicesText.BackColor = System.Drawing.Color.Transparent;
            lblNavDevicesText.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavDevicesText.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNavDevicesText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)90)), ((int)((byte)90)), ((int)((byte)90)));
            lblNavDevicesText.Location = new System.Drawing.Point(46, 13);
            lblNavDevicesText.Name = "lblNavDevicesText";
            lblNavDevicesText.Size = new System.Drawing.Size(55, 19);
            lblNavDevicesText.TabIndex = 1;
            lblNavDevicesText.Text = "Devices";
            lblNavDevicesText.Click += NavDevices_Click;
            // 
            // pnlNavAdmin
            // 
            pnlNavAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
            pnlNavAdmin.BackColor = System.Drawing.Color.Transparent;
            pnlNavAdmin.Controls.Add(lblNavAdminIcon);
            pnlNavAdmin.Controls.Add(lblNavAdminText);
            pnlNavAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            pnlNavAdmin.Location = new System.Drawing.Point(12, 660);
            pnlNavAdmin.Name = "pnlNavAdmin";
            pnlNavAdmin.Size = new System.Drawing.Size(206, 44);
            pnlNavAdmin.TabIndex = 4;
            pnlNavAdmin.Click += NavAdmin_Click;
            // 
            // lblNavAdminIcon
            // 
            lblNavAdminIcon.AutoSize = true;
            lblNavAdminIcon.BackColor = System.Drawing.Color.Transparent;
            lblNavAdminIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavAdminIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            lblNavAdminIcon.Location = new System.Drawing.Point(14, 10);
            lblNavAdminIcon.Name = "lblNavAdminIcon";
            lblNavAdminIcon.Size = new System.Drawing.Size(32, 21);
            lblNavAdminIcon.TabIndex = 0;
            lblNavAdminIcon.Text = "👤";
            lblNavAdminIcon.Click += NavAdmin_Click;
            // 
            // lblNavAdminText
            // 
            lblNavAdminText.AutoSize = true;
            lblNavAdminText.BackColor = System.Drawing.Color.Transparent;
            lblNavAdminText.Cursor = System.Windows.Forms.Cursors.Hand;
            lblNavAdminText.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblNavAdminText.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)90)), ((int)((byte)90)), ((int)((byte)90)));
            lblNavAdminText.Location = new System.Drawing.Point(46, 13);
            lblNavAdminText.Name = "lblNavAdminText";
            lblNavAdminText.Size = new System.Drawing.Size(49, 19);
            lblNavAdminText.TabIndex = 1;
            lblNavAdminText.Text = "Admin";
            lblNavAdminText.Click += NavAdmin_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)252)), ((int)((byte)255)));
            pnlMain.Controls.Add(pnlCardList);
            pnlMain.Controls.Add(pnlCardAdd);
            pnlMain.Controls.Add(lblDashboardTitle);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(230, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(970, 750);
            pnlMain.TabIndex = 1;
            // 
            // pnlCardList
            // 
            pnlCardList.BackColor = System.Drawing.Color.White;
            pnlCardList.Controls.Add(lblCardListTitle);
            pnlCardList.Controls.Add(txtSearchDevice);
            pnlCardList.Controls.Add(flpDeviceList);
            pnlCardList.Location = new System.Drawing.Point(392, 80);
            pnlCardList.Name = "pnlCardList";
            pnlCardList.Size = new System.Drawing.Size(400, 430);
            pnlCardList.TabIndex = 2;
            pnlCardList.Paint += Card_Paint;
            // 
            // lblCardListTitle
            // 
            lblCardListTitle.AutoSize = true;
            lblCardListTitle.BackColor = System.Drawing.Color.Transparent;
            lblCardListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblCardListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            lblCardListTitle.Location = new System.Drawing.Point(20, 16);
            lblCardListTitle.Name = "lblCardListTitle";
            lblCardListTitle.Size = new System.Drawing.Size(141, 20);
            lblCardListTitle.TabIndex = 0;
            lblCardListTitle.Text = "Danh sách Máy (IP)";
            // 
            // txtSearchDevice
            // 
            txtSearchDevice.BackColor = System.Drawing.Color.White;
            txtSearchDevice.BaseColor = System.Drawing.Color.White;
            txtSearchDevice.BorderColorA = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)158)), ((int)((byte)255)));
            txtSearchDevice.BorderColorB = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            txtSearchDevice.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearchDevice.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)60)), ((int)((byte)60)), ((int)((byte)60)));
            txtSearchDevice.Hint = "Tìm kiếm...";
            txtSearchDevice.Location = new System.Drawing.Point(20, 50);
            txtSearchDevice.MaxLength = 32767;
            txtSearchDevice.Multiline = false;
            txtSearchDevice.Name = "txtSearchDevice";
            txtSearchDevice.PasswordChar = '\0';
            txtSearchDevice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            txtSearchDevice.SelectedText = "";
            txtSearchDevice.SelectionLength = 0;
            txtSearchDevice.SelectionStart = 0;
            txtSearchDevice.Size = new System.Drawing.Size(360, 33);
            txtSearchDevice.TabIndex = 1;
            txtSearchDevice.TabStop = false;
            txtSearchDevice.UseSystemPasswordChar = false;
            txtSearchDevice.TextChanged += txtSearchDevice_TextChanged;
            // 
            // flpDeviceList
            // 
            flpDeviceList.AutoScroll = true;
            flpDeviceList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpDeviceList.Location = new System.Drawing.Point(20, 96);
            flpDeviceList.Name = "flpDeviceList";
            flpDeviceList.Size = new System.Drawing.Size(360, 314);
            flpDeviceList.TabIndex = 2;
            flpDeviceList.WrapContents = false;
            // 
            // pnlCardAdd
            // 
            pnlCardAdd.BackColor = System.Drawing.Color.White;
            pnlCardAdd.Controls.Add(lblCardAddTitle);
            pnlCardAdd.Controls.Add(btnAddDevice);
            pnlCardAdd.Controls.Add(lblCardAddSub);
            pnlCardAdd.Location = new System.Drawing.Point(32, 80);
            pnlCardAdd.Name = "pnlCardAdd";
            pnlCardAdd.Size = new System.Drawing.Size(340, 430);
            pnlCardAdd.TabIndex = 1;
            pnlCardAdd.Paint += Card_Paint;
            // 
            // lblCardAddTitle
            // 
            lblCardAddTitle.AutoSize = true;
            lblCardAddTitle.BackColor = System.Drawing.Color.Transparent;
            lblCardAddTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            lblCardAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)50)), ((int)((byte)50)), ((int)((byte)50)));
            lblCardAddTitle.Location = new System.Drawing.Point(20, 18);
            lblCardAddTitle.Name = "lblCardAddTitle";
            lblCardAddTitle.Size = new System.Drawing.Size(133, 20);
            lblCardAddTitle.TabIndex = 0;
            lblCardAddTitle.Text = "Thêm Thiết bị Mới";
            // 
            // btnAddDevice
            // 
            btnAddDevice.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)220)), ((int)((byte)223)), ((int)((byte)230)));
            btnAddDevice.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnAddDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddDevice.DangerColor = System.Drawing.Color.FromArgb(((int)((byte)245)), ((int)((byte)108)), ((int)((byte)108)));
            btnAddDevice.DefaultColor = System.Drawing.Color.White;
            btnAddDevice.Font = new System.Drawing.Font("Segoe UI", 22F);
            btnAddDevice.HoverTextColor = System.Drawing.Color.White;
            btnAddDevice.InfoColor = System.Drawing.Color.FromArgb(((int)((byte)144)), ((int)((byte)147)), ((int)((byte)153)));
            btnAddDevice.Location = new System.Drawing.Point(135, 160);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.PrimaryColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)180)), ((int)((byte)40)));
            btnAddDevice.Size = new System.Drawing.Size(70, 70);
            btnAddDevice.SuccessColor = System.Drawing.Color.FromArgb(((int)((byte)103)), ((int)((byte)194)), ((int)((byte)58)));
            btnAddDevice.TabIndex = 1;
            btnAddDevice.Text = "+";
            btnAddDevice.TextColor = System.Drawing.Color.White;
            btnAddDevice.WarningColor = System.Drawing.Color.FromArgb(((int)((byte)230)), ((int)((byte)162)), ((int)((byte)60)));
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // lblCardAddSub
            // 
            lblCardAddSub.BackColor = System.Drawing.Color.Transparent;
            lblCardAddSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblCardAddSub.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)140)), ((int)((byte)140)), ((int)((byte)140)));
            lblCardAddSub.Location = new System.Drawing.Point(40, 250);
            lblCardAddSub.Name = "lblCardAddSub";
            lblCardAddSub.Size = new System.Drawing.Size(260, 50);
            lblCardAddSub.TabIndex = 2;
            lblCardAddSub.Text = "Bắt đầu thêm một thiết bị mới vào hệ thống";
            lblCardAddSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)40)), ((int)((byte)40)), ((int)((byte)40)));
            lblDashboardTitle.Location = new System.Drawing.Point(32, 24);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new System.Drawing.Size(157, 37);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // Menuu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 750);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            MinimumSize = new System.Drawing.Size(1000, 600);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Thiết bị NL";
            Load += Menuu_Load;
            pnlSidebar.ResumeLayout(false);
            pnlDetailOverlay.ResumeLayout(false);
            pnlDetailOverlay.PerformLayout();
            tabDetail.ResumeLayout(false);
            tabCurrent.ResumeLayout(false);
            tabCurrent.PerformLayout();
            pnlStatTds.ResumeLayout(false);
            pnlStatTds.PerformLayout();
            pnlStatPh.ResumeLayout(false);
            pnlStatPh.PerformLayout();
            pnlStatTemp.ResumeLayout(false);
            pnlStatTemp.PerformLayout();
            tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            pnlLogo.ResumeLayout(false);
            pnlNavHome.ResumeLayout(false);
            pnlNavHome.PerformLayout();
            pnlNavDevices.ResumeLayout(false);
            pnlNavDevices.PerformLayout();
            pnlNavAdmin.ResumeLayout(false);
            pnlNavAdmin.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlCardList.ResumeLayout(false);
            pnlCardList.PerformLayout();
            pnlCardAdd.ResumeLayout(false);
            pnlCardAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblOrgName;
        private System.Windows.Forms.Panel pnlNavHome;
        private System.Windows.Forms.Label lblNavHomeIcon;
        private System.Windows.Forms.Label lblNavHomeText;
        private System.Windows.Forms.Panel pnlNavDevices;
        private System.Windows.Forms.Label lblNavDevicesIcon;
        private System.Windows.Forms.Label lblNavDevicesText;
        private System.Windows.Forms.Panel pnlNavAdmin;
        private System.Windows.Forms.Label lblNavAdminIcon;
        private System.Windows.Forms.Label lblNavAdminText;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDashboardTitle;

        private System.Windows.Forms.Panel pnlCardAdd;
        private System.Windows.Forms.Label lblCardAddTitle;
        private ReaLTaiizor.Controls.HopeButton btnAddDevice;
        private System.Windows.Forms.Label lblCardAddSub;

        private System.Windows.Forms.Panel pnlCardList;
        private System.Windows.Forms.Label lblCardListTitle;
        private ReaLTaiizor.Controls.HopeTextBox txtSearchDevice;
        private System.Windows.Forms.FlowLayoutPanel flpDeviceList;

        private System.Windows.Forms.Panel pnlDetailOverlay;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.Label btnCloseDetail;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.TabPage tabCurrent;
        private System.Windows.Forms.Panel pnlStatTds;
        private System.Windows.Forms.Label lblStatTdsIcon;
        private System.Windows.Forms.Label lblStatTdsValue;
        private System.Windows.Forms.Label lblStatTdsTitle;
        private System.Windows.Forms.Panel pnlStatPh;
        private System.Windows.Forms.Label lblStatPhIcon;
        private System.Windows.Forms.Label lblStatPhValue;
        private System.Windows.Forms.Label lblStatPhTitle;
        private System.Windows.Forms.Panel pnlStatTemp;
        private System.Windows.Forms.Label lblStatTempIcon;
        private System.Windows.Forms.Label lblStatTempValue;
        private System.Windows.Forms.Label lblStatTempTitle;
        private System.Windows.Forms.Label lblChartRange;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}