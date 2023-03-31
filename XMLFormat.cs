using static System.Console; 
using System.IO; 
using System.Xml.Serialization; 
using System; 


namespace SAIS.CSharp.XMLFormat 
{ 
    public class StudentClass 
    { 
        // Declare properties for StudentClass 
        public int StudentId { get; set; } 
        public string StudentName { get; set; } 
        public string StudentCity { get; set; } 
        public string StudentDegree { get; set; } 
        public string StudentStream { get; set; } 

        //Initializing Student Details 

        public void AcceptDetails()   
        { 
            WriteLine("Enter StudentId : "); 
            StudentId = int.Parse(ReadLine()); 
            WriteLine("Enter Name : "); 
            StudentName = ReadLine(); 
            WriteLine("Enter City : "); 
            StudentCity = ReadLine(); 
            WriteLine("Enter Degree : "); 
            StudentDegree = ReadLine(); 
            WriteLine("Enter Stream : "); 
            StudentStream = ReadLine(); 
        } 

        //Method for creating a path for serialization 

        public void StudentSerialization(Type type, object obj, string path) 
        { 
            FileStream objFs = File.Create(path); 
            XmlSerializer objXmlSerializer = new XmlSerializer(type); 
            objXmlSerializer.Serialize(objFs, obj); 
        } 

        static void Main(string[] args) 
        { 
            StudentClass objSC = new StudentClass(); 

            //assigning the path for storing xml file 
            string path = @"C:\XMLFormat\Program4.xml"; 

            objSC.AcceptDetails(); 

            //call serialization method 
            objSC.StudentSerialization(typeof(StudentClass), objSC, path); 

            Console.WriteLine("Successfully Serialized !!"); 
        } 
    } 
}
