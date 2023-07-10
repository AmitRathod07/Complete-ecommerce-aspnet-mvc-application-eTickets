using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();
        }


        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
//namespace eTickets.Data.Services
//{
//    public class ActorsService : IActorsService
//    {
//        private readonly AppDbContext _context;
//        public ActorsService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public void Add(Actor actor)
//        {
//            _context.Actors.Add(actor);
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<Actor>> GetAll()
//        {
//            var result = await _context.Actors.ToListAsync();
//            return result;
//        }

//        public Actor GetById(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public Actor Update(int id, Actor newActor)
//        {
//            throw new NotImplementedException();
//        }

//        //IEnumerable<Actor> IActorsService.GetAll()
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}


