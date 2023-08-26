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
}
