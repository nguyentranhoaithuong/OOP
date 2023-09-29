class Edition
{
    public virtual void Nhap()
    {
        Console.WriteLine("---------- NHAP THONG TIN ---------");
    }
    public virtual void Sapxep()
    {
        Console.WriteLine("--------- SAP XEP THONG TIN ---------"); 
    }
    public virtual void Xuat()
    {
        Console.WriteLine("------- XUAT THONG TIN --------- ");
    }
    public virtual void Timkiem()
    {
        Console.WriteLine("--------- TIM KIEM THONG TIN -----------");
    }
}
class Book:Edition
{
    private string[] title;
    private string[] author;
    private double[] year;
    private string[] publisher;
    private int n;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("SL BOOK: ");
        n=int.Parse(Console.ReadLine());
        title=new string[n];
        author=new string[n];
        year=new double[n];
        publisher=new string[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("BOOK Thu {0}",(i+1));
            Console.Write("Title: ");
            title[i]=Console.ReadLine();
            Console.Write("Author: ");
            author[i]=Console.ReadLine();
            Console.Write("Year: ");
            year[i]=double.Parse(Console.ReadLine());
            Console.Write("Publisher: ");
            publisher[i]=Console.ReadLine();
        }
    }
    public override void Sapxep()
    {
        for (int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                foreach (int k in title[i])
                {
                    foreach (int l in title[j])
                    {
                        if (k>=l)
                        {
                            string tmp=title[i];
                            string a=author[i];
                            double b=year[i];
                            string c=publisher[i];
                            title[i]=title[j];
                            author[i]=author[j];
                            year[i]=year[j];
                            publisher[i]=publisher[j];
                            title[j]=tmp;
                            author[j]=a;
                            year[j]=b;
                            publisher[j]=c;
                        }
                    }
                }
            }
        }
    }
    public override void Xuat()
    {
        base.Xuat();
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("TITLE: {0} - AUTHOR: {1} - YEAR: {2} - PUBLISHER: {3}",title[i],author[i],year[i],publisher[i]);
        }
    }
    public override void Timkiem()
    {
        base.Timkiem();
        Console.Write("Nhap AUTHOR ban muon tim: ");
        string t=Console.ReadLine();
        for (int i=0;i<n;i++)
        {
            if (t==author[i])
            {
                Console.WriteLine("TITLE: {0} - AUTHOR: {1} - YEAR: {2} - PUBLISHER: {3}",title[i],author[i],year[i],publisher[i]);
            }
        }
    }
}
class Article:Edition
{
    private string[] title;
    private string[] author;
    private double[] year;
    private string[] journal;
    private int n;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("SL BOOK: ");
        n=int.Parse(Console.ReadLine());
        title=new string[n];
        author=new string[n];
        year=new double[n];
        journal=new string[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("BOOK Thu {0}",(i+1));
            Console.Write("Title: ");
            title[i]=Console.ReadLine();
            Console.Write("Author: ");
            author[i]=Console.ReadLine();
            Console.Write("Journal: ");
            journal[i]=Console.ReadLine();
            Console.Write("Year: ");
            year[i]=double.Parse(Console.ReadLine());
        }
    }
    public override void Sapxep()
    {
        for (int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                foreach (int k in title[i])
                {
                    foreach (int l in title[j])
                    {
                        if (k>=l)
                        {
                            string tmp=title[i];
                            string a=author[i];
                            double b=year[i];
                            string c=journal[i];
                            title[i]=title[j];
                            author[i]=author[j];
                            year[i]=year[j];
                            journal[i]=journal[j];
                            title[j]=tmp;
                            author[j]=a;
                            year[j]=b;
                            journal[j]=c;
                        }
                    }
                }
            }
        }
    }
    public override void Xuat()
    {
        base.Xuat();
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("TITLE: {0} - AUTHOR: {1} JOURNAL: {2} - YEAR: {3} ",title[i],author[i],journal[i],year[i]);
        }
    }
    public override void Timkiem()
    {
        base.Timkiem();
        Console.Write("Nhap AUTHOR ban muon tim: ");
        string t=Console.ReadLine();
        for (int i=0;i<n;i++)
        {
            if (t==author[i])
            {
                Console.WriteLine("TITLE: {0} - AUTHOR: {1} JOURNAL: {2} - YEAR: {3} ",title[i],author[i],journal[i],year[i]);
            }
        }
    }
}
class OnlineResoure:Edition
{
    private string[] title;
    private string[] author;
    private string[] link;
    private string[] abstracts;
    private int n;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("SL BOOK: ");
        n=int.Parse(Console.ReadLine());
        title=new string[n];
        author=new string[n];
        link=new string[n];
        abstracts=new string[n];
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("BOOK Thu {0}",(i+1));
            Console.Write("Title: ");
            title[i]=Console.ReadLine();
            Console.Write("Author: ");
            author[i]=Console.ReadLine();
            Console.Write("Journal: ");
            link[i]=Console.ReadLine();
            Console.Write("Year: ");
            abstracts[i]=Console.ReadLine();
        }
    }
    public override void Sapxep()
    {
        for (int i=0;i<n;i++)
        {
            for (int j=i+1;j<n;j++)
            {
                foreach (int k in title[i])
                {
                    foreach (int l in title[j])
                    {
                        if (k>=l)
                        {
                            string tmp=title[i];
                            string a=author[i];
                            string b=link[i];
                            string c=abstracts[i];
                            title[i]=title[j];
                            author[i]=author[j];
                            link[i]=link[j];
                            abstracts[i]=abstracts[j];
                            title[j]=tmp;
                            author[j]=a;
                            link[j]=b;
                            abstracts[j]=c;
                        }
                    }
                }
            }
        }
    }
    public override void Xuat()
    {
        base.Xuat();
        for (int i=0;i<n;i++)
        {
            Console.WriteLine("TITLE: {0} - AUTHOR: {1} LINK: {2} - ABSTRACT: {3} ",title[i],author[i],link[i],abstracts[i]);
        }
    }
    public override void Timkiem()
    {
        base.Timkiem();
        Console.Write("Nhap AUTHOR ban muon tim: ");
        string t=Console.ReadLine();
        for (int i=0;i<n;i++)
        {
            if (t==author[i])
            {
                Console.WriteLine("TITLE: {0} - AUTHOR: {1} LINK: {2} - ABSTRACT: {3} ",title[i],author[i],link[i],abstracts[i]);
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Edition b = new Book();
        Edition a = new Article();
        Edition o = new OnlineResoure();
        while (true)
        {
            Console.WriteLine("MENU: ");
            Console.WriteLine("1. BOOK ");
            Console.WriteLine("2. ARTICLE ");
            Console.WriteLine("3. ONLINE RESOURE ");
            Console.WriteLine("0. THOAT ");
            Console.Write("Ban chon: ");
            string menu=Console.ReadLine();
            if(menu=="1")
            {
                b.Nhap();
                b.Sapxep();
                b.Xuat();
                b.Timkiem();
            }
            if(menu=="2")
            {
                a.Nhap();
                a.Sapxep();
                a.Xuat();
                a.Timkiem();
            }
            if(menu=="3")
            {
                o.Nhap();
                o.Sapxep();
                o.Xuat();
                o.Timkiem();
            }
            if (menu=="0")
            {
                Console.WriteLine("KET THUC");
                break;
            }
        }
    }
}

