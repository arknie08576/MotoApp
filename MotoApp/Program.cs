using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee("Adam"));
employeeRepository.Add(new Employee("Zuzia"));
employeeRepository.Add(new Employee("Piotr"));
employeeRepository.Save();