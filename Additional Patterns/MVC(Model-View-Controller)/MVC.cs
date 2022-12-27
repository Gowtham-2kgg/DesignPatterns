using System;
using System.Collections.Generic;

namespace DesignPatterns.Additional_Patterns.MVC_Model_View_Controller_
{
    public class Mvc
    {
        public void MvcExample()
        {
            var employyees = new List<Employee>();
            IView view = new View();
            IEmployeeModel model = new EmployeeModel();
            IController controller = new Controller(view, model);
            for (int i = 0; i < 10; i++)
            {
                var employ = Console.ReadLine().Split(",");
                var emp = new Employee(int.Parse(employ[0]), employ[1], employ[2]);
                controller.AddEmployee(emp);
                employyees.Add(emp);
            }
            controller.ShowEmployees(employyees);
            controller.RemoveEmployee(employyees[0]);
        }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }

        public Employee(int empId, string empName, string designation)
        {
            EmpId = empId;
            EmpName = empName;
            Designation = designation;
        }
    }

    public interface IEmployeeModel
    {
        public void AddEmployee(Employee employee);
        public void RemoveEmployee(Employee employee);
    }

    public class EmployeeModel : IEmployeeModel
    {
        public static List<Employee> Employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
            {
                Employees.Add(employee);
            }
        }

        public void RemoveEmployee(Employee employee)
        {
            if (Employees.Contains(employee))
            {
                Employees.Remove(employee);
            }
        }
    }

    public interface IView
    {
        public void ShowEmployees(List<Employee> employees);
    }

    public class View : IView
    {
        public void ShowEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Designation}{emp.EmpId}{emp.EmpName}");
            }
        }
    }

    public interface IController
    {
        public void ShowEmployees(List<Employee> employees);
        public void AddEmployee(Employee employee);
        public void RemoveEmployee(Employee employee);
    }

    public class Controller : IController
    {
        private IView _view;
        private IEmployeeModel _model;

        public Controller(IView view, IEmployeeModel employeeModel)
        {
            this._view = view;
            this._model = employeeModel;
        }

        public void ShowEmployees(List<Employee> employees)
        {
            _view.ShowEmployees(employees);
        }

        public void AddEmployee(Employee employee)
        {
            _model.AddEmployee(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            _model.RemoveEmployee(employee);
        }
    }
}