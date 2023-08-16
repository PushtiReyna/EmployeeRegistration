using EmployeeRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeRegistration.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDetailContext _db;

        public EmployeeController(EmployeeDetailContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var employeeList = _db.Employees.ToList();
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employeeCreate = new Employee()
                    {
                        FirstName = obj.FirstName,
                        MiddleName = obj.MiddleName,
                        LastName = obj.LastName,
                        Address = obj.Address,
                        Email = obj.Email,
                        Dob = obj.Dob,
                        Mobile1 = obj.Mobile1,
                        Mobile2 = obj.Mobile2,
                        PinCode = obj.PinCode,
                        Gender = obj.Gender,

                    };
                    _db.Employees.Add(employeeCreate);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                var employeeEdit = _db.Employees.FirstOrDefault(x => x.EmployeeId == id);
                if (employeeEdit != null)
                {
                    #region
                    //var employeeGet = new Employee()
                    //{
                    //    EmployeeId = employeeEdit.EmployeeId,
                    //    FirstName = employeeEdit.FirstName,
                    //    MiddleName = employeeEdit.MiddleName,
                    //    LastName = employeeEdit.LastName,
                    //    Address = employeeEdit.Address,
                    //    Email = employeeEdit.Email,
                    //    Dob = employeeEdit.Dob,
                    //    Mobile1 = employeeEdit.Mobile1,
                    //    Mobile2 = employeeEdit.Mobile2,
                    //    PinCode = employeeEdit.PinCode,
                    //    Gender = employeeEdit.Gender,
                    //};
                    //return View(employeeEdit);
                    #endregion

                    return View(employeeEdit);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(Employee obj)
        {
            #region
            //var EmployeeUpdate = new Employee()
            //{
            //    EmployeeId = model.EmployeeId,
            //    FirstName = model.FirstName,
            //    MiddleName = model.MiddleName,
            //    LastName = model.LastName,
            //    Address = model.Address,
            //    Email = model.Email,
            //    Dob = model.Dob,
            //    Mobile1 = model.Mobile1,
            //    Mobile2 = model.Mobile2,
            //    PinCode = model.PinCode,
            //    Gender = model.Gender,
            //};
            //_db.Employees.Update(obj);
            //_db.SaveChanges();
            #endregion

            var employeePostEdit = _db.Employees.FirstOrDefault(x => x.EmployeeId == obj.EmployeeId);

            if (employeePostEdit != null)
            {
                employeePostEdit.FirstName = obj.FirstName;
                employeePostEdit.MiddleName = obj.MiddleName;
                employeePostEdit.LastName = obj.LastName;
                employeePostEdit.Address = obj.Address;
                employeePostEdit.Email = obj.Email;
                employeePostEdit.Dob = obj.Dob;
                employeePostEdit.Mobile1 = obj.Mobile1;
                employeePostEdit.Mobile2 = obj.Mobile2;
                employeePostEdit.PinCode = obj.PinCode;
                employeePostEdit.Gender = obj.Gender;

                _db.Entry(employeePostEdit).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

            #region
            //var employeeUpdate = _db.Employees .FirstOrDefault(s => s.EmployeeId == obj.EmployeeId);
            //if (employeeUpdate != null)
            //{

            //    employeeUpdate.FirstName = obj.FirstName;
            //    employeeUpdate.MiddleName = obj.MiddleName;
            //    employeeUpdate.LastName = obj.LastName;
            //    employeeUpdate.Address = obj.Address;
            //    employeeUpdate.Email = obj.Email;
            //    employeeUpdate.Dob = obj.Dob;
            //    employeeUpdate.Mobile1 = obj.Mobile1;
            //    employeeUpdate.Mobile2 = obj.Mobile2;
            //    employeeUpdate.PinCode = obj.PinCode;
            //    employeeUpdate.Gender = obj.Gender;


            //    var isfirstNmaeModified = _db.Entry(employeeUpdate).Property("FirstName").IsModified;
            //    var isMiddleNameModified = _db.Entry(employeeUpdate).Property("MiddleName").IsModified;
            //    var isLastNameeModified = _db.Entry(employeeUpdate).Property("LastName").IsModified;
            //    var isAddressodified = _db.Entry(employeeUpdate).Property("Address").IsModified;
            //    var isEmailModified = _db.Entry(employeeUpdate).Property("Email").IsModified;
            //    var isDobModified = _db.Entry(employeeUpdate).Property("Dob").IsModified;
            //    var isMobile1Modified = _db.Entry(employeeUpdate).Property("Mobile1").IsModified;
            //    var isMobile2Modified = _db.Entry(employeeUpdate).Property("Mobile2").IsModified;
            //    var isPinCodeModified = _db.Entry(employeeUpdate).Property("PinCode").IsModified;
            //    var isGender1Modified = _db.Entry(employeeUpdate).Property("Gender").IsModified;


            //    _db.SaveChanges();

            //    return RedirectToAction("Index");
            //}

            //return View();
            #endregion
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var employeeGetDelete = _db.Employees.FirstOrDefault(x => x.EmployeeId == id);
                if (employeeGetDelete != null)
                {
                    #region
                    //var employeeGet = new Employee()
                    //{
                    //    EmployeeId = employeeDelete.EmployeeId,
                    //    FirstName = employeeDelete.FirstName,
                    //    MiddleName = employeeDelete.MiddleName,
                    //    LastName = employeeDelete.LastName,
                    //    Address = employeeDelete.Address,
                    //    Email = employeeDelete.Email,
                    //    Dob = employeeDelete.Dob,
                    //    Mobile1 = employeeDelete.Mobile1,
                    //    Mobile2 = employeeDelete.Mobile2,
                    //    PinCode = employeeDelete.PinCode,
                    //    Gender = employeeDelete.Gender,
                    //};
                    //return View(employeeGet);
                    #endregion

                    return View(employeeGetDelete);
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult Delete(Employee obj)
        {
            try
            {
                var employeePostDelete = _db.Employees.FirstOrDefault(x => x.EmployeeId == obj.EmployeeId);
                if (employeePostDelete != null)
                {
                    _db.Employees.Remove(employeePostDelete);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}
