using _1.DAL.Context;
using ASM_CS5.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_CS5.Repositories
{
    public class AllRepositories<T>: IAllRepositories<T> where T: class
    {
        FpolyDBContext context;
        DbSet<T> dbset;
        public AllRepositories()
        {
        }
        public AllRepositories(FpolyDBContext context, DbSet<T> dbset)
        {
            this.context = context;
            this.dbset = dbset;
        }
        public bool CreateItem(T item)
        {
            try
            {
                dbset.Add(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteItem(T item)
        {
            try
            {
                dbset.Remove(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public bool UpdateItem(T item)
        {
            try
            {
                dbset.Update(item);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
