
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using termProjectPhotoApp.Models;

public class PhotosController : Controller
{
    private readonly PhotoContext _context;

    public PhotosController(PhotoContext context)
    {
        _context = context;
    }

    // GET: PHOTOSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Gallery.ToListAsync());
    }

    // GET: PHOTOSS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var photos = await _context.Gallery
            .FirstOrDefaultAsync(m => m.ID == id);
        if (photos == null)
        {
            return NotFound();
        }

        return View(photos);
    }

    // GET: PHOTOSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PHOTOSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,Title,Description,Credit,ImageUrl,PhotoType")] Photos photos)
    {
        if (ModelState.IsValid)
        {
            _context.Add(photos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(photos);
    }

    // GET: PHOTOSS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var photos = await _context.Gallery.FindAsync(id);
        if (photos == null)
        {
            return NotFound();
        }
        return View(photos);
    }

    // POST: PHOTOSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("ID,Title,Description,Credit,ImageUrl,PhotoType")] Photos photos)
    {
        if (id != photos.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(photos);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotosExists(photos.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(photos);
    }

    // GET: PHOTOSS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var photos = await _context.Gallery
            .FirstOrDefaultAsync(m => m.ID == id);
        if (photos == null)
        {
            return NotFound();
        }

        return View(photos);
    }

    // POST: PHOTOSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var photos = await _context.Gallery.FindAsync(id);
        if (photos != null)
        {
            _context.Gallery.Remove(photos);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PhotosExists(int? id)
    {
        return _context.Gallery.Any(e => e.ID == id);
    }
}
