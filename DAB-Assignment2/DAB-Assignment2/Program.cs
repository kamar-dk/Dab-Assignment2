// See https://aka.ms/new-console-template for more information
using DAB_Assignment2;
using Microsoft.EntityFrameworkCore;
using System.Data;

using var db = new FacilitysContext();

Console.WriteLine($"Database Path: {db.DbPath}");

// create
/*using (var db = new FacilitysContext())
{
    var facility = new Facilitys()
    {
        PK_FcName = "Uniparken",
        ClosetAdress = "something 1",
        FcType = "Park",
        CanBeBookedBy = "alle",
        FacilityDecrtiption = "bla bla"
    };
    db.Facilitys.Add(facility);
    db.SaveChanges();
}
*/

Main();

static void Main()
{
    bool running = true;
    Console.WriteLine("Q1 = '1'" +
            "to stop press 's'");
    do
    {
        

        var choise = Console.Read();
        switch (choise)
        {
            case 'Q':
                Q1();
                break;
            case 'C':
                Q2();
                break;

            default:
                break;
        }
    } while (running == true);
}



static void Q1()
{
    using var db = new FacilitysContext();

    var faciltyQuary =
                    from Facilitys in db.Facilitys
                    select Facilitys.PK_FcName;

    foreach (var Name in faciltyQuary)
    {
        Console.WriteLine(Name);
    }
}

static void Q2()
{
    using var db = new FacilitysContext();

    using var context = new FacilitysContext();


    var facs = context.Facilitys
        .FromSqlRaw($"Select PK_FcName, ClosetAdress, FcType FROM dbo.Facilitys")

    
    /*
    var quary = 
        from Facilitys in db.Facilitys
        select Facilitys.PK_FcName;

    from Facilitys in db.Facilitys
    orderby Facilitys.FcType descending
    select Facilitys.PK_FcName;
    
    var fcs = db.Facilitys.GroupBy(db => db.FcType);

    foreach (var group in fcs)
    {
        foreach(var f in group)
        {

            Console.WriteLine("Name {1}, adress {2} type = {3}", f.PK_FcName, f.ClosetAdress, f.FcType);
        }
    }
    */
    
    
}

static void Q3()
{
    using var db = new FacilitysContext();

    var BookingsQuary =
        from Bookings in db.Bookings
        select Bookings.User;



    foreach (var obj in BookingsQuary)
    {
        Console.WriteLine(obj);
    }
}










