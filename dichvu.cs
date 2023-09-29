class DICHVU
{
    private string TenKhach;
    private string DiemNhan;
    private string DiemDen;
    public virtual void Nhap()
    {
        Console.Write("Ten Khach: ");
        TenKhach=Console.ReadLine();
        Console.Write("Diem Nhan: ");
        DiemNhan=Console.ReadLine();
        Console.Write("Nhap Diem Den: ");
        DiemDen=Console.ReadLine();
    }
    public virtual double Phidichvu()
    {
        return 0;
    }
    public virtual void Xuat()
    {
        Console.Write("Ten Khach: {0}| Diem Nhan: {1}| Diem Den: {2}| ",TenKhach,DiemNhan,DiemDen);
    }
    public virtual double Giamgia()
    {
        return 0;
    }
}
class Xemay:DICHVU
{
    private double khoangcach;
    private double dongia;
    private double giamgia;
    private double phidv;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Khoang cach: ");
        khoangcach=double.Parse(Console.ReadLine());
        Console.Write("Don gia: ");
        dongia=double.Parse(Console.ReadLine());
        Console.Write("Giam gia: ");
        giamgia=double.Parse(Console.ReadLine());
    }
    public override double Phidichvu()
    {
        phidv=khoangcach*dongia-giamgia;
        return phidv;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(" Khoang cach: {0}| Don gia: {1}| Giam gia: {2}| PHI DV: {3} - XE MAY",khoangcach,dongia,giamgia,phidv);
    }
}
class Oto:DICHVU
{
    private string loaixe;
    private double khoangcach;
    private double dongia;
    private double giamgia;
    private double phidv;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Loai xe: ");
        loaixe=Console.ReadLine();
        Console.Write("Khoang cach: ");
        khoangcach=double.Parse(Console.ReadLine());
        Console.Write("Don gia: ");
        dongia=double.Parse(Console.ReadLine());
        Console.Write("Giam gia: ");
        giamgia=double.Parse(Console.ReadLine());
    }
    public override double Phidichvu()
    {
        if (loaixe=="4 cho")
        {
            phidv=(khoangcach*dongia)*1-giamgia;
        }
        else if (loaixe=="7 cho")
        {
            phidv=(khoangcach*dongia)*1.5-giamgia;
        }
        return phidv;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Loai xe: {0}|  Khoang cach: {1}| Don gia: {2}| Giam gia: {3}| PHI DV: {4} - O TO",loaixe,khoangcach,dongia,giamgia,phidv);
    }
    public override double Giamgia()
    {
        return giamgia;
    }
}
class Giaohang:DICHVU
{
    private double giasp;
    private double khoangcach;
    private double dongia;
    private double giamgia;
    private double phidv;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Khoang cach: ");
        khoangcach=double.Parse(Console.ReadLine());
        Console.Write("Don gia: ");
        dongia=double.Parse(Console.ReadLine());
        Console.Write("Gia SP: ");
        giasp=double.Parse(Console.ReadLine());
        Console.Write("Giam gia: ");
        giamgia=double.Parse(Console.ReadLine());
    }
    public override double Phidichvu()
    {
        phidv=giasp+khoangcach*dongia-giamgia;
        return phidv;
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine("Loai xe: {0}|  Khoang cach: {0}| Don gia: {1}| Gia SP: {2}| Giam gia: {3}| PHI DV: {4} - GIAO HANG",khoangcach,dongia,giasp,giamgia,phidv);
    }
    public override double Giamgia()
    {
        return giamgia;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("So luong dich vu xe may: ");
        int x= int.Parse(Console.ReadLine());
        Console.Write("So luong dich vu O to: ");
        int y= int.Parse(Console.ReadLine());
        Console.Write("So luong dich vu giao hang: ");
        int z= int.Parse(Console.ReadLine());
        DICHVU [] xm;
        xm=new DICHVU[x];
        DICHVU [] oto;
        oto=new DICHVU[y];
        DICHVU [] gh;
        gh=new DICHVU[z];
        double dtxm=0;
        double dtoto=0;
        double dtgh=0;
        Console.WriteLine("Nhap thong tin dich vu xe may: ");
        for (int i=0;i<x;i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}",(i+1));
            DICHVU xemay=new Xemay();
            xemay.Nhap();
            xemay.Phidichvu();
            xm[i]=xemay;
            dtxm=dtxm+xemay.Phidichvu();
        }
        Console.WriteLine("Nhap thong tin dich vu oto: ");
        for (int i=0;i<y;i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}",(i+1));
            DICHVU ot =new Oto();
            ot.Nhap();
            ot.Phidichvu();
            oto[i]=ot;
            dtoto=dtoto+ot.Phidichvu();
        }
        Console.WriteLine("Nhap thong tin dich vu giao hang: ");
        for (int i=0;i<z;i++)
        {
            Console.WriteLine("Nhap thong tin khach hang thu {0}",(i+1));
            DICHVU g =new Giaohang();
            g.Nhap();
            g.Phidichvu();
            gh[i]=g;
            dtgh=dtgh+g.Phidichvu();
        }
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("DANH SACH DICH VU XE MAY:");
        for (int i=0;i<x;i++)
        {
            xm[i].Xuat();
        }
        Console.WriteLine("DANH SACH DICH VU OTO:");
        for (int j=0;j<y;j++)
        {
            oto[j].Xuat();
        }
        Console.WriteLine("DANH SACH DICH VU GIAO HANG:");
        for (int k=0;k<z;k++)
        {
            gh[k].Xuat();
        }
        Console.WriteLine("DICH VU XE MAY KHONG SU DUNG GIAM GIA: ");
        for (int i=0;i<x;i++)
        {
            if (xm[i].Giamgia()==0)
            {
                xm[i].Xuat();
            }
        }
        Console.WriteLine("DICH VU O TO KHONG SU DUNG GIAM GIA: ");
        for (int i=0;i<y;i++)
        {
            if (oto[i].Giamgia()==0)
            {
                oto[i].Xuat();
            }
        }
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("DICH VU GIAO HANG KHONG SU DUNG GIAM GIA: ");
        for (int i=0;i<x;i++)
        {
            if (xm[i].Giamgia()==0)
            {
                xm[i].Xuat();
            }
        }
        for (int i=0;i<y;i++)
        {
            if (oto[i].Giamgia()==0)
            {
                oto[i].Xuat();
            }
        }
        for (int i=0;i<z;i++)
        {
            if (gh[i].Giamgia()==0)
            {
                gh[i].Xuat();
            }
        }
    }
}
