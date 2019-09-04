using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorSOAPServiceReferance;
using Microsoft.AspNetCore.Mvc;
using TestCalculator.Model;

namespace TestCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private TestProjectDbContext _dbContext;
        public ValuesController(TestProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Run project click step over or step into 
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new NotImplementedException();
        }

        [Route("Add/f={first}&s={second}")]
        [HttpGet()]
        public async Task<ActionResult<int>> Get_AddAsync(int first, int second)
        {
            try
            {
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Request To Soap"
                });
                CalculatorSoapClient soapClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
                int result = await soapClient.AddAsync(first, second);
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Response from Soap "
                });
                await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        [Route("Subtract/f={first}&s={second}")]
        [HttpGet()]
        public async Task<ActionResult<int>> Get_SubtractAsync(int first, int second)

        {
            try
            {
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Request To Soap"
                });
                CalculatorSoapClient soapClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
                int result = await soapClient.SubtractAsync(first, second);
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Response from Soap "
                });
                await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Route("Multiply/f={first}&s={second}")]
        [HttpGet()]
        public async Task<ActionResult<int>> Get_MultiplyAsync(int first, int second)
        {
            try
            {
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Request to Soap "
                });
                await _dbContext.SaveChangesAsync();
                CalculatorSoapClient soapClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
                int result = await soapClient.MultiplyAsync(first, second);
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Response from Soap "
                });
                await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Route("Divide/f={first}&s={second}")]
        [HttpGet()]
        public async Task<ActionResult<int>> Get_DivideAsync(int first, int second)
        {
            try
            {
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Request to Soap "
                });
                await _dbContext.SaveChangesAsync();
                CalculatorSoapClient soapClient = new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap12);
                int result = await soapClient.DivideAsync(first, second);
                await _dbContext.Logs.AddAsync(new Model.Log
                {
                    Value = $" Response from Soap "
                });
                await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
