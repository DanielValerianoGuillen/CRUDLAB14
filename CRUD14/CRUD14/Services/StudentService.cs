using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD14
{
    public class StudentService
    {
        private readonly AppDbContext _context;
        public StudentService() => _context = App.GetContext();
        public bool Create(Student item)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CreateRange(List<Student> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.People.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Student> Get()
        {
            return _context.People.ToList();
        }
        public List<Student> GetByText(string text)
        {
            return _context.People.Where(x => x.FullName.Contains(text)).ToList();
        }
    }
}
