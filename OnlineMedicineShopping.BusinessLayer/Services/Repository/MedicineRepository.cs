using Microsoft.EntityFrameworkCore;
using OnlineMedicineShopping.DataLayer;
using OnlineMedicineShopping.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMedicineShopping.BusinessLayer.Services.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        /// <summary>
        /// Creating Referance variable of MedicineDbContext and injecting in MedicineRepository Constructor
        /// </summary>
        private readonly MedicineDbContext _mediContext;
        public MedicineRepository(MedicineDbContext medicineDbContext)
        {
            _mediContext = medicineDbContext;
        }

        /// <summary>
        /// Get List of Medicine Category from InMemeoryDb
        /// </summary>
        /// <returns></returns>
        public IList<Category> CatList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Book a doctor appointment and save data in appointment Table
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns></returns>
        public async Task<Appointment> DoctorAppointment(Appointment appointment)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all doctor list from InMemoryDb and show doctor list
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Doctor>> GetAllDoctor()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all medicine and show on web home page for shoppers, and show medicine with medicine category id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Medicine>> GetAllMedicine(int? id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get medicine by Medicine Id from InMemoryDb
        /// </summary>
        /// <param name="medicineId"></param>
        /// <returns></returns>
        public async Task<Medicine> GetMedicineById(int medicineId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get order infromation of medicine order
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<MedicineOrder>> OrderByuserId(int UserId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Place medicine order and save user address as well
        /// </summary>
        /// <param name="medicineId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> PlaceOrder(int medicineId, ApplicationUser user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get medicine by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Medicine>> MedicineByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get list of doctor and show on dropdownlist while appointment booking with doctor 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Doctor> Doctor()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get appointment details for user
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <returns></returns>
        public async Task<Appointment> GetAppointmentById(int appointmentId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
