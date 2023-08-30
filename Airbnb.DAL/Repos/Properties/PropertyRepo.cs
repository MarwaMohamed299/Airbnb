namespace Airbnb.DAL;

public class PropertyRepo:GenericRepo<Property>, IPropertyRepo
{
    private readonly RentContext _rentContext;

    public PropertyRepo(RentContext rentContext):base(rentContext)
    {
        _rentContext = rentContext;
    }

    public Property? GetById(Guid id)
    {
        return _rentContext.Set<Property>().Find(id);
    }

    void IPropertyRepo.Add(Property property)
    {
        _rentContext.Set<Property>().Add(property);
    }

    void IPropertyRepo.Delete(Property property)
    {
        _rentContext.Set<Property>().Remove(property);
    }

    IEnumerable<Property> IPropertyRepo.GetAll()
    {
        return _rentContext.Set<Property>();
    }

    Property? IPropertyRepo.GetById(int id)
    {
        return _rentContext.Set<Property>().Find(id);
    }

    int IPropertyRepo.SaveChanges()
    {
        return _rentContext.SaveChanges();
    }

    void IPropertyRepo.Update(Property property)
    {
    }
}
