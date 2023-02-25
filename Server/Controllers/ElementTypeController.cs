using BlazorCodeFirst.Server.Data;
using BlazorCodeFirst.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlazorCodeFirst.Server.Controllers
{
    public class ElementTypeController : Controller
    {
        OrderDataAccessLayer dataAccessLayer = new OrderDataAccessLayer();
       
        [HttpGet]
        [Route("api/Elementtype/Getlist")]
        public IEnumerable<ElementType> GetElementTypeList()
        {
            return dataAccessLayer.GetElementTypes();
        }

        [HttpGet]
        [Route("api/Elementtype/GetElementTypeById/{id}")]
        public ElementType GetElementTypeById(int id)
        {
            return dataAccessLayer.GetElementTypeById(id);
        }

        [HttpPost]
        [Route("api/Elementtype/AddElementType")]
        public void AddElementType([FromBody] ElementType elementType)
        {
            if (ModelState.IsValid)
            {
                dataAccessLayer.AddElementType(elementType);
            }
           
        }

        [HttpPut]
        [Route("api/Elementtype/UpdateElementType")]
        public void UpdateElementType([FromBody] ElementType elementType)
        {
            dataAccessLayer.UpdateElementType(elementType);
        }

        [HttpDelete]
        [Route("api/Elementtype/DeleteElementType/{id}")]
        public void DeleteElementType(int id)
        {
            dataAccessLayer.DeleteElementType(id);
        }
    }
}
