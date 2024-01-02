using System.Threading.Channels;

namespace CSharp_OOP
{
    internal class Program
    {
        //Create a class 
        /*Acecss modifier+ Class + Name {
         *attribute;
         *attribute;
         *attribute;
         *
         *Method(){}
         *
         *costructor(parameters)
         *
         * }*/
        public class Students
        {
            private int id;
            private int number;
            private string name;
            private string classnum;

            /* public void Setid(int id)
             {
                 this.id = ;
             }
             public void Setnum(int number) 
             { 
             this.number = number;
             }*/
            //propirty
           /* public int Id
            {
                set { this.id = value; }
                get { return this.id; }
            }
            public int Number
            {
                set { this.number = value; }
                get { return this.number; }
            }
            public string Name
            {
                set { this.name = value; }
                get { return this.name; }
            }
            public string Classnum
            {
                set { this.classnum = value; }
                get { return this.classnum; }
            }*/
                
            //create a consturctor which take a parmeters and make overloading
            public Students(int i ,int n ,string N , string c)
            {
                id = i;
                number = n;
                name = N;
                classnum = c;

            }  //frist
            public Students(int i, int n, string N)
            {
                id = i;
                number = n;
                name = N;
               

            } //dif sign
            public Students(int i, int n)
            {
                id = i;
                number = n;
              

            }
            public Students(int i)
            {
                id = i;
             

            }
            public Students()
            {
           

            }

            public void Display()
            {
                Console.WriteLine(id);
                Console.WriteLine(number);
                Console.WriteLine(name);
                Console.WriteLine(classnum);
            }
        }
        /*Access modifiers
         public  --> all in code can access 
         Private --> all methods in class can modifity if */


        static void Main(string[] args)
        {
            int x =int.Parse(Console.ReadLine());
            Students s1 = new Students(x);
      

            s1.Display();
        }
    }
}
