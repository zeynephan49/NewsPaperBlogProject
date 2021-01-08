﻿using NewspaperBlogProject.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperBlogProject.DataAccessLayer.Repositories.Interface
{
   public interface IBaseRepository <T> where T:BaseEntity
    {
        void Add(T item);
        void Remove(int id);

        T GetById(int id);

        T GetByDefault(Expression<Func<T, bool>> exp);

        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetActive();
        List<T> GetAll();

        bool Any(Expression<Func<T, bool>> exp);
        int Save();
    }
}
