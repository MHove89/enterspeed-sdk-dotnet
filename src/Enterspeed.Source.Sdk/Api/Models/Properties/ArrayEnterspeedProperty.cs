using System;

namespace Enterspeed.Source.Sdk.Api.Models.Properties
{
    public class ArrayEnterspeedProperty : IEnterspeedProperty
    {
        public string Name { get; }
        public string Type => "array";
        public IEnterspeedProperty[] Items { get; set; }

        public ArrayEnterspeedProperty(string name, IEnterspeedProperty[] items)
        {
            Name = name;
            Items = items;
            Validate(items);
        }

        private void Validate(IEnterspeedProperty[] items)
        {
            if (items == null)
            {
                throw new ArgumentException("Items assigned to ArrayEnterspeedProperty cannot be null");
            }
        }
    }
}
