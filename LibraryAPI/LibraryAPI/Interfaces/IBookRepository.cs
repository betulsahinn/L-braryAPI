using LibraryAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LibraryAPI.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllAsync();
        public Task<Book> GetByIdAsync(int id);   
    }
}