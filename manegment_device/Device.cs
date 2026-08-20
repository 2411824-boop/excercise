namespace manegment_device;

public class Device:information_device
{
    private string ma_may;
    public string Ma_may
    {
        get { return ma_may; }
        set { ma_may = value; }
    }
    public int Ho_nuoi_id { get; set; } // Trỏ tới ID của Hồ thay vì Tên Hồ
    public string Current_IP { get; set; }
    public bool Trang_thai { get; set; }
    
    public Device()
    {
    }
    public Device(string maMay, int hoNuoiId, string currentIp = "0.0.0.0", bool trangThai = true)
    {
        this.Ma_may = maMay;
        this.Ho_nuoi_id = hoNuoiId;
        this.Current_IP = currentIp;
        this.Trang_thai = trangThai;
    }
}