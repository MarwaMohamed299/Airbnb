using Airbnb.BL.Dtos.Properties;
using Airbnb.DAL;
using Property = Airbnb.DAL.Property;

namespace Airbnb.BL.Managers.properties
{
    
    public class PropertyManager : IPropertyManager
    {
        private IPropertyRepo _propertyRepo;

        public PropertyManager (IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }
        public IEnumerable<PropertyReadDto> GetAll()
        {
            IEnumerable<Property> propertyFromDb = _propertyRepo.GetAll();
            return propertyFromDb.Select(p => new PropertyReadDto
            {

                Id = p.Id,
                CreationDate = p.CreationDate,
                PropType = p.PropType,
                UserID=p.UserID,
                Country=p.Country,
                Governorate=p.Governorate,
                City=p.City,
                NumOfPeople=p.NumOfPeople,
                PricePerNight=p.PricePerNight,
                Description=p.Description

            });
        }

        public PropertyReadDto? GetPropertyById(Guid id)
        {
            Property? propertyFromDb = _propertyRepo.GetPropertyById( id);
            if (propertyFromDb ==null)
            {
                return null;
            }
            return new PropertyReadDto
            {
                Id = propertyFromDb.Id,
                PropType = propertyFromDb.PropType,
                UserID = propertyFromDb.UserID,
                Country = propertyFromDb.Country,
                Governorate = propertyFromDb.Governorate,
                City = propertyFromDb.City,
                CreationDate= propertyFromDb.CreationDate,
                NumOfPeople = propertyFromDb.NumOfPeople,
                PricePerNight = propertyFromDb.PricePerNight,
                Description = propertyFromDb.Description
            };

        }
        public System.Guid Add(PropertyAddDto propertyFromRequest)
        {
            Property property = new Property
            {
                Id = propertyFromRequest.Id,
                UserID=propertyFromRequest.UserID,
                PropType = propertyFromRequest.PropType,
                Country = propertyFromRequest.Country,
                Governorate = propertyFromRequest.Governorate,
                City = propertyFromRequest.City,
                CreationDate = propertyFromRequest.CreationDate,
                NumOfPeople = propertyFromRequest.NumOfPeople,
                PricePerNight = propertyFromRequest.PricePerNight,
                Description = propertyFromRequest.Description
            };
            _propertyRepo.Add(property);
            _propertyRepo.SaveChanges();
            return property.Id;
        }

        public bool Update(PropertyUpdateDto propertyFromRequest)
        {
            Property? property = _propertyRepo.GetPropertyById(propertyFromRequest.Id);
            if (property == null)
            {
                return false;
            }
            property.Id = propertyFromRequest.Id;
            property.PropType = propertyFromRequest.PropType;
            property.UserID = propertyFromRequest.UserID;
            property.Country = propertyFromRequest.Country;
            property.Governorate = propertyFromRequest.Governorate;
            property.City = propertyFromRequest.City;
            property.CreationDate = propertyFromRequest.CreationDate;
            property.NumOfPeople = propertyFromRequest.NumOfPeople;
            property.PricePerNight = propertyFromRequest.PricePerNight;
            property.Description = propertyFromRequest.Description;
            _propertyRepo.Update(property);
            _propertyRepo.SaveChanges();
            return true;
        }

        public bool Delete(Guid id)
        {
            Property? property = _propertyRepo.GetPropertyById(id);
              if (property == null)
            {
                return false;
            }
            _propertyRepo.Delete(property);

            _propertyRepo.SaveChanges();
            return true;
        }

      

       
    }
}
