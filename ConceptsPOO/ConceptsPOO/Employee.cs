

namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDade { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal getValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} - {LastName}, Birth: {BirthDade}, Hiring: {HiringDate}, Is active: {IsActive} ";
        }
    }
}
