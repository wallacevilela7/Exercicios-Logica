namespace Exercicio028.Entities
{
    internal class Funcionario
    {
        public String Name { get; set; }
        public double Salary { get; set; }
        public double Tax { get; set; }

        public Funcionario(string name, double salary, double tax)
        {
            Name = name;
            Salary = salary;
            Tax = tax;
        }

        public double NetSalary()
        {
            return Salary - Tax;
        }
        public void RaiseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }
    }
}
