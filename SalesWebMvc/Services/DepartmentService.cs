using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;


        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() //para deixar assincrona é necessario o async Task<tipo>
        {
            //return _context.Department.OrderBy(x => x.Name).ToList(); //modo sincrono
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //chamada assincrona ToListAsync é do namespace using Microsoft.EntityFrameworkCore;
            //      ^ a palavra await avisa o compilador q a chamada é assincrona
        }
    }
}
