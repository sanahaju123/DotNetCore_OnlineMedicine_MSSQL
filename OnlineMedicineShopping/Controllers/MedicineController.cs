using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineShopping.BusinessLayer.Interfaces;
using OnlineMedicineShopping.BusinessLayer.ViewModels;
using OnlineMedicineShopping.Entities;

namespace OnlineMedicineShopping.Controllers
{
    public class MedicineController : Controller
    {
        /// <summary>
        /// Creating Referance variable of IMedicineServices and injecting in MedicineController constructor
        /// </summary>
        private readonly IMedicineServices _medicineServices;
        public MedicineController(IMedicineServices medicineServices)
        {
            _medicineServices = medicineServices;
        }
        
        /// <summary>
        /// Get Medicine Details 
        /// </summary>
        /// <param name="MedicineId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get-medicine-details")]
        public async Task<IActionResult> Details(int MedicineId)
        {
            //Do code here
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Place order by medicine id
        /// </summary>
        /// <param name="MedicineId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("place-order")]
        public async Task<IActionResult> Placeorder(int MedicineId, ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Used for show order info
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-order-info")]
        public async Task<IActionResult> OrderInfo(int userId)
        {
            var order = await _medicineServices.OrderByuserId(userId);
            return View(order);
        }
        

        /// <summary>
        /// Book a doctor appointment
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("book-appointment")]
        public async Task<IActionResult> DoctorAppointment(AppointmentViewModel appointment)
        {
            //Do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show appointment details after appointment booking is complete
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("appointment-details-by-id")]
        public async Task<IActionResult> AppointmentInfo(int appointmentId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
