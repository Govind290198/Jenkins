using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExampleProject
{
    class Student
    {
        string[] skills;
        string name, phone;
        int id;

        //indexer - allow object of class to be treated as array
        void SomeMethod(int id)
        {
            //local variable take priority
            if(this.id==id)
            {
                Console.WriteLine("Same Person");
            }
        }
        public string this[int index]
        {

        }
        //public string[] Skills { get => skills; set => skills = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }

        public void GetStudentDetails()
        {
            Console.WriteLine("Enter id");
            while(!Int32.TryParse(Console.ReadLine(),out id))
            {
                Console.WriteLine("Invalid");
            }
        }


    }

        
}
