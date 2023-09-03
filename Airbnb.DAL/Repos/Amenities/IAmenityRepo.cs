using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IAmenityRepo:IGenericRepo<Amenity>
{
    IEnumerable<Amenity> GetAll();
    Amenity? GetAmenityById(Guid Id);
    void Add(Amenity amenity);
    void Update(Amenity amenity);
    void Delete(Amenity amenity);
    int SaveChanges();



}
