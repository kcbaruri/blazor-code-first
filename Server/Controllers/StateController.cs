using BlazorCodeFirst.Server.Data;
using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorCodeFirst.Server.Controllers
{
    public class StateController : Controller
    {
        OrderDataAccessLayer dataAccessLayer = new OrderDataAccessLayer();
       
        [HttpGet]
        [Route("api/State/Getlist")]
        public IEnumerable<State> GetStateList()
        {
            return dataAccessLayer.GetStateList();
        }

        [HttpGet]
        [Route("api/State/GetStateById/{id}")]
        public State GetStateById(int id)
        {
            return dataAccessLayer.GetStateById(id);
        }

        [HttpPost]
        [Route("api/State/AddState")]
        public void AddState([FromBody] State state)
        {
            if (ModelState.IsValid)
            {
                dataAccessLayer.AddState(state);
            }
        }

        [HttpPut]
        [Route("api/State/UpdateState")]
        public void UpdateState([FromBody] State state)
        {
            dataAccessLayer.UpdateState(state);
        }

        [HttpDelete]
        [Route("api/State/DeleteState/{id}")]
        public void DeleteState(int id)
        {
            dataAccessLayer.DeleteState(id);
        }
    }
}
