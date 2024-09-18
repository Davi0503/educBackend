using Domain.Entidades;
using Domain.Entidades.basic;
using Domain.Interfaces.Repositories;
using Infra.data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Infra.data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private EducContext context;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(EducContext _context)
        {
            this.context = _context;
            _dbSet = context.Set<TEntity>();


        }

        public async Task Create(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();

            
        }


        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByID(int Id)
        {
            return await context.Set<TEntity>().FindAsync(Id);
        }

        public async Task Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
