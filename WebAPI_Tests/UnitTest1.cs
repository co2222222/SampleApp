using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebAPI_Tests
{
    public class ControllerTest
    {
        private readonly WebAPI.Controllers.SampleClassController _controller;

        public ControllerTest()
        {
            _controller = new WebAPI.Controllers.SampleClassController();
        }

        [Fact]
        public void Get_TestFormat()
        {
            var Result = _controller.GetSampleClass(1,20);
            Assert.IsType<string>(Result as string);
        }

        [Fact]
        public void Get_TestStructure()
        {
            var Result = _controller.GetSampleClass(1, 20);
            JObject jsonObject = JObject.Parse(Result);
            Assert.Equal(7, jsonObject.Count);
        }
    }
}