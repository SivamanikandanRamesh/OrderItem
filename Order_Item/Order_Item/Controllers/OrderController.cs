using Microsoft.AspNetCore.Mvc;
using Order_Item.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Order.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public List<Cart> cart = new List<Cart>()
        {
            new Cart(){Id=1,userId=101,menuItemId=1001,menuItemName="Shawarma"},
            new Cart(){Id=2,userId=102,menuItemId=1002,menuItemName="Mojito"},
            new Cart(){Id=3,userId=103,menuItemId=1003,menuItemName="Icecream"}
        };
        [HttpGet]
        [Route("Get")]
        public IEnumerable<Cart> Get()
        {
            return cart;
        }
        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Cart> Get(int id)
        {
            return cart;
        }
    }
}
