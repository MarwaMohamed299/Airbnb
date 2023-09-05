﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IGenericRepo<T> where T : class
{
    Task<IEnumerable<T>> GetAllProperties();
    Task <T?> GetById(int id);  
    void Add (T item);
    void Update (T item);
    void Delete (T item);
}
