using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebTime7.Context;
using WebTime7.Models;

namespace WebTime7.Repository
{
    public class BaseRepository<T> where T: Basemodel
    {
        public void Create(T model) {
            using (var context = new RespContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public List<T> Read()
        {
            using (var context = new RespContext())
            {
                return context.Set<T>().ToList();
            }
        }
        public T Read(int id)
        {
            using (var context = new RespContext())
            {
                return context.Set<T>().Find(id);
            }
        }
        public void Update(T model)
        {
            using (var context = new RespContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new RespContext())
            {
                context.Entry<T>(Read(id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
