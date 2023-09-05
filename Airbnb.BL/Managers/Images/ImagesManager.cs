using Airbnb.BL.Dtos.Images;
using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Images
{
    public class ImagesManager : IImagesManager
    {
        private readonly IImageRepo _imagesRepo;

        public ImagesManager( IImageRepo imagesRepo )
        {
            _imagesRepo = imagesRepo;
        }

       

       public IEnumerable<ImagesReadDto> GetAllImages()                        //GetALL
        {
            IEnumerable<Image> imagesFromDb = _imagesRepo.GetAllImages();
            return imagesFromDb.Select(i => new ImagesReadDto
            {
                Id=i.Id,
                URL = i.URL
            });
        }
        public ImagesReadDto? GetImagesById(Guid Id)            //GetById
        {
            Image? imageFromDb = _imagesRepo.GetImagesById(Id);
            if (imageFromDb == null )
            {
                return null;
            }
            return new ImagesReadDto
            {
                URL = imageFromDb.URL,
                Id = imageFromDb.Id
            };
        }


       public string Add(ImagesAddDto imagesFromRequest)        //Add
        {
            Image image = new Image
            {
                URL = imagesFromRequest.URL
            };
            _imagesRepo.Add(image);
            _imagesRepo.SaveChanges();
            return image.Id.ToString();
        }

       
       public bool Update(ImagesUpdateDto imagesFromRequest)        //update
        {
            Image? image = _imagesRepo.GetImagesById(imagesFromRequest.Id);
            if (imagesFromRequest == null)
            {
                return false;
            }
            image.URL = imagesFromRequest.URL;
            _imagesRepo.SaveChanges();
            _imagesRepo.Update(image);
            return true;
        }
       public bool Delete(Guid Id)          //Delete
        {
            Image? image = _imagesRepo.GetImagesById(Id);
            if(image == null)
            {
                return false;
            }
            _imagesRepo.Delete(image);
            _imagesRepo.SaveChanges();
            return true;
        }



    }
}
