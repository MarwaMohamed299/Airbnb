﻿using Airbnb.BL.Dtos.Properties;
using Airbnb.DAL;

namespace Airbnb.BL.Managers.properties
{
    
    public class PropertyManager : IPropertyManager
    {
        private IPropertyRepo _propertyRepo;

        public PropertyManager (IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }
        public IEnumerable<PropertyReadDto> GetAllProperties()
        {
            IEnumerable<Property> propertyFromDb = _propertyRepo.GetAllProperties();
            return propertyFromDb.Select(p => new PropertyReadDto
            {
                Id=p.Id,
                CreationDate = p.CreationDate,
                PropType = p.PropType,
                UserID=p.UserID,
                Country= p.Country,
                Governorate=p.Governorate,
                City=p.City,
                NumOfPeople=p.NumOfPeople,
                PricePerNight=p.PricePerNight,
                Description=p.Description

            });
        }

        public PropertyReadDto? GetPropertyById(string id)
        {
            Property? propertyFromDb = _propertyRepo.GetPropertyById( id);
            if (propertyFromDb ==null)
            {
                return null;
            }
            return new PropertyReadDto
            {
                Id=propertyFromDb.Id.ToString(),
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
        public string Add(ResevationAddDto propertyFromRequest)
        {
            Property property = new Property
            {
                UserID=propertyFromRequest.UserID,
                PropType = propertyFromRequest.PropType,
                Country = (DAL.Data.DataTypes.Country)propertyFromRequest.Country,
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
            property.PropType = propertyFromRequest.PropType;
            property.UserID = propertyFromRequest.UserID;
            property.Country = (DAL.Data.DataTypes.Country)propertyFromRequest.Country;
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

        public bool Delete(string id)
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
