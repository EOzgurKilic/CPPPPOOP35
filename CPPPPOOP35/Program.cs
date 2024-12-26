using System.ComponentModel.Design.Serialization;

namespace CPPPPOOP35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A Tiny Revision Of This Keyword
            /*ExpClass obj1 = new ExpClass();
             ExpClass obj2 = new ExpClass(10);
             ExpClass obj3 = new ExpClass(15,15);
             ExpClass obj4 = new ExpClass("ashdbak");*/
            #endregion
            
            
            #region Equals Method Overriding In Classes 
            /*EqualCheckerClass obj1 = new EqualCheckerClass() {name ="E", surName = "K" };
            EqualCheckerClass obj2 = new EqualCheckerClass() { name = "E", surName = "K" };
            EqualCheckerClass obj3 = null;
            Console.WriteLine(obj1.Equals(obj2));
            Console.WriteLine(obj1.Equals(obj3));*/
            #endregion


            #region Structs
            ExpStruct struct1= new ExpStruct() {No1 = 20, No2 = 40, PropNo1 = 60, PropNo2 = 80 };
            ExpStruct struct2;
            struct2.No1 = 50;
            struct2.No2 = 40;
            Console.WriteLine(struct1.No1);
            Console.WriteLine(struct2.No1);
            Console.WriteLine(struct1.No2);
            Console.WriteLine(struct2.No2);
            Console.WriteLine(struct1.PropNo1);
            //Console.WriteLine(struct2.PropNo1); //Would throw an error.
            Console.WriteLine(struct1.PropNo2);
            //Console.WriteLine(struct2.PropNo2); //Would throw an error.
            Console.WriteLine(struct1.IntMethodInstance());
            //Console.WriteLine(struct2.IntMethodInstance()); //Would throw an error.
            #endregion
        }
    }

    class ExpClass 
    {
        public ExpClass() : this(20)
        { Console.WriteLine("Constructor 1 triggered"); }
        public ExpClass(int a) : this(20,10)
        { Console.WriteLine("Constructor 2 triggered"); }
        public ExpClass(int a, int b): this("sd")
        { Console.WriteLine("Constructor 3 triggered"); }
        public ExpClass(string c)
        { Console.WriteLine("Constructor 4 triggered"); }
        
    } //This Keyword Revision

    class EqualCheckerClass 
    {
        public string name { get; set; }
        public string surName { get; set; }

        public bool Equals(EqualCheckerClass obj)
        {
            return this.name == obj?.name && obj?.surName == this.surName;
        }

    }

    struct ExpStruct {
        //without using new keyword instantiating the struct, we can use the fields and this is a difference between classes, records and structs.
        public int No1;
        public int No2;
        
        //But we can't use properties and methods because props get available as they get default values of their types when new keyword is used.
        public int PropNo1 { get; set; } 
        public int PropNo2 { get; set; }
        public int IntMethodInstance() {
            return No1 +No2 + PropNo1 +PropNo2;
        }

        //The following is not applicable to the classes since this keyword acts as read-only in them.
        public void ResetObj() 
        {
            this = new ExpStruct();
        }
    }

    
    //Just wanted to revise down below how to create a class with one single instance through static constructor
    class TrialClass
    {
        public TrialClass OnlyInstance {get;}

        static TrialClass()
        {
            TrialClass trial = new TrialClass();
        }
    }

}
