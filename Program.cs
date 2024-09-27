using System.Text;

namespace btvn_oop_lap3_Human_Employee
{
    internal class Program
    {
        /*Hai lớp Human và Employee 
          Human có name:string và age:int
          Employee có Human:-Các thành viên của Human 
                            -coef:float
                            -num_of_child:int
          a)khai báo 2 lớp nói trên
          b)Tạo ra một mảng 5 Employee và in ra dữ liệu trong đó lương =coef x2.300.000, num_of_child x 300.000
         */



        public class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Human(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        public class Employee : Human
        {
            public float Coef { get; set; }
            public int Num_Of_Child { get; set; }

            public Employee(string name, int age, float coef, int num_Of_Child)
                : base(name, age)
            {
                Coef = coef;
                Num_Of_Child = num_Of_Child;
            }

            public float CalculateSalary()
            {
                return (Coef * 2300000) + (Num_Of_Child * 300000);
            }
            static void Main(string[] args)
            {

                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;

                Employee[] employees = new Employee[5];

                // Tạo dữ liệu cho 5 Employee
                employees[0] = new Employee("Trần Mỹ Hòa ", 18, 1.5f, 2);
                employees[1] = new Employee("Nguyen Anh ", 28, 1.7f, 1);
                employees[2] = new Employee("Tran Van Dat ", 35, 2.0f, 3);
                employees[3] = new Employee("Pham Thi Yen ", 32, 2.5f, 4);
                employees[4] = new Employee("Hoang Van THu", 26, 3.0f, 5);


                // In ra bảng dữ liệu
                Console.WriteLine("STT\tHọ tên\t\tTuổi\tLương");
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"{i + 1}\t{employees[i].Name}\t{employees[i].Age}\t{employees[i].CalculateSalary():0,0}");
                }
                Console.ReadKey();
            }
        }
    }
}

