
class Vinhome
{
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap thong tin");
    }
    public virtual void Tinh()
    {
        Console.WriteLine("Tinh gia phong ");
    }
    public virtual void Max()
    {
        Console.WriteLine("------------ CAN HO BASIC CAO GIA NHAT -------------");
    }
    public virtual void Xuat()
    {
        Console.WriteLine("--------- XUAT THONG TIN ----------");
    }
}
class Basic:Vinhome
{
    private string [] id;
    private double [] area;
    private double [] floor;
    private double [] price;
    private double [] gia;
    private int n;
    public override void Nhap()
    {
        Console.Write("SL can ho can nhap: ");
        n=int.Parse(Console.ReadLine());
        id= new string[n];
        area=new double[n];
        floor=new double[n];
        price=new double[n];
        gia=new double[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("CAN HO BASIC THU {0}",(i+1));
            Console.Write("ID: ");
            id[i]=Console.ReadLine();
            Console.Write("AREA: ");
            area[i]=double.Parse(Console.ReadLine());
            Console.Write("FLOOR: ");
            floor[i]=double.Parse(Console.ReadLine());
            Console.Write("PRICE: ");
            price[i]=double.Parse(Console.ReadLine());
        }
    }
    public override void Tinh()
    {
        for (int i=0;i<n;i++)
        {
            gia[i]=price[i]*area[i];
        }
    }
    public override void Xuat()
    {
        base.Xuat();
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("ID: {0} | AREA: {1} | FLOOR: {2} | GIA SAN CO BAN: {3} | GIA: {4}",id[i],area[i],floor[i],price[i],gia[i]);
        }
    }
    public override void Max()
    {
        base.Max();
        double max=gia[0];
        for (int i=1;i<n;i++)
        {
            if (gia[i]>max)
            {
                max=gia[i];
            }
        }
        for (int i=0;i<n;i++)
        {
            if (max==gia[i])
            {
                Console.WriteLine("ID: {0} | AREA: {1} | FLOOR: {2} | GIA SAN CO BAN: {3} | GIA: {4}",id[i],area[i],floor[i],price[i],gia[i]);
            }
        }
    }
}
class Condo:Vinhome
{
    private string [] id;
    private double [] area;
    private double [] floor;
    private double [] price;
    private double [] gia;
    private string [] view;
    private double [] heso;
    private string [] huong;
    private int n;
    public override void Nhap()
    {
        Console.Write("SL can ho can nhap: ");
        n=int.Parse(Console.ReadLine());   
        id= new string[n];
        area=new double[n];
        floor=new double[n];
        price=new double[n];
        gia=new double[n]; 
        view=new string[n];
        heso=new double[n];
        huong= new string[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("CAN HO CAO CAP THU {0}",(i+1));
            Console.Write("ID: ");
            id[i]=Console.ReadLine();
            Console.Write("AREA: ");
            area[i]=double.Parse(Console.ReadLine());
            Console.Write("FLOOR: ");
            floor[i]=double.Parse(Console.ReadLine());
            Console.WriteLine("VIEW: 1. bien - 2. ho boi - 3. thanh pho - 4. khac ");
            Console.Write(" VIEW (Chon 1,2,3 or 4): ");
            view[i]=Console.ReadLine();
            Console.Write("PRICE: ");
            price[i]=double.Parse(Console.ReadLine());
            if (view[i]=="1")
            {
                heso[i]=1.4;
                huong[i]="Bien";
            }
            else if (view[i]=="2")
            {
                heso[i]=1.1;
                huong[i]="Ho boi";
            }
            else if (view[i]=="3")
            {
                heso[i]=1.2;
                huong[i]="Thanh pho";
            }
            else if (view[i]=="4")
            {
                heso[i]=1;
                huong[i]="Khac";
            }
        }
    }
    public override void Tinh()
    {
        for (int i=0;i<n;i++)
        {
            gia[i]=price[i]*area[i]*heso[i];
        }
    }
    public override void Xuat()
    {
        base.Xuat();
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("ID: {0} | AREA: {1} | FLOOR: {2} | VIEW: {3} | GIA SAN CO BAN: {4} | GIA: {5}",id[i],area[i],floor[i],huong[i],price[i],gia[i]);
        }
    }
    public override void Max()
    {
        base.Max();
        double max=gia[0];
        for (int i=1;i<n;i++)
        {
            if (max<gia[i])
            {
                max=gia[i];
            }
        }
        for (int i=0;i<n;i++)
        {
            if(max==gia[i])
            {
                Console.WriteLine("ID: {0} | AREA: {1} | FLOOR: {2} | VIEW: {3} | GIA SAN CO BAN: {4} | GIA: {5}",id[i],area[i],floor[i],huong[i],price[i],gia[i]);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vinhome b = new Basic();
        Vinhome c = new Condo();
        while (true)
        {
            Console.WriteLine("MENU: ");
            Console.WriteLine("1. CAN HO BASIC");
            Console.WriteLine("2. CAN HO CAO CAP");
            Console.WriteLine("0. KET THUC");
            Console.Write("Ban chon: ");
            string menu=Console.ReadLine();
            if (menu=="1")
            {
                b.Nhap();
                b.Tinh();
                b.Xuat();
                b.Max();
                Console.WriteLine("KET THUC CHUONG TRINH NHAP THONG TIN CAN HO BASIC!!!");
            }
            if (menu=="2")
            {
                c.Nhap();
                c.Tinh();
                c.Xuat();
                c.Max();
                Console.WriteLine("KET THUC CHUONG TRINH NHAP THONG TIN CAN HO CAO CAP!!!");
            }
            if (menu=="0")
            {
                Console.WriteLine("BAN DA CHON KET THUC!!!");
                break;
            }
        }
    }
}