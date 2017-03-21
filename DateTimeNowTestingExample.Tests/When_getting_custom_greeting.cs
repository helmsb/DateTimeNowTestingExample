using System;
using DateTimeNowTestingExample.Controllers;
using Xunit;
using DateTimeNowTestingExample.Classes;

namespace Tests
{
    public class When_getting_custom_greeting
    {
        private HomeController _controller;
       
        public When_getting_custom_greeting()
        {
            _controller = new HomeController();
        }

        [Fact]
        public void Should_return_correct_custom_message_for_monday() 
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 13);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("It's the start of a new week!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_tuesday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 14);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("Almost halfway there!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_wednesday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 15);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("Happy Humpday!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_thursday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 16);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("Almost Friday!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_friday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 17);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("TGIF!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_saturday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 18);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("It's Saturday!", greeting);
        }

        [Fact]
        public void Should_return_correct_custom_message_for_sunday()
        {
            TestableDateTime.GetDateTimeNow = () => new DateTime(2017, 3, 19);
            var greeting = _controller.GetDateAwareGreeting();
            Assert.Equal("Let's get ready for a new week!", greeting);
        }
    }
}
