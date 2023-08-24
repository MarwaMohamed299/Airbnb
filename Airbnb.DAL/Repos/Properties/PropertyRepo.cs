namespace Airbnb.DAL;

public class PropertyRepo:GenericRepo<Property>, IPropertyRepo
{
    private readonly RentContext _rentContext;

    public PropertyRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }
}
