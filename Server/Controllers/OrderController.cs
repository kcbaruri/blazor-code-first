using BlazorCodeFirst.Server.Data;
using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorCodeFirst.Server.Controllers
{
    public class OrderController : Controller
    {
        OrderDataAccessLayer dataAccessLayer = new OrderDataAccessLayer();
       
        [HttpGet]
        [Route("api/Order/Getlist")]
        public IEnumerable<Order> GetOrderList()
        {
            return dataAccessLayer.GetOrderList();
        }

        [HttpGet]
        [Route("api/Order/GetOrderById/{id}")]
        public Order GetOrderById(int id)
        {
            return dataAccessLayer.GetOrderById(id);
        }

        [HttpPost]
        [Route("api/Order/AddOrder")]
        public void AddOrder([FromBody] Order order)
        {
            if (ModelState.IsValid)
            {
                dataAccessLayer.AddOrder(order);
            }
        }

        [HttpPut]
        [Route("api/Order/UpdateOrder")]
        public void UpdateOrder([FromBody] Order order)
        {
            dataAccessLayer.UpdateOrder(order);
        }

        [HttpDelete]
        [Route("api/Order/DeleteOrder/{id}")]
        public void DeleteOrder(int id)
        {
            dataAccessLayer.DeleteOrder(id);
        }
    }
}
