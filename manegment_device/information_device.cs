namespace manegment_device;

public class information_device
{
    private int ID;
    private float nong_do_pH;
    private float tds;
    private float nhiet_do;
    private TimeSpan thoigian;

    public int id
    {
        get
        {
            return ID;
        }
        set
        {
            ID = value;
        }
    }
    public float  Nong_do_pH { get; set; }
    public float Tds { get; set; }
    public float Nhiet_do { get; set; }
    public TimeSpan  ThoiGian { get; set; }

    public information_device()
    {
        
    }

    public information_device(int id, float nong_do_pH, float tds, float nhiet_do, TimeSpan thoigian)
    {
        this.ID = id;
        this.Nong_do_pH = nong_do_pH;
        this.Tds = tds;
        this.Nhiet_do = nhiet_do;
        this.ThoiGian = thoigian;
    }
    
}