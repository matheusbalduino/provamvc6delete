using Microsoft.AspNetCore.Mvc;
using ProvaCsharpMvc6.Data;
using System.Data.Entity;

namespace ProvaCsharpMvc6.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly MyDbContext _context;

        public ProdutoController(MyDbContext context)
        {
            _context = context;
        }
        // GET: Professors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(p => p.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
