using Microsoft.AspNetCore.Mvc;
using MvcLabManager.Models;

namespace MvcLabManager.Controllers;

public class LabController : Controller
{
    private readonly LabManagerContext _context;

    public LabController(LabManagerContext context)
    {
        _context = context;
    }

    public IActionResult Index() {
        return View(_context.Labs.ToList());
    } 

    public IActionResult Show(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound();
        }

        return View(lab);
    }

    public IActionResult Delete(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound();
        }
       
        _context.Labs.Remove(lab);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Update(int id)
    {
        Lab lab = _context.Labs.Find(id);

        if(lab == null)
        {
            return NotFound();
        }

        return View(lab);
    }

    [HttpPost]
    public IActionResult Update(Lab lab)
    {
        if(!ModelState.IsValid) 
        {
            return View(lab);
        }

        _context.Labs.Update(lab);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }



    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Lab lab)
    {
        if(!ModelState.IsValid) 
        {
            return View(lab);
        }
        _context.Labs.Add(lab);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}