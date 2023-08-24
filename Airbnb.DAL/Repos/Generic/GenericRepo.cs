using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly RentContext _rentContext;

    public GenericRepo(RentContext rentContext)
    {
        _rentContext = rentContext;
    }
    public async Task<IEnumerable<T>> GetAll()
    {
        return await _rentContext.Set<T>().ToListAsync();
    }
    public async Task<T?> GetById(int id)
    {
        return await _rentContext.Set<T>().FindAsync(id);
    }
    public async void Add(T item)
    {
         await _rentContext.Set<T>().AddAsync(item);
    }
    public void Update(T item)
    {
        _rentContext?.Set<T>().Update(item);
    }
    public void Delete(T item)
    {
        _rentContext.Set<T>().Remove(item);
    }
}
