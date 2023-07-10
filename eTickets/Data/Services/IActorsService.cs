using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        //Task<IEnumerable<Actor>> GetAll();
        //Actor GetById(int id);
        //void Add(Actor actor);
        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Actor Update(int id, Actor newActor);
        //void Delete(int id);

        //Task<IEnumerable<Actor>> GetAllAsync();
        //Task<Actor> GetByIdAsync(int id);
        //Task AddAsync(Actor actor);
        //Task<Actor> UpdateAsync(int id, Actor newActor);
        //Task DeleteAsync(int id);


        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }

}