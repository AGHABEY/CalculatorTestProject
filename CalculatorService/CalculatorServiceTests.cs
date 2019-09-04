using System;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorService
{
    public class CalculatorServiceTests
    {
        [Fact]
        public async Task CalculatorServiceAddFunction_TwoValidParams_ReturnSuccessResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/add/f=12&s=13");

            Assert.Equal("25", serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceAddFunction_TwoValidParams_ReturnInvalidResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/add/f=12&s=13");

            Assert.NotEqual("23",serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceSubtractFunction_TwoValidParams_ReturnSuccessResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/subtract/f=12&s=13");

            Assert.Equal("-1", serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceSubtractFunction_TwoValidParams_ReturnInvalidResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/subtract/f=12&s=13");

            Assert.NotEqual("12", serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceMultiplyFunction_TwoValidParams_ReturnSuccessResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/multiply/f=12&s=13");

            Assert.Equal("156", serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceMultiplyFunction_TwoValidParams_ReturnInvalidResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/multiply/f=12&s=13");

            Assert.NotEqual("159", serviceResult);
        }

        [Fact]
        public async Task CalculatorServiceDivideFunction_TwoValidParams_ReturnSuccessResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/divide/f=12&s=13");

            Assert.Equal("1", serviceResult);

        }
        [Fact]
        public async Task CalculatorServiceDivideFunction_TwoValidParams_ReturnInvalidResult()
        {
            HttpServiceRequester serviceRequester = new HttpServiceRequester();
            string serviceResult = await serviceRequester.SendHttpGetAsync("https://localhost:44389/api/values/divide/f=12&s=13");

            Assert.NotEqual("12", serviceResult);

        }

    }
}
