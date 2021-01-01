using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Wsei.ExchangeThings.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        public AddNewItemResponseModel Post(ItemModel item)
        {
            bool succes = !string.IsNullOrEmpty(item.Description) && !string.IsNullOrEmpty(item.Name);
            var response = new AddNewItemResponseModel
            {
                success = succes,
                message = succes ? "" : "Input fields cannot be empty"
            };
            return response;
        }
    }
}
