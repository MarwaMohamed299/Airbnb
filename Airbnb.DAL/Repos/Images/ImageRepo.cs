using Airbnb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class ImageRepo : GenericRepo<Image>, IImageRepo
{
    private readonly RentContext _rentContext;

    public ImageRepo(RentContext rentContext) : base(rentContext)
    {
        _rentContext = rentContext;
    }

    public IEnumerable<Image> GetAllImages()                //GetAll
    {
        return _rentContext.Set<Image>().ToList();
    }

    public Image? GetImagesById(Guid Id)                   //GetById
    {
        return _rentContext.Set<Image>().Find(Id);
    }
    public void Add(Image images)                           //Add
    {
        _rentContext.Set<Image>().Add(images);
    }
    public void Update(Image images)                       //update
    {
    }
    public void Delete(Image images)                       //Delete
    {
        _rentContext.Set<Image>().Remove(images);
    }


    public int SaveChanges()                                // SaveChanges
    {
        return _rentContext.SaveChanges();
    }

   
}
