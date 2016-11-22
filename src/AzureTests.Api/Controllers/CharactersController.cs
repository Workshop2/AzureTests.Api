using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AzureTests.Api.Controllers
{
    [Route("api/[controller]")]
    public class CharactersController : Controller
    {
        private static Dictionary<Guid, string> _characters = new Dictionary<Guid, string>
        {
            {Guid.NewGuid(), "Malcolm Reynolds" },
            {Guid.NewGuid(), "Zoe Washburne" },
            {Guid.NewGuid(), "Hoban Washburne" },
            {Guid.NewGuid(), "Inara Serra" },
            {Guid.NewGuid(), "Jayne Cobb" },
            {Guid.NewGuid(), "Kaylee Frye" },
            {Guid.NewGuid(), "Simon Tam" },
            {Guid.NewGuid(), "River Tam" },
            {Guid.NewGuid(), "Derrial Book" },
        };
        
        // GET api/characters
        [HttpGet]
        public IDictionary<Guid, string> Get()
        {
            return _characters;
        }

        // GET api/characters/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return _characters[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Tuple<Guid, string> value)
        {
            _characters.Add(value.Item1, value.Item2);
        }
        
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _characters.Remove(id);
        }
    }
}
