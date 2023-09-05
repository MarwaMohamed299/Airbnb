using Airbnb.BL.Dtos.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL.Managers.Images
{
    public interface IImagesManager
    {
        IEnumerable<ImagesReadDto> GetAllImages();
        ImagesReadDto? GetImagesById(Guid Id);
        string Add(ImagesAddDto images);
        bool Update(ImagesUpdateDto images);
        bool Delete( Guid Id);


    }
}
