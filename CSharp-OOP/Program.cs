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
            public int id;
            public int number;
            public string name;
            public string classnum;

            public void Display()
            {
                Console.WriteLine(id);
                Console.WriteLine(number);
                Console.WriteLine(name);
                Console.WriteLine(classnum);
            }
        }
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.number = 1;  
            s1.name = "test";
            s1.id = 1;
            s1.classnum = "test";

            s1.Display();
        }
    }
}
