using System.Collections.Generic;
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
            bool exceptionThrown = false;
            try
            {
                var property = new ArrayEnterspeedProperty("test", null);
            }
            catch (System.Exception)
            {
                exceptionThrown = true;
            }

            Assert.True(exceptionThrown);
        }

        [Fact]
        public void ItemsHas_ValueAndDoesNotThrowException()
        {
            bool exceptionThrown = false;
            try
            {
                var property = new ArrayEnterspeedProperty("test", new List<IEnterspeedProperty>().ToArray());
            }
            catch (System.Exception)
            {
                exceptionThrown = true;
            }

            Assert.False(exceptionThrown);
        }
    }
}