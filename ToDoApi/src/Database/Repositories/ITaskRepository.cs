using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoApi.src.Database.Domain;

namespace todoApi.src.Database.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<Todo> GetAll();
        Todo GetById(Guid Id);
        Todo Save(Todo entity);
    }
}