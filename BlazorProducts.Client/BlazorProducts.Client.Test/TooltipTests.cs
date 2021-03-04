using BlazorProducts.Client.Shared;
using Bunit;
using System.Threading.Tasks;
using Xunit;

namespace BlazorProducts.Client.Test
{
    public class TooltipTests
    {
        [Fact]
        //public async Task ItShouldDisplayTheTooltipText()
        //{
        //    TestHost host = new TestHost();

        //    var title = "Test";
        //    var parameters = new Dictionary<string, object>() { { "Title", title } };
        //    var component = host.AddComponent<SurveyPrompt>(parameters);
        //    Assert.Equal(title, component.Find("strong").InnerText);

        //    //var someValue = "Esto es una prueba";
        //    ////var parameters = new Dictionary<string, object>() { { "Text", someValue }, {"ChildContent", "app" } };
        //    //var parameters = new Dictionary<string, object>() { { "Text", someValue }};
        //    //var component = host.AddComponent<Tooltip>(parameters);

        //    ////Assert.NotNull(component.Find($"#span-text"));

        //    //Assert.Equal(someValue, component.Find($"#span-text").InnerText);
        //}

        public async Task ItShouldDisplayTheTooltipText()
        {
            var someValue = "Esto es una prueba";

            using var ctx = new TestContext();

            var renderedComponent = ctx.RenderComponent<Tooltip>(
                builder =>
                {
                    builder.Add(c => c.Text, someValue);
                });

            Assert.Equal(someValue, renderedComponent.Find($"#span-text").TextContent);
        }
    }
}