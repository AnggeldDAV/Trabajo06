using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabajo06.Models;
using Trabajo06.Services;

namespace Trabajo06.Controllers
{
    public class SalesOrderDetailsController : Controller
    {
        private readonly AdventureWorks2016Context _context;

        public SalesOrderDetailsController(AdventureWorks2016Context context)
        {
            _context = context;
        }

        // GET: SalesOrderDetails
        public async Task<IActionResult> Index(
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var adventureWorks2016Context = _context.SalesOrderDetail.Include(s => s.SalesOrder);
            var consulta = adventureWorks2016Context.OrderBy(x => x.ModifiedDate).ThenBy(x => x.ProductId);
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            int pageSize = 20;
            return View(await Paginacion<SalesOrderDetail>.CreateAsync(consulta.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        public async Task<IActionResult> IndexConsultaPrecios2011(string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var adventureWorks2016Context = _context.SalesOrderDetail.Include(s => s.SalesOrder);
            var consulta = adventureWorks2016Context.Where(x => x.ModifiedDate.Year == 2011 && x.UnitPrice > 30).OrderBy(x => x.ModifiedDate).ThenBy(x => x.ProductId);
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            int pageSize = 20;
            return View(await Paginacion<SalesOrderDetail>.CreateAsync(consulta.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        public async Task<IActionResult> IndexConsultaPrecios2012(string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var adventureWorks2016Context = _context.SalesOrderDetail.Include(s => s.SalesOrder);
            var consulta = adventureWorks2016Context.Where(x => x.ModifiedDate.Year == 2012 && x.UnitPrice < 1000).OrderBy(x => x.ModifiedDate).ThenBy(x => x.ProductId);
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            int pageSize = 20;
            return View(await Paginacion<SalesOrderDetail>.CreateAsync(consulta.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> IndexConsultaPrecios2013(string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var adventureWorks2016Context = _context.SalesOrderDetail.Include(s => s.SalesOrder);
            var consulta = adventureWorks2016Context.Where(x => x.ModifiedDate.Year == 2013 && x.UnitPrice > 100 && x.UnitPrice < 2000).OrderBy(x => x.ModifiedDate).ThenBy(x => x.ProductId);
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            int pageSize = 20;
            return View(await Paginacion<SalesOrderDetail>.CreateAsync(consulta.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> IndexConsulta2014(string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var adventureWorks2016Context = _context.SalesOrderDetail.Include(s => s.SalesOrder);
            var consulta = adventureWorks2016Context.Where(x => x.ModifiedDate.Year == 2014).OrderBy(x => x.ModifiedDate).ThenBy(x => x.ProductId);
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            int pageSize = 20;
            return View(await Paginacion<SalesOrderDetail>.CreateAsync(consulta.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        // GET: SalesOrderDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderDetail = await _context.SalesOrderDetail
                .Include(s => s.SalesOrder)
                .FirstOrDefaultAsync(m => m.SalesOrderId == id);
            if (salesOrderDetail == null)
            {
                return NotFound();
            }

            return View(salesOrderDetail);
        }

        // GET: SalesOrderDetails/Create
        public IActionResult Create()
        {
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrderHeader, "SalesOrderId", "SalesOrderId");
            return View();
        }

        // POST: SalesOrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SalesOrderId,SalesOrderDetailId,CarrierTrackingNumber,OrderQty,ProductId,SpecialOfferId,UnitPrice,UnitPriceDiscount,LineTotal,Rowguid,ModifiedDate")] SalesOrderDetail salesOrderDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salesOrderDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrderHeader, "SalesOrderId", "SalesOrderId", salesOrderDetail.SalesOrderId);
            return View(salesOrderDetail);
        }

        // GET: SalesOrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderDetail = await _context.SalesOrderDetail.FindAsync(id);
            if (salesOrderDetail == null)
            {
                return NotFound();
            }
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrderHeader, "SalesOrderId", "SalesOrderId", salesOrderDetail.SalesOrderId);
            return View(salesOrderDetail);
        }

        // POST: SalesOrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SalesOrderId,SalesOrderDetailId,CarrierTrackingNumber,OrderQty,ProductId,SpecialOfferId,UnitPrice,UnitPriceDiscount,LineTotal,Rowguid,ModifiedDate")] SalesOrderDetail salesOrderDetail)
        {
            if (id != salesOrderDetail.SalesOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salesOrderDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalesOrderDetailExists(salesOrderDetail.SalesOrderId))
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
            ViewData["SalesOrderId"] = new SelectList(_context.SalesOrderHeader, "SalesOrderId", "SalesOrderId", salesOrderDetail.SalesOrderId);
            return View(salesOrderDetail);
        }

        // GET: SalesOrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var salesOrderDetail = await _context.SalesOrderDetail
                .Include(s => s.SalesOrder)
                .FirstOrDefaultAsync(m => m.SalesOrderId == id);
            if (salesOrderDetail == null)
            {
                return NotFound();
            }

            return View(salesOrderDetail);
        }

        // POST: SalesOrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var salesOrderDetail = await _context.SalesOrderDetail.FindAsync(id);
            if (salesOrderDetail != null)
            {
                _context.SalesOrderDetail.Remove(salesOrderDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalesOrderDetailExists(int id)
        {
            return _context.SalesOrderDetail.Any(e => e.SalesOrderId == id);
        }
    }
}
