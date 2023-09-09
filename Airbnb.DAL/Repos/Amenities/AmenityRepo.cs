using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class AmenityRepo : GenericRepo<Amenity>, IAmenityRepo
{
    private readonly RentContext _rentContext;
    public AmenityRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }


    public IEnumerable<Amenity> GetAll()
    {
        return _rentContext.Set<Amenity>().ToList();

    }
    
    public Amenity? GetAmenityById(Guid Id)
    {
        return _rentContext.Set<Amenity>().Find(Id);
    }

    public int SaveChanges()
    {
        return _rentContext.SaveChanges();
    }
    public void Add(Amenity amenity)
    {
        _rentContext.Set<Amenity>().Add(amenity);
    }

    public void update (Amenity amenity)
    {

    }
    public void Delete(Amenity amenity)
    {
        _rentContext.Set<Amenity>().Remove(amenity);
    }

   

    

   //public Amenity? GetAmenityByIdForUpdateAndDelete(Guid Id, Guid PropertyId)
   // {
   //     return _rentContext.Set<Amenity>().Find( Id);
   // }
}
