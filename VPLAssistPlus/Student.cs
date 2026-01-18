namespace VPLAssistPlus
{
  
    public class Student // OOP main class [cite: 31]
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public double Grade { get; set; }

        
        public Student(int id, string name, string course, double grade)
        {
            ID = id;
            Name = name;
            Course = course;
            Grade = grade;
        }
    }
}