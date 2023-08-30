using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IPropertyRepo:IGenericRepo<Property>
{
    IEnumerable<Property> GetAll();
    Property? GetById(int id);
    void Add(Property property);
    void Update(Property property);
    void Delete(Property property);
    int SaveChanges();
    Property? GetById(Guid id);
}
