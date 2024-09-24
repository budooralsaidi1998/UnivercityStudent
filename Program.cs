namespace UnivercityStudent
{
    internal class Program
    {
      static  Dictionary <string, HashSet<string>> SystemEnrolle = new Dictionary <string, HashSet<string>>();
        //static Dictionary<string, int> IsFull= new Dictionary<string, int>();
        static void Main(string[] args)
        {

            // Console.WriteLine("\n\n\t\t\t\t\t************ Courses Enrolle *********");

            //Console.WriteLine("\n\t\t 1. Admin ?");
            //Console.WriteLine("\n\t\t 2. Student ? ");
            //int choise = 0;


            //try
            //{
            //    choise = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //switch (choise)
            //{
            //    case 1:
            //        Admin();
            //        break;

            //    case 2:

            //        break;

            //    default:
            //        break;
            bool flage = false;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\t\t\t **** option page ***");
                Console.WriteLine("\n\t\t 1. Adding new course ");
                Console.WriteLine("\n\t\t 2. Display course ");
                Console.WriteLine("\n\t\t 3. Remove the course ");
                Console.WriteLine("\n\t\t 4. display student with course ");
                Console.WriteLine("\n\t\t 5. enrolle student ");
                Console.WriteLine("\n\t\t 6. remove student ");
                Console.WriteLine("\n\t\t 7. display common student");
                Console.WriteLine("\n\t\t 8. withdrow the student ");

                int choise = 0;
                try
                {
                    choise = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choise)
                {
                    case 1:
                        AddCourse();
                        break;

                    case 2:
                        DisplayCourse();
                        break;

                    case 3:
                        removecourse();
                        break;

                    case 4:
                        displayStudentwithcourse();
                        break;

                    case 5:
                        enrollstudent();
                        break;

                    case 6:
                        removestudent();
                        break;
                    case 7:
                        CommonStudent();
                        break;
                    case 8:
                        withdrowstudent();
                        break;
                    default:
                        Console.WriteLine("");
                        break;

                }
            }while (flage!=true);

        }

        static void Admin()
        {

            //add new course,remove course,
            //display all student
            //,search course in comman student ,
            //withdrow the student from all courses
            //request drop++
            //login++
            //file++
            


        }

        static void AddCourse()
        {
            Console.Clear();
            int countCourse = 0;

            Console.WriteLine(" enter the ID of course :");
            string idcourse  = Console.ReadLine();
         
            if(!SystemEnrolle.ContainsKey(idcourse))
            {
                //countCourse = countCourse + 1;
                SystemEnrolle.Add(idcourse, new HashSet<string>());
              //  Console.WriteLine($"{idcourse} is have : {countCourse}");
                Console.WriteLine($" the id course {idcourse} is Add Successfuly ");
            }
            else
            {
                Console.WriteLine($" is aready have {idcourse}"); 
            }

            Console.WriteLine("Enter key");
            Console.ReadKey();



        }
        static void DisplayCourse()
        {
            Console.Clear();
            foreach (KeyValuePair<string,HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("the ID : {0}",p.Key);
            }
            Console.WriteLine("Enter key");
            Console.ReadKey();
        }
        static void removecourse()
        {
            Console.Clear();
            Console.WriteLine(" enter the ID of course :");
            string idcourse = Console.ReadLine();
            if(SystemEnrolle.ContainsKey(idcourse))
            {
                SystemEnrolle.Remove(idcourse);
            }
            Console.WriteLine("Enter key");
            Console.ReadKey();
        }
        static void displayStudentwithcourse()
        {
            Console.Clear();
            foreach (KeyValuePair<string, HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("ID COURSE :{0}", p.Key);
                foreach (string student in p.Value)
                {
                    Console.WriteLine("student name :{0}", student);
                }
            }
            Console.WriteLine("Enter key");
            Console.ReadKey();
        }
        static void enrollstudent()
        {
            Console.Clear();
            DisplayCourse();
          
            Console.WriteLine(" enter the ID of course :");
            string idcourse = Console.ReadLine();

            Console.WriteLine("enter name of student :");
            string studentname = Console.ReadLine();

            SystemEnrolle[idcourse].Add( studentname);

            //foreach(KeyValuePair<string,HashSet<string>> p in SystemEnrolle)
            //{
            //    Console.Write("{0}", p.Key);
            //    foreach(string  student in p.Value)
            //    {
            //        Console.WriteLine("{0}", student);
            //    }
            //}
            Console.WriteLine("Enter key");
            Console.ReadKey();

        }
        static void removestudent()
        {
            Console.Clear();
            foreach (KeyValuePair<string, HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("{0}", p.Key);
                foreach (string students in p.Value)
                {
                    Console.WriteLine(":{0}", students);
                }
            }

            Console.WriteLine(" ENTER THER ID OF COURSE :");
            string idc = Console.ReadLine();
            Console.WriteLine(" ENTER THER NAME OF STUDENT :");
            string student = Console.ReadLine();
            foreach (string courseid in SystemEnrolle[idc])
            { 
            if (courseid.Contains(idc))
            {
                if (.ContainsValue(student))
                {
                    SystemEnrolle.Remove(student);
                    Console.WriteLine("remove student");
                }

            }
        }
            Console.WriteLine("Enter key");
            Console.ReadKey();
        }

        static void CommonStudent()
        {
            Console.Clear();
            foreach (KeyValuePair<string, HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("the ID : {0}", p.Key);
            }
            Console.WriteLine("the ID 1 ");
            string id1= Console.ReadLine();
            Console.WriteLine("the ID 2 ");
            string id2= Console.ReadLine();

            if (SystemEnrolle.ContainsKey(id1))
            {
               if (SystemEnrolle.ContainsKey(id2))
                {
                    HashSet<string>course1=new HashSet<string>();
                    HashSet<string> course2 = new HashSet<string>();

                    course1=SystemEnrolle[id1];
                    course2=SystemEnrolle[id2];
                   
                      course1.IntersectWith(course2);

                    foreach(string course in course1 )
                    {
                        Console.WriteLine(course);
                    }

                   

                }
                else
                {
                    Console.WriteLine("not found id 1");
                }
            }
            else
            {
                Console.WriteLine("not found id 2");
            }
            Console.WriteLine("Enter key");
            Console.ReadKey();
        } 
        static void withdrowstudent()

        {
            Console.Clear();
            foreach (KeyValuePair<string, HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("ID COURSE :{0}", p.Key);
                foreach (string student in p.Value)
                {
                    Console.WriteLine("student name :{0}", student);
                }
            }

            Console.WriteLine("enter the name of student :");
            string namestudent= Console.ReadLine();

            foreach(KeyValuePair<string,HashSet<string>> Student in SystemEnrolle)
            {
                if (Student.Value.Contains(namestudent))
                {
                   Student.Value.Remove(namestudent);
                }
            }

            foreach (KeyValuePair<string, HashSet<string>> p in SystemEnrolle)
            {
                Console.WriteLine("ID COURSE :{0}", p.Key);
                foreach (string student in p.Value)
                {
                    Console.WriteLine("student name :{0}", student);
                }
            }

            Console.WriteLine("Enter key");
            Console.ReadKey();
        }

    }
}