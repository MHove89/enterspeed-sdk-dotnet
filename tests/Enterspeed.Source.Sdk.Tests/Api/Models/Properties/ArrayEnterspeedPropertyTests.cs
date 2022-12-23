using System.Collections.Generic;
using System.Linq;
using Enterspeed.Source.Sdk.Api.Models.Properties;
using Xunit;

namespace Enterspeed.Source.Sdk.Tests.Api.Models.Properties
{
    public class ArrayEnterspeedPropertyTests
    {
        [Fact]
        public void TypeIs_Array()
        {
            var property = new ArrayEnterspeedProperty("test", new IEnterspeedProperty[0]);

            Assert.Equal("array", property.Type);
        }

        [Fact]
        public void NameIs_Equal()
        {
            var property = new ArrayEnterspeedProperty("test", new IEnterspeedProperty[0]);

            Assert.Equal("test", property.Name);
        }

        [Fact]
        public void ItemsAre_NotEmpty()
        {
            var property = new ArrayEnterspeedProperty(
                "test",
                new IEnterspeedProperty[] { new StringEnterspeedProperty("test", "value") });

            Assert.NotEmpty(property.Items);
        }

        [Fact]
        public void ItemsAre_NullAndThrowsException()
        {
            var property = new ArrayEnterspeedProperty("test", null);

            Assert.False(property.Validation.IsValid);
            Assert.Contains("Items assigned to ArrayEnterspeedProperty cannot be null", property.Validation.Errors.FirstOrDefault());
        }

        [Fact]
        public void ItemsHas_ValueAndDoesNotThrowException()
        {
            var property = new ArrayEnterspeedProperty("test", new List<IEnterspeedProperty>().ToArray());

            Assert.True(property.Validation.IsValid);
        }
    }
}