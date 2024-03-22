namespace student_classes;

using System;
using System.Collections.Generic;

public class CURD_Class
{
    private List<craeteStudent> slist = new List<craeteStudent>();

    private void add()
    {

        craeteStudent st = new craeteStudent();


        Console.WriteLine("enter the student details");
        Console.WriteLine("enter the student id");
        st.id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the student name");
        st.name = Console.ReadLine();
        Console.WriteLine("enter the phone");
        st.phone = long.Parse(Console.ReadLine());
        Console.WriteLine("enter the student address");
        st.address = Console.ReadLine();

        slist.Add(st);

    }

    private void display()
    {
        Console.WriteLine("students are as follows");
        foreach (var ele in slist)
        {
            Console.WriteLine(ele.id + " " + ele.name + " " + ele.address + " " + ele.phone);

        }
    }

    private void edit(string givenname)
    {
        craeteStudent persontoedit =
            slist.Find(student => student.name.Equals(givenname, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("enter the new details");
        Console.WriteLine("enter the student id");
        persontoedit.id = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the student name");
        persontoedit.name = Console.ReadLine();
        Console.WriteLine("enter the phone");
        persontoedit.phone = long.Parse(Console.ReadLine());
        Console.WriteLine("enter the student address");
        persontoedit.address = Console.ReadLine();


    }

    private void deletePerson(string givenName)
    {
        craeteStudent persontoDelete =
            slist.Find(student => student.name.Equals(givenName, StringComparison.OrdinalIgnoreCase));

        slist.Remove(persontoDelete);

    }

    static void Main(string[] args)
    {
        CURD_Class cls = new CURD_Class();
        // cls.add();
        // cls.add();
        // cls.display();
        // Console.WriteLine("enter the name of the studnet to edit");
        // string sname = Console.ReadLine();
        // cls.edit(sname);
        // cls.display();
        // Console.WriteLine("enter the name of the studnet to delete");
        // string dname = Console.ReadLine();
        // cls.deletePerson(dname);
        // cls.display();
        
        while (true)
        {
            Console.Write("1.add student\n 2.display student\n 3.update student\n 4.delete student\n enter your choice:\n" );
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:cls.add();
                    break;
                case 2:  cls.display();
                    break;
                case 3: 
                    Console.WriteLine("enter the name of the studnet to edit");
                    string sname = Console.ReadLine();
                    cls.edit(sname);
                    break;
                case 4: Console.WriteLine("enter the name of the studnet to delete");
                    string dname = Console.ReadLine();
                    cls.deletePerson(dname);
                    break;
                default:Console.WriteLine("enter valid choice");
                    break;
                
            }
        }



    }
}

