// BAI 2
class Thietbi
{
    public virtual void Nhap()
    {
        Console.WriteLine("Tinh nang: ");
    }
    public virtual void Xuat()
    {
        Console.WriteLine("Thiet bi dang ...");
    }
}
class Mayquat:Thietbi
{
    private string hd;
    public override void Nhap()
    {
        Console.WriteLine("MAY QUAT: Ban co 2 lua chon");
        Console.WriteLine("1. ON");
        Console.WriteLine("2. OFF");
        while (true)
        {
            Console.Write("Lua chon cua ban: ");
            hd=Console.ReadLine();
            if (hd=="1" || hd=="2")
            {
                break;
            }
        }
    }
    public override void Xuat()
    {
        if (hd=="1")
        {
            Console.WriteLine("May quat dang mo!");
        }
        else if (hd=="1")
        {
            Console.WriteLine("May quat dang tat!");
        }
    }
}
class Dieuhoa:Thietbi
{
    private string hd;
    public override void Nhap()
    {
        Console.WriteLine("DIEU HOA: Ban co 2 lua chon");
        Console.WriteLine("1. ON");
        Console.WriteLine("2. OFF");
        while (true)
        {
            Console.Write("Lua chon cua ban: ");
            hd=Console.ReadLine();
            if (hd=="1" || hd=="2")
            {
                break;
            }
        }
    }
    public override void Xuat()
    {
        if (hd=="1")
        {
            Console.WriteLine("Dieu hoa dang mo!");
        }
        else if (hd=="2")
        {
            Console.WriteLine("Dieu hoa dang tat!");
        }
    }
}
class Tivi:Thietbi
{
    private string hd;
    public override void Nhap()
    {
        Console.WriteLine("TIVI: Ban co 2 lua chon");
        Console.WriteLine("1. ON");
        Console.WriteLine("2. OFF");
        while (true)
        {
            Console.Write("Lua chon cua ban: ");
            hd=Console.ReadLine();
            if (hd=="1" || hd=="2")
            {
                break;
            }
        }
    }
    public override void Xuat()
    {
        if (hd=="1")
        {
            Console.WriteLine("Tivi dang mo!");
        }
        else if (hd=="2")
        {
            Console.WriteLine("Tivi dang tat!");
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        Thietbi mq = new Mayquat();
        Thietbi dh = new Dieuhoa();
        Thietbi tv = new Tivi();
        Console.WriteLine("MENU: ");
        Console.WriteLine("1. May quat");
        Console.WriteLine("2. Dieu hoa");
        Console.WriteLine("3. Tivi");
        Console.WriteLine("0. Ket thuc");
        while (true)
        {
            Console.Write("Chon menu: ");
            string menu=Console.ReadLine();
            if (menu=="1")
            {
                mq.Nhap();
                mq.Xuat();
            }
            if (menu=="2")
            {
                dh.Nhap();
                dh.Xuat();
            }
            if (menu=="3")
            {
                tv.Nhap();
                tv.Xuat();
            }
            if (menu=="0")
            {
                Console.WriteLine("KET THUC CHUONG TRINH");
                break;
            }
        }
    }
}