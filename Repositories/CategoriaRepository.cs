using projeto.Context;
using projeto.Models;
using projeto.Repositories.Interfaces;

namespace projeto.Repositories
{
    
        public class CategoriaRepository : ICategoriaRepository
        {
            private readonly AppDbContext _context;
            public CategoriaRepository(AppDbContext context)
            {
                _context = context;
            }


        IEnumerable<Categoria> ICategoriaRepository.Categorias => _context.Categorias.OrderBy(c => c.Nome);
    }
    }