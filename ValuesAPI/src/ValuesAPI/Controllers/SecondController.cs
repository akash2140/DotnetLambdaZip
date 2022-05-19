using Microsoft.AspNetCore.Mvc;

namespace ValuesAPI.Controllers;



[Route("api/two")]
public class SecondController : Controller
{
    //GET api/two/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Hello", "World from Second Controller" };
    }

    // GET api/two/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return id+"Second Controller invoked";
    }

    // POST api/two/values
    [HttpPost]
    public void Post([FromBody]string value)
    {

    }

    // PUT apitwo/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE apitwo/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}