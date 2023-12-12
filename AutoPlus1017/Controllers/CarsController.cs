using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoPlus1017.Data;
using AutoPlus1017.Entities;
using Microsoft.AspNetCore.Authorization;

namespace AutoPlus1017.Controllers
{
    
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index(string filter)
        {
            List<Car> filteredCars =await _context.Cars.ToListAsync(); 
            
            switch (filter)
            {
                //ToDo: Extract floating strings into constants
                case "ЧистоНов":
                    filteredCars = filteredCars.Where(c => c.Condition.ToString() == filter).ToList();
                    break;
                case "Използван":
                    filteredCars = filteredCars.Where(c => c.Condition.ToString() == filter).ToList();
                    break;
                case "Газ":
                    filteredCars = filteredCars.Where(c => c.Fuel.ToString() == filter).ToList();
                    break;
                case "Нафта":
                    filteredCars = filteredCars.Where(c => c.Fuel.ToString() == filter).ToList();
                    break;
                case "Бензин":
                    filteredCars = filteredCars.Where(c => c.Fuel.ToString() == filter).ToList();
                    break;
                case "ЦенаНизходящ":
                    filteredCars = filteredCars.OrderByDescending(c => c.Price).ToList();
                    break;
                case "ЦенаВъзходящ":
                    filteredCars = filteredCars.OrderBy(c => c.Price).ToList();
                    break;
            }
            return View(filteredCars);
           
        }
 
        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,Description,YearProduction,Color,Price,Condition,Fuel,HorsePowers,ThumbnailImagePath")] Car car)
        {
            if (ModelState.IsValid)
            {
                _context.Add(car);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model,Description,YearProduction,Color,Price,Condition,Fuel,HorsePowers,ThumbnailImagePath")] Car car)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(car);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
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
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Cars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Cars.Any(e => e.Id == id);
        }
    }
}
