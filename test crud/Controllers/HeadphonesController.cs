using Microsoft.AspNetCore.Mvc;
using test_crud.Models;
using test_crud.Interfaces;
using System.Collections.Generic;

namespace test_crud.Controllers
{
    [ApiController]
    [Route("HeadphonesController")]
    public class HeadphonesController : ControllerBase
    {
        private IRepository _headphonesRepos;

        public HeadphonesController(IRepository headphonesRepository)
        {
            _headphonesRepos = headphonesRepository;
        }

        [HttpGet("GetHeadphonesList")]
        public IEnumerable<Headphones> GetUsers()
        {
            return _headphonesRepos.Get<Headphones>();
        }   

        [HttpGet("HeadphonesFindByID")]
        public Headphones Get(int id)
        {
            return _headphonesRepos.FindById<Headphones>(id);
        }

        [HttpPost("AddHeadphones")]
        public void Add(Headphones item)
        {
            _headphonesRepos.Create(item);
        }

        [HttpPost("UpdateHeadphones")]
        public bool Update(Headphones item)
        {
            _headphonesRepos.Update(item);
            return true;
        }

        [HttpPost("RemoveHeadphones")]
        public void Remove(int id)
        {
            _headphonesRepos.Remove<Headphones>(_headphonesRepos.FindById<Headphones>(id));
        }

    }
}
