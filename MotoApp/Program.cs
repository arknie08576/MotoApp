using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

//var employeeRepository = new GenericRepository<Employee>();
//employeeRepository.Add(new Employee("Adam"));
//employeeRepository.Add(new Employee("Zuzia"));
//employeeRepository.Add(new Employee("Piotr"));
//employeeRepository.Save();


var sqlRepository = new SqlRepository<Employee>(new MotoAppDbContext());
sqlRepository.Add(new Employee("Adam"));
sqlRepository.Add(new Employee("Zuzia"));
sqlRepository.Add(new Employee("Piotr"));
sqlRepository.Save();
Console.WriteLine(sqlRepository.GetById(1));




GetEmployeeById(sqlRepository);
static void GetEmployeeById(IRepository<IEntity> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee);


}


