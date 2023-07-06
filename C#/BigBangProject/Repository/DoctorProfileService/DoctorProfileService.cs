using BigBangProject.Data;
using BigBangProject.Models;
using Microsoft.EntityFrameworkCore;
namespace BigBangProject.Repository.DoctorProfileService
{
    public class DoctorProfileService: IDoctorProfileService    
    {
        private readonly HospitalContext _context;
        public DoctorProfileService(HospitalContext context)
        {
            _context = context;
        }
        //displaying the doctor profile to the admin inorder to allow
        public async Task<List<DoctorProfile>> doctorProfile()
        {
            var get=await _context.DoctorProfiles.ToListAsync();
            if (get == null)
            {
                throw new ArgumentNullException("Not available");
            }
            return get;
        }
        //Adding the doctor detail to the profile
        public async Task<DoctorProfile> AddDoctorProfile(DoctorProfile doctor)
        {
            await _context.DoctorProfiles.AddAsync(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }
       //Deleting the request by admin
        public async Task<DoctorProfile> DeleteDoctorProfile(string id)
        {
            var delete = await _context.DoctorProfiles.FindAsync(id);
            if (delete == null)
            {
                throw new ArgumentNullException("Not available");
            }
            _context.DoctorProfiles.Remove(delete);
            await _context.SaveChangesAsync();
            return delete;
        }
    }
}
