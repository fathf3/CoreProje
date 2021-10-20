using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class AboutRepository : IAboutDal
    {
        Context c = new Context();
        public void Delete(About p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public About GetById(int id)
        {
            return c.Abouts.Find(id);
        }

        public List<About> GetListAll()
        {
            return c.Abouts.ToList();
        }

        public void Insert(About p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public void Update(About p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
