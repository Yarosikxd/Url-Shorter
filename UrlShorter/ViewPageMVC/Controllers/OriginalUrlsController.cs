using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ViewPageMVC.Controllers
{
    public class OriginalUrlsController : Controller
    {
        private readonly IOriginalUrlService _originalUrlService;
        private readonly UserManager<AppUser> _userManager;
        public OriginalUrlsController(IOriginalUrlService originalUrlService, UserManager<AppUser> userManager)
        {
            _originalUrlService = originalUrlService ?? throw new ArgumentNullException(nameof(originalUrlService));
            _userManager = userManager;
        }

        // GET: OriginalUrls
        public async Task<IActionResult> Index()
        {
            var originalUrls = await _originalUrlService.GetAllOriginalUrlsAsync();
            return View(originalUrls);
        }

        // GET: OriginalUrls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalUrl = await _originalUrlService.GetOriginalUrlsByIdAsync(id.Value);
            if (originalUrl == null)
            {
                return NotFound();
            }

            return View(originalUrl);
        }

        // GET: OriginalUrls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OriginalUrls/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("NameUserCreated,FullName")] OriginalUrl originalUrl)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                originalUrl.NameUserCreated = currentUser.Name;
                var success = await _originalUrlService.AddNewOriginalUrlsAsync(originalUrl);

                if (success)
                    return RedirectToAction(nameof(Index));
                else
                    return RedirectToAction("Error"); 
            }

            return View(originalUrl);
        }




        // GET: OriginalUrls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalUrl = await _originalUrlService.GetOriginalUrlsByIdAsync(id.Value);
            if (originalUrl == null)
            {
                return NotFound();
            }
            return View(originalUrl);
        }

        // POST: OriginalUrls/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,UserId")] OriginalUrl originalUrl)
        {
            if (id != originalUrl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _originalUrlService.UpdateOriginalUrlsContentAsync(originalUrl);
                return RedirectToAction(nameof(Index));
            }
            return View(originalUrl);
        }

        // GET: OriginalUrls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var originalUrl = await _originalUrlService.GetOriginalUrlsByIdAsync(id.Value);
            if (originalUrl == null)
            {
                return NotFound();
            }

            return View(originalUrl);
        }

        // POST: OriginalUrls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var originalUrl = await _originalUrlService.GetOriginalUrlsByIdAsync(id);
            if (originalUrl == null)
            {
                return NotFound();
            }

            await _originalUrlService.DeleteOriginalUrlsAsync(originalUrl);
            return RedirectToAction(nameof(Index));
        }
    }
}
