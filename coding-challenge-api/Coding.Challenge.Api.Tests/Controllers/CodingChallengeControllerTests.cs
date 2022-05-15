using Coding.Challenge.Api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Xunit;

namespace Coding.Challenge.Api.Tests.Controllers
{
    public class CodingChallengeControllerTests
    {
        [Fact]
        public void Get_OnInvoke_ReturnsExpectedMessage()
        {
            var controller = new CodingChallengeController();

            var result = controller.Get().Result as OkObjectResult;

            result.StatusCode.Should().Be((int)HttpStatusCode.OK);
            result.Value.Should().Be("Coding Challenge!");
        }
    }
}
