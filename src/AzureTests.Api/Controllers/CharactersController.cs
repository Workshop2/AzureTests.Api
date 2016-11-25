using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AzureTests.Api.Controllers
{
    public class CharactersController : ApiController
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

        // GET: api/Characters
        public IDictionary<Guid, string> Get()
        {
            return _characters;
        }

        // GET: api/Characters/5
        //public string Get(Guid id)
        //{
        //    return _characters[id];
        //}

        // POST: api/Characters
        public Guid Post([FromBody] string value)
        {
            var guid = Guid.NewGuid();
            _characters.Add(guid, value);
            return guid;
        }
        
        // DELETE: api/Characters/5
        public void Delete(Guid id)
        {
            _characters.Remove(id);
        }
    }
}
