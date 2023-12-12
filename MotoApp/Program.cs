using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;


var itemAdded = new Action<BusinessPartner>(EmployeeAdded);
var employeeRepository = new SqlRepository<BusinessPartner>(new MotoAppDbContext(), itemAdded);
employeeRepository.ItemAdded += EmployeRepositoryEmployeeAdded;

void EmployeRepositoryEmployeeAdded(object? sender, BusinessPartner e)
{
    Console.WriteLine($"Employee added => {e.FirstName} from {sender?.GetType().Name}");
}

AddEmployees(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<BusinessPartner> employeeRepository)
{
    var businessPartners = new[] {
        (new BusinessPartner("Piotr")),
        (new BusinessPartner("Adam")),
        (new BusinessPartner("Zuzia"))
};

    employeeRepository.AddBatch(businessPartners);



}
static void EmployeeAdded(BusinessPartner item)
{
    
    Console.WriteLine(item.FirstName+ " added");
}

//static void AddBatch<T>(IRepository<T> employeeRepository, T[] items) where T : class, IEntity
//{
//    foreach (var item in items)
//    {
//        employeeRepository.Add(item);

//    }
//    employeeRepository.Save();
//}

static void WriteAllToConsole(IRepository<BusinessPartner> employeeRepository)
{
    var items=employeeRepository.GetAll();
    foreach(var item in items)
    {
        Console.WriteLine(item);
    }
}






