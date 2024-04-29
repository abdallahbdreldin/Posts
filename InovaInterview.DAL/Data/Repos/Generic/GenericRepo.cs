using InovaInterview.DAL.Data.Context;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Generic
{
    public class GenericRepo<Tentity> : IGenericRepo<Tentity> where Tentity : class
    {
        private readonly PostsContext _context;

        public GenericRepo(PostsContext context)
        {
            _context = context;
        }

        public void Add(Tentity entity)
        {
            _context.Add(entity);
        }

        public List<Tentity> GetAll()
        {
            return _context.Set<Tentity>()
                .ToList();
        }

        public Tentity? GetById(int id)
        {
            return _context.Set<Tentity>()
                .Find(id);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
