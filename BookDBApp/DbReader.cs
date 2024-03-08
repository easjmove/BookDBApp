using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDBApp
{
    public class DbReader
    {
        public LibraryContext _context;

        public DbReader()
        {
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();
            optionsBuilder.UseSqlServer(Secrets.ConnectionString);
            _context = new LibraryContext(optionsBuilder.Options);

        }

        public List<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author? Get(int id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> GetAll(string filter)
        {
            return _context.Authors.Where(x => x.AuthorName.Contains(filter)).ToList();
        }

        public Author Add(Author newAuthor)
        {
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
            return newAuthor;
        }

        public Author? Update(int id, Author newAuthor)
        {
            Author? toBeUpdated = Get(id);
            if (toBeUpdated != null)
            {
                toBeUpdated.AuthorName = newAuthor.AuthorName;
                _context.SaveChanges();
                return toBeUpdated;
            }
            return null;
        }

        public Author? Delete(int id)
        {
            Author? toBeDeleted = Get(id);
            if (toBeDeleted != null)
            {
                _context.Authors.Remove(toBeDeleted);
                _context.SaveChanges();
                return toBeDeleted;
            }
            return null;
        }
    }
}
