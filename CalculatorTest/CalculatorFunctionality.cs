using System;
using Xunit;
using Bunit;
using BlazorDemo.Pages;

namespace CalculatorTest
{
    public class CalculatorFunctionality : TestContext
    {
        private string _Ten = "10";
        private string _TwentyFive = "25";

        [Fact]
        public void Test_Add_25_And_10_Should_Return_35_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-light");
            clickElement.Click();


            Assert.Equal("35", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Add_25_And_10_Should_NOT_Return_35_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-light");
            clickElement.Click();


            Assert.NotEqual("15", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Subtract_25_And_10_Should_Return_15_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-primary");
            clickElement.Click();


            Assert.Equal("15", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Subtract_25_And_10_Should_NOT_Return_15_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-primary");
            clickElement.Click();


            Assert.NotEqual("35", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Multiply_25_And_10_Should_Return_250_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-success");
            clickElement.Click();


            Assert.Equal("250", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Multiply_25_And_10_Should_NOT_Return_2_And_A_Half_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-success");
            clickElement.Click();


            Assert.NotEqual("2,5", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Divive_25_And_10_Should_Return_2_And_A_Half_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-info");
            clickElement.Click();


            Assert.Equal("2,5", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Divide_25_And_10_Should_NOT_Return_250_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-info");
            clickElement.Click();


            Assert.NotEqual("250", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Modulo_Of_25_And_10_Should_Return_5_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-modulo");
            clickElement.Click();


            Assert.Equal("5", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Modulo_Of_25_And_10_Should_NOT_Return_10_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-modulo");
            clickElement.Click();


            Assert.NotEqual("10", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Power_Of_25_To_The_10_Should_Return_95367431649625_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-PowerOf");
            clickElement.Click();


            Assert.Equal("95367431640625", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Power_Of_25_To_The_10_Should_NOT_Return_50_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_TwentyFive);
            calculatorComponent.Find("div.row:nth-child(3) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-PowerOf");
            clickElement.Click();


            Assert.NotEqual("50", finalResult.GetAttribute("value"));
        }



        [Fact]
        public void Test_Factorial_Of_10_Should_Return_3628800_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-Factorial");
            clickElement.Click();


            Assert.Equal("3628800", finalResult.GetAttribute("value"));
        }

        [Fact]
        public void Test_Factorial_Of_10_Should_NOT_Return_200_Succeed()
        {
            var calculatorComponent = RenderComponent<Calculator>();


            calculatorComponent.Find("div.row:nth-child(1) > div:nth-child(2) > input:nth-child(1)").Change(_Ten);

            var finalResult = calculatorComponent.Find("div.row:nth-child(5) > div:nth-child(2) > input:nth-child(1)");


            var clickElement = calculatorComponent.Find(".btn-Factorial");
            clickElement.Click();


            Assert.NotEqual("200", finalResult.GetAttribute("value"));
        }
    }
}
