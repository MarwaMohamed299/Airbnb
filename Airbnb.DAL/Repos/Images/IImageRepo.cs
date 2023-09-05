using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;


public interface IImageRepo:IGenericRepo<Image>
{
    IEnumerable<Image> GetAllImages();
    Image? GetImagesById(Guid Id);
    void Add(Image images);
    void Update(Image images);
    void Delete(Image images);
    int SaveChanges();

}
