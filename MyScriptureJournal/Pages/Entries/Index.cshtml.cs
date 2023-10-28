using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Entries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Entry> Entry { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Book { get; set; }
        public string DateSort { get; set; }
        public string BookSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            /* FILTERING */
            // Use LINQ to get list of genres.
            IQueryable<string> bookQuery = from e in _context.Entry
                                            orderby e.Book
                                            select e.Book;
            var entries = from e in _context.Entry
                          select e;

            // Filter entries to match users search query
            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(Book))
            {
                entries = entries.Where(x => x.Book == Book);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            // If the sort order is empty, default it to nothing which will sort by date_desc (newest to oldest)
            DateSort = String.IsNullOrEmpty(sortOrder) ? "date_asc" : "";
            // If the sort order is book, switch it to book_desc
            BookSort = sortOrder == "book" ? "book_desc" : "book";
            // Sort entries in specific order
            switch (sortOrder)
            {
                case "book_desc":
                    entries = entries.OrderByDescending(e => e.Book);
                    break;
                case "book":
                    entries = entries.OrderBy(e => e.Book);
                    break;
                case "date_asc":
                    entries = entries.OrderBy(e => e.Date);
                    break;
                default:
                    entries = entries.OrderByDescending(e => e.Date);
                    break;
            }

            // Return filtered and sorted entries
            Entry = await entries.ToListAsync();
        }
    }
}
