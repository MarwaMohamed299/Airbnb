using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IPropertyRepo:IGenericRepo<Property>
{
    IEnumerable<Property> GetAllProperties();
    void Add(Property property);
    void Update(Property property);
    void Delete(Property property);
    int SaveChanges();
    Property? GetPropertyById(string id);
}
