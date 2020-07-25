using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ValuesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _dataContext.Values.ToListAsync(); 
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> getItem(int id)
        {
            try{
                var value = await _dataContext.Values.FirstAsync(x => x.Id == id);
                return Ok(value);   
            }
            catch(Exception ex){
                return BadRequest(ex.Message);
            }
        }



    }
}