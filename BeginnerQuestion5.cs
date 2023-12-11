using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_System
{
    public class Employee
    {
        public Employee(string name, string email, int age, float salary, string phoneNumber, string address)
        {
            Name = name;
            Email = email;
            Age = age;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Address = address;
            List<object> list = new List<object> { Name, Email, Age, Salary, PhoneNumber, Address };
            Id++;
            myDict.Add(Id, list);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        Dictionary<int, List<object>> myDict = new Dictionary<int, List<object>>();


        public void Create(string name="",string email="",int age=0,float salary=0,string phoneNumber = "",string address = "")
        {
            Name = name;
            Email = email;
            Age = age;
            Salary = salary;
            PhoneNumber = phoneNumber;
            Address = address;
            Id++;
            List<object> list = new List<object> { Name,Email,Age,Salary,PhoneNumber,Address};
            myDict.Add(Id, list);
            Id++;
        }

        public void Update(int id=1,string attribute= "",string val = "")
        {
            if (attribute.ToLower() == "name")
            {
                //employee.Name = val;
                myDict[id][0] = val;
            }
            else if (attribute.ToLower() == "email")
            {
                //employee.Email=val;
                myDict[id][1] = val;
            }
            else if (attribute.ToLower() == "age")
            {
                //employee.Age = int.Parse(val);
                myDict[id][2] = int.Parse(val);

            }
            else if (attribute.ToLower() == "salary")
            {
                //employee.Salary = float.Parse(val);
                myDict[id][3] = float.Parse(val);
            }
            else if(attribute.ToLower() == "phonenumber")
            {
                //employee.PhoneNumber = val;
                myDict[id][4] = val;
            }
            else if (attribute.ToLower() == "address")
            {
                //employee.PhoneNumber=val;
                myDict[id][5] = val;
            }
        }

        public void Delete(int id)
        {
            myDict.Remove(id);
        }

        public void ShowAll()
        {
            List<string> data =new List<string> {"ID : ","Name : ","Email : ","Age : ","Salary : ","Phone Number : ","Address ; "};
            foreach (int key in myDict.Keys)
            {
                Console.WriteLine(data[0]+key);
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(data[i+1]+myDict[key][i] +" ");
                }
                Console.WriteLine("\n");
            }
        }
    }
    public class Book
    {
        public Book(string name = "", string author = "", int numpages = 0, string publishdate = "")
        {
            Name = name;
            Author = author;
            NumPages = numpages;
            PublishDate = publishdate;
            List<object> list = new List<object> { Name, Author, NumPages, PublishDate };
            Id++;
            myDict.Add(Id, list);
        }
        public int Id;
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumPages { get; set; }
        public string PublishDate { get; set; }

        Dictionary<int, List<object>> myDict = new Dictionary<int, List<object>>();


        public void Create(string name = "", string author="",int numpages=0,string publishdate="")
        {
            Name = name;
            Author = author;
            NumPages = numpages;
            PublishDate = publishdate;
            Id++;
            List<object> list = new List<object> { Name, Author,NumPages,PublishDate };
            myDict.Add(Id, list);
            Id++;
        }

        public void Update(int id = 1, string attribute = "", string val = "")
        {
            if (attribute.ToLower() == "name")
            {
                myDict[id][0] = val;
            }
            else if (attribute.ToLower() == "author")
            {
                myDict[id][1] = val;
            }
            else if (attribute.ToLower() == "numpages")
            {
                myDict[id][2] = int.Parse(val);

            }
            else if (attribute.ToLower() == "publishdate")
            {
                myDict[id][3] = val;
            }
            
        }

        public void Delete(int id)
        {
            myDict.Remove(id);
        }

        public void ShowAll()
        {
            List<string> data = new List<string> { "ID : ", "Name : ", "Author : ", "Number of pages : ", "Publish Date : "};
            foreach (int key in myDict.Keys)
            {
                Console.WriteLine(data[0] + key);
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(data[i + 1] + myDict[key][i] + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // The Task Link : https://docs.google.com/document/d/e/2PACX-1vR8amb6bEv7MD2tyDTjHdmWNhlL0HIB2aXSsEAR0GpLHLeb_Ti8a_h60Y00gBXwJdO93vI9svHNey4j/pub

            //Uncomment any region you want to test


            //Testing the Employee Class

            //Employee Security =new Employee("Ahmed","ahd2007@gmail.com",30,(float)1500.76,"01078827361","Banha");

            //Employee Librarian = new Employee("Ibrahim", "hima@gmail.com", 20, (float)2000.50, "01551711251", "Mansoura");

            ////Before Adding
            //Console.WriteLine("Before Adding");
            //Librarian.ShowAll();

            //Librarian.Create("Yousief", "jo@gmail.com", 20, (float)5000.50, "", "Mansoura");
            ////After adding
            //Console.WriteLine("After Adding");
            //Librarian.ShowAll();

            ////Before Updating
            //Console.WriteLine("Before Updating");
            //Librarian.ShowAll();

            ////After Updating 
            //Console.WriteLine("After Updating");
            //Librarian.Update(1, "NaMe", "Hegazi");
            //Librarian.ShowAll();

            ////Before Deleting
            //Console.WriteLine("After Deleting");
            //Librarian.Delete(1);
            //Librarian.ShowAll();



            //Testing the Book Class



            Book selfimprovementBooks = new Book("Rich Dad Poor Dad", "Robert Kiyosaki", 195, "1/1/1997");
            Console.WriteLine("Before Adding\n");
            selfimprovementBooks.ShowAll();

            selfimprovementBooks.Create("Poor Dad Rich Dad", "3mo Hima", 300, "11/12/2023");
            Console.WriteLine("After Adding\n");
            selfimprovementBooks.ShowAll();

            Console.WriteLine("After Updating\n");
            selfimprovementBooks.Update(2, "publishdate", "8/4/2015");
            selfimprovementBooks.ShowAll();

            Console.WriteLine("After Deleting\n");
            selfimprovementBooks.Delete(1);
            selfimprovementBooks.ShowAll();
            Console.ReadLine();
        }
    }
}
