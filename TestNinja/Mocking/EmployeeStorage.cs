namespace TestNinja.Mocking
{
    public interface IEmployeeStorage
    {
        void DeleteEmployee(int id);
    }

    public class EmployeeStorage : IEmployeeStorage
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeStorage(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public void DeleteEmployee(int id)
        {
            var employee = _employeeContext.Employees.Find(id);
            if (employee == null) return;
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }

    }
}
