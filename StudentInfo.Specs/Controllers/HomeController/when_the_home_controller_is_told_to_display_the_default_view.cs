using System;
using Xunit;
using StudentInfo.WebUI.Controllers;
using Microsoft.AspNet.Mvc;

namespace StudentInfo.Specs
{
    /// <summary>
    /// Summary description for when_the_home_controller_is_told_to_display_the_default_view
    /// </summary>
    /// 
    [Trait("Home Controller", "")]
    public class when_the_home_controller_is_told_to_display_the_default_view
    {
        HomeController _controller;
        ViewResult _viewResult;

        public when_the_home_controller_is_told_to_display_the_default_view()
        {
            // given
            _controller = new HomeController();

            // when
            _viewResult = _controller.Index() as ViewResult;
        }

        [Fact]
	    public void it_should_return_the_home_view()
	    {
            // then
            Assert.True(string.IsNullOrEmpty(_viewResult.ViewName));
	    }

        [Fact]
        public void it_should_display_the_welcome_message_in_the_view()
        {
            // then
            Assert.Equal("Welcome!", _controller.ViewBag.Message);
        }
    }
}