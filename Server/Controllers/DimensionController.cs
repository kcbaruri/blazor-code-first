using BlazorCodeFirst.Server.Data;
using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorCodeFirst.Server.Controllers
{
    public class DimensionController : Controller
    {
        OrderDataAccessLayer dataAccessLayer = new OrderDataAccessLayer();
       
        [HttpGet]
        [Route("api/Dimension/Getlist")]
        public IEnumerable<Dimension> GetDimensionList()
        {
            return dataAccessLayer.GetDimensionList();
        }

        [HttpGet]
        [Route("api/Dimension/GetDimensionById/{id}")]
        public Dimension GetDimensionById(int id)
        {
            return dataAccessLayer.GetDimensionById(id);
        }

        [HttpPost]
        [Route("api/Dimension/AddDimension")]
        public void AddDimension([FromBody] Dimension dimension)
        {
            if (ModelState.IsValid)
            {
                dataAccessLayer.AddDimension(dimension);
            }
        }

        [HttpPut]
        [Route("api/Dimension/UpdateDimension")]
        public void UpdateDimension([FromBody] Dimension dimension)
        {
            dataAccessLayer.UpdateDimension(dimension);
        }

        [HttpDelete]
        [Route("api/Dimension/DeleteDimension/{id}")]
        public void DeleteDimension(int id)
        {
            dataAccessLayer.DeleteDimension(id);
        }
    }
}
