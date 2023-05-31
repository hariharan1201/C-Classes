using Classes;
using System.ComponentModel;

public class Profile
    {   
    public static void Main(string[] args)
    {
        
        encap Encap = new encap();
        
        Overrideabsrtct OA = new Overrideabsrtct();

        OffProfile offProfile = new OffProfile();

        mail mail = new mail();

        SchoolJr schoolJr   = new SchoolJr();
        SchoolSr schoolSr   = new SchoolSr();   
        Education education = new Education();  

        Console.WriteLine("Worker profile\n--------------");
        Console.WriteLine("Name:"+offProfile.name);
        Console.Write("Postion:");
        OA.position();
        Console.WriteLine("Employee ID:"+offProfile.Emp_ID);
        Console.WriteLine("Mail:"+mail.mailID);
        Console.WriteLine("Phone No:"+Encap.Phno);

        Console.WriteLine("\nPersonal Profile\n----------------");
        Console.WriteLine("Name:"+Encap.name);
        Console.Write("Position:");
        OA.CurrentPosition();
        Console.WriteLine("Mail Id:"+Encap.mail);
        Console.Write("College:");
        education.institution();
        Console.Write("Jr.School:");
        schoolJr.institution();
        Console.Write("Sr.School:");
        schoolSr.institution();
        


    }
    
}

