namespace ConceptsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal getValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\tValue to pay.........: {$"{getValueToPay():C2}", 18}";
        }
    }
}
