using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_Code_First_Demo.Models;
namespace EF_Code_First_Demo.Controllers
{
    public class DepartmentsController : Controller
    {

        DepartmentContext context = new DepartmentContext();
        // GET: Departments
        public ActionResult Index()
        {           
            return View(context.Departments.ToList());
        }

        // GET: Departments/Details/5
        public ActionResult Details(int id)
        {
            var department = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(department);
        }

        // GET: Departments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departments/Create
        [HttpPost]
        public ActionResult Create(Department department)
        {
            try
            {
                //if(ModelState.IsValid)
                //{
                    context.Departments.Add(department);
                    context.SaveChanges();
              //  }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {

                return View();
            }
        }

        // GET: Departments/Edit/5
        public ActionResult Edit(int id)
        {
            Department department = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(department);
        }

        // POST: Departments/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                Department department1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                department1.DepartmentId = department.DepartmentId;
                department1.Name = department.Name;
                department1.Location = department.Location;
               // context.Entry(department).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Departments/Delete/5
        public ActionResult Delete(int id)
        {
            Department dept = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
            return View(dept);
        }

        // POST: Departments/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Department department)
        {
            try
            {
                Department department1 = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
                context.Departments.Remove(department1);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
