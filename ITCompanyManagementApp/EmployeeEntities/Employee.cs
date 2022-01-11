using ITCompanyManagementApp.CommonEntities;

namespace ITCompanyManagementApp.EmployeeEntities
{
    public abstract class Employee:Person //inheritance
    {
        public int TaxID { get; }

        public Employee(string firstName, string lastName, int taxId):base(firstName, lastName)
        {
            TaxID = taxId;
        }
    
        //by default, it compares object references, but this override now compares objects on the objects' TaxID.
        public override bool Equals(object obj)
        {
            return this.TaxID == (obj as Employee)?.TaxID;
        }
        public abstract string ProduceWorkResults();

        public override string ToString()
        {
            return base.ToString() + TaxID + ", ";
        }
    }
}

