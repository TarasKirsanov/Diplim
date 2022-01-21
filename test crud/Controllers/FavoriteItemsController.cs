using Microsoft.AspNetCore.Mvc;
using test_crud.Interfaces;
using System.Collections.Generic;
using test_crud.Models;
using test_crud.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace test_crud.Controllers
{
    [ApiController]
    [Route("FavoriteItemsController")]
    public class FavoriteItemsController : ControllerBase
    {
        private IRepository _favoriteItems;
        private ApplicationContext _context;

        public FavoriteItemsController(IRepository favoriteItems, ApplicationContext context) {
            _favoriteItems = favoriteItems;
            _context = context;
        }

        //[HttpGet("GetFavorites")]
        //public IEnumerable<FavoriteItem> GetFavoriteItems()
        //{
        //    return _context.FavoriteItemsTable.Include(x => x.User);
        //}

        [HttpGet("FindFavoriteById")]
        public FavoriteItem Get(int id)
        {
            return _favoriteItems.FindById<FavoriteItem>(id);
        }

        [HttpPost("AddFavorites")]
        public void Add(FavoriteItem item)
        {
            _favoriteItems.Create(item);
        }

        [HttpPost("RemoveFavoriteItem")]
        public void Remove(int id)
        {
            _favoriteItems.Remove<FavoriteItem>(_favoriteItems.FindById<FavoriteItem>(id));
        }


    }
}
