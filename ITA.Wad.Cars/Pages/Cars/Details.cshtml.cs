﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ITA.Wad.Cars.Data;
using ITA.Wad.Cars.Data.Models;

namespace ITA.Wad.Cars.Pages.Cars
{
    public class DetailsModel : PageModel
    {
        private readonly ITA.Wad.Cars.Data.ApplicationDbContext _context;

        public DetailsModel(ITA.Wad.Cars.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
