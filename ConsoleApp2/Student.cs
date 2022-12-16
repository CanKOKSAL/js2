namespace ConsoleApp2
{
    internal class Student : Person
    {
        public int Score;
        public bool IsGraduated;

        public Student(string name, string surname, int score)
        {
            Name = name;
            SurName = surname;
            Score = score;
        }

        public Student(string name, string surname, int score, bool isGraduated)
        {
            Name = name;
            SurName = surname;
            Score = score;
            IsGraduated = isGraduated;
        }

        public string GetFullName() {
            string fullName = $"{this.Name} {this.SurName}";
            
            return fullName;
        }
        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Surname: {this.SurName}");
            Console.WriteLine($"Score: {this.Score}");
            if(Score > 50 )
            {
                this.IsGraduated = true;
            }if (Score <= 79 && Score >= 51)
            {
                Console.WriteLine("You are eligible to Graduated");
            }if (Score <= 89 && Score >= 80)
            {
                Console.WriteLine("You are eligible to Graduated as a Honor student");
            }if (Score <= 100 && Score >= 90)
            {
                Console.WriteLine("You are eligible to Graduated as a High Honor student");
            }else
            {
                this.IsGraduated = false;   
            }
            if (this.IsGraduated)
            {
                Console.WriteLine($"Congrats!");
            } else 
            { 
                Console.WriteLine("You are failed!");
            }
        } 
        public void CanTakeExam()
        {
            if (this.Score <= 89 && this.Score >= 80)
            {
                Console.WriteLine("And also you can reexam for make your Score higher");
            }
        }
    }
}
