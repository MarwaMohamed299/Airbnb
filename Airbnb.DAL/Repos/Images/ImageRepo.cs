using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class ImageRepo : GenericRepo<Images>, IImageRepo
{
    private readonly RentContext _rentContext;

    public ImageRepo(RentContext rentContext) : base(rentContext)
    {
        _rentContext = rentContext;
    }

    public IEnumerable<Images> GetAllImages()                //GetAll
    {
      return  _rentContext.Set<Images>().ToList();
    }

    public Images? GetImagesById(Guid Id)                   //GetById
    {
        return _rentContext.Set<Images>().Find();
    }
    public void Add(Images images)                           //Add
    {
        _rentContext.Set<Images>().Add(images);
    }
    public void Update(Images images)                       //update
    {
    }
    public void Delete(Images images)                       //Delete
    {
        _rentContext.Set<Images>().Remove(images);
    }


    public int SaveChanges()                                // SaveChanges
    {
        return _rentContext.SaveChanges();
    }
}
