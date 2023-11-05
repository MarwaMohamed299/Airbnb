
using Airbnb.BL.Dtos.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.properties
{
    public interface IPropertyManager
    {
        IEnumerable<PropertyReadDto> GetAllProperties();
        PropertyReadDto? GetPropertyById(string id);
        string Add(ResevationAddDto property);
        bool Update(PropertyUpdateDto property);
        bool Delete(string id);

        
    }
}
