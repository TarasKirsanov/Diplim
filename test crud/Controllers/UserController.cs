using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using test_crud.Models;
using test_crud.Interfaces;
using test_crud.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace test_crud.Controllers
{
    [ApiController]
    [Route("UserController")]
    public class UserController : ControllerBase
    {
        private IRepository _userRepos;
        private ApplicationContext _context;
        public UserController(IRepository userRepository, ApplicationContext context)
        {
            _userRepos = userRepository;
            _context = context;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<User> GetUsers() 
        {
            return _context.UsersTable.Include(p => p.favoriteItems);
        }

        [HttpGet("FindUserByID")]
        public User Get(int id) 
        {
            return _userRepos.FindById<User>(id); 
        }

        [HttpPost("AddUser")]
        public void Add(User item) 
        {
            _userRepos.Create(item);
        }

        [HttpPost("UpdateUser")]
        public bool Update(User item)
        {
            _userRepos.Update(item);
            return true;
        }

        [HttpPost("RemoveUser")]
        public void Remove(int id)
        {
            _userRepos.Remove<User>(_userRepos.FindById<User>(id));
        }
    }
}
