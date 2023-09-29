// quản lí sinh viên
class Sinhvien 
{
    private string id;
    private string lop;
    private double kt;
    public double KT 
    {
        get {return kt;}
        set {kt=value;}
    }
    public virtual void Nhap()
    {
        Console.Write("ID: ");
        id=Console.ReadLine();
        Console.Write("Lop: ");
        lop=Console.ReadLine();
    }
    public virtual void Xuat()
    {
        Console.Write("ID: {0}| Lop: {1}| ",id,lop);
    }
    public virtual double Diemtb()
    {
        return 0;
    }
    public virtual double Hocbong()
    {
        return 0;
    }
    public virtual string Masv()
    {
        return id;
    }
    public virtual string Lop()
    {
        return lop;
    }
}
class Tainang:Sinhvien
{
    private double diem1;
    private double diem2;
    private double dtb;
    private double hb;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Diem 1: ");
        diem1=double.Parse(Console.ReadLine());
        Console.Write("Diem 2: ");
        diem2=double.Parse(Console.ReadLine());
    }
    public override double Diemtb()
    {
        dtb=(diem1+diem2)/2;
        return dtb;
    }
    public override double Hocbong()
    {
        if (dtb>=8 && dtb<9)
        {
            hb=1000000;
        }
        else if (dtb>=9)
        {
            hb=1500000;
        }
        return hb;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Diem 1: {0}| Diem2: {1}| DTB: {2}| Hoc bong: {3} - SV Tai Nang",diem1,diem2,dtb,hb);
    }
    public override string Masv()
    {
        return base.Masv();
    }
    public override string Lop()
    {
        return base.Lop();
    }
}
class Chinhquy:Sinhvien
{
    private double toan;
    private double anh;
    private double dtb;
    private double hb;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Toan: ");
        toan=double.Parse(Console.ReadLine());
        Console.Write("Anh: ");
        anh=double.Parse(Console.ReadLine());
    }
    public override double Diemtb()
    {
        dtb=(toan+anh)/2;
        return dtb;
    }
    public override double Hocbong()
    {
        if (dtb>=8 && dtb<9)
        {
            hb=1500000;
        }
        else if (dtb>=9)
        {
            hb=2000000;
        }
        return hb;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Toan: {0}| anh: {1}| DTB: {2}| Hoc bong: {3} - SV Chinh Quy",toan,anh,dtb,hb);
    }
    public override string Masv()
    {
        return base.Masv();
    }
    public override string Lop()
    {
        return base.Lop();
    }
}
class Chatluongcao:Sinhvien
{
    private double tin;
    private double anh;
    private double dtb;
    private double hb;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Tin: ");
        tin=double.Parse(Console.ReadLine());
        Console.Write("Anh: ");
        anh=double.Parse(Console.ReadLine());
    }
    public override double Diemtb()
    {
        dtb=(tin+anh)/2;
        return dtb;
    }
    public override double Hocbong()
    {
        if (dtb>=8 && dtb<9)
        {
            hb=2000000;
        }
        else if (dtb>=9)
        {
            hb=2500000;
        }
        return hb;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Tin: {0}| anh: {1}| DTB: {2}| Hoc bong: {3} - SV Chat luong cao",tin,anh,dtb,hb);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Sinhvien [] sv;
        int n;
        Console.Write("So luong SV: ");
        n=int.Parse(Console.ReadLine());
        sv = new Sinhvien[n];
        double p=0;
        for (int i=0;i<n;i++)
        {
            int m;
            do
            {
                Console.WriteLine("1. SV Tai Nang");
                Console.WriteLine("2. SV Chinh Quy");
                Console.WriteLine("3. SV Chat luong cao");
                Console.Write("Chon: ");
                m=int.Parse(Console.ReadLine());
            }
            while (m<=0 || m>3);
            switch(m)
            {
                case 1:
                {
                    Sinhvien sv1 = new Tainang();
                    sv1.Nhap();
                    sv1.Diemtb();
                    sv1.Hocbong();
                    sv[i]=sv1;
                    p=p+sv1.Hocbong();
                    // sv[i].KT=1;
                    break;
                }
                case 2:
                {
                    Sinhvien sv2 = new Chinhquy();
                    sv2.Nhap();
                    sv2.Diemtb();
                    sv2.Hocbong();
                    sv[i]=sv2;
                    p=p+sv2.Hocbong();
                    // sv[i].KT=2;
                    break;
                }
                case 3:
                {
                    Sinhvien sv3 = new Chatluongcao();
                    sv3.Nhap();
                    sv3.Diemtb();
                    sv3.Hocbong();
                    sv[i]=sv3;
                    p=p+sv3.Hocbong();
                    // sv[i].KT=3;
                    break;
                }
            }
        }
        Console.WriteLine("******************************************************");
        Console.WriteLine("DANH SACH SINH VIEN CO HOC BONG");
        for (int i=0;i<n;i++)
        {
            if (sv[i].Hocbong()!=0)
            {
                sv[i].Xuat();
            }
        }
        Console.WriteLine("******************************************************");
        Console.WriteLine("TONG SO TIEN HOC BONG: {0}",p);
        Console.WriteLine("******************************************************");
        Console.WriteLine("SINH VIEN CO THANH TICH CAO NHAT");
        double max = sv[0].Diemtb();
        for (int i=1;i<n;i++)
        {
            if (max < sv[i].Diemtb())
            {   
                max = sv[i].Diemtb();
            }
        }
        for (int i=0;i<n;i++)
        {
            if (max==sv[i].Diemtb())
            {
                sv[i].Xuat();
            }
        }
        Console.WriteLine("******************************************************");
        Console.WriteLine("TIM KIEM SINH VIEN");
        Console.Write("Nhap ma sv can tim: ");
        string t=Console.ReadLine();
        for (int i=0;i<n;i++)
        {
            if (t==sv[i].Masv())
            {
                sv[i].Xuat();
            }
        }
        Console.WriteLine("******************************************************");
        Console.WriteLine("SAP XEP SINH VIEN THEO LOP");
        for (int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                foreach (int k in sv[i].Lop())
                {
                    foreach (int l in sv[i].Lop())
                    {
                        if (k<l)
                        {
                            Sinhvien tmp=sv[i];
                            sv[i]=sv[j];
                            sv[j]=tmp;
                        }
                    }
                }
            }
            sv[i].Xuat();
        }
    }
}