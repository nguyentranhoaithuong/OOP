// // BAI 1
class Hinhhoc
{
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap....");
    }
    public virtual void Chuvi()
    {
        Console.WriteLine("Chu vi = ");
    }
    public virtual void Dientich()
    {
        Console.WriteLine("Dien tich = ");
    }
}
class Hinhchunhat:Hinhhoc
{
    private double dai, rong;
    public override void Nhap()
    {
        // base.Nhap();
        Console.Write("Dai: ");
        dai=double.Parse(Console.ReadLine());
        Console.Write("Rong: ");
        rong=double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        // base.Chuvi();
        Console.WriteLine("Chu vi hinh chu nhat = {0}",(dai+rong)/2);
    }
    public override void Dientich()
    {
        // base.Dientich();
        Console.WriteLine("Dien tich hinh chu nhat = {0}",dai*rong);
    }
}
class Hinhtron:Hinhhoc
{
    private double r;
    public override void Nhap()
    {
        // base.Nhap();
        Console.Write("Ban kinh: ");
        r=double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        // base.Chuvi();
        Console.WriteLine("Chu vi hinh tron = {0}",2*r*3.14);
    }
    public override void Dientich()
    {
        // base.Dientich();
        Console.WriteLine("Dien tich hinh tron = {0}",r*r*3.14);
    }
}
class Hinhtamgiac:Hinhhoc
{
    private double a,b,c;
    public override void Nhap()
    {
        // base.Nhap();
        Console.Write("canh thu nhat: ");
        a=double.Parse(Console.ReadLine());
        Console.Write("canh thu hai: ");
        b=double.Parse(Console.ReadLine());
        Console.Write("canh thu ba: ");
        c=double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        Console.WriteLine("Chu vi hinh tam giac = {0}",(a+b+c));
    }
    public override void Dientich()
    {
        double p=(a+b+c)/2;
        double s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        Console.WriteLine("Dien tich hinh tam giac = {0}",s);
    }
}
class Hinhvuong:Hinhhoc
{
    private double canh;
    public override void Nhap()
    {
        // base.Nhap();
        Console.Write("Canh: ");
        canh=double.Parse(Console.ReadLine());
    }
    public override void Chuvi()
    {
        Console.WriteLine("Chu vi hinh vuong = {0}",canh*4);
    }
    public override void Dientich()
    {
        Console.WriteLine("Dien tich hinh vuong = {0}",canh*canh);
    }
}
class program
{
    static void Main(string[] args)
    {
        Hinhhoc hcn = new Hinhchunhat();
        Hinhhoc ht = new Hinhtron();
        Hinhhoc htg = new Hinhtamgiac();
        Hinhhoc hv = new Hinhvuong();
        Console.WriteLine("*********Ban co 5 lua chon********* ");
        Console.WriteLine("1. Hinh chu nhat. ");
        Console.WriteLine("2. Hinh tron. ");
        Console.WriteLine("3. Hinh tam giac. ");
        Console.WriteLine("4. Hinh vuong. ");
        Console.WriteLine("0: Ket thuc.");
        while (true)
        {
            Console.Write("Lua chon cua ban: ");
            string b=Console.ReadLine();
            if (b=="1")
            {
                Console.WriteLine("HINH CHU NHAT");
                hcn.Nhap();
                hcn.Chuvi();
                hcn.Dientich();
            }
            else if (b=="2")
            {
                Console.WriteLine("HINH TRON");
                ht.Nhap();
                ht.Chuvi();
                ht.Dientich();
            }
            else if (b=="3")
            {
                Console.WriteLine("HINH TAM GIAC");
                htg.Nhap();
                htg.Chuvi();
                htg.Dientich();
            }
            else if (b=="4")
            {
                Console.WriteLine("HINH VUONG");
                hv.Nhap();
                hv.Chuvi();
                hv.Dientich();
            }
            else if (b=="0")
            {
                Console.WriteLine("======== KET THUC CHUONG TRINH ========");
                break;
            }
        }
    }
}