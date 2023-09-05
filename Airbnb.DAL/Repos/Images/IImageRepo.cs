using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;


public interface IImageRepo:IGenericRepo<Images>
{
    IEnumerable<Images> GetAllImages();
    Images? GetImagesById(Guid Id);
    void Add(Images images);
    void Update(Images images);
    void Delete(Images images);
    int SaveChanges();

}
