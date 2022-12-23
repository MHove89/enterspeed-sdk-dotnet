using System;

namespace Enterspeed.Source.Sdk.Api.Models.Properties
{
    public class StringEnterspeedProperty : BaseEnterspeedProperty, IEnterspeedProperty
    {
        public string Name { get; }
        public string Type => "string";
        public string Value { get; }

        public StringEnterspeedProperty(string name, string value)
        {
            Name = name;
            Value = value;
            Validate(value);
        }

        public StringEnterspeedProperty(string value)
        {
            Value = value;
            Validate(value);
        }

        private void Validate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Validation.IsValid = false;
                Validation.Errors.Add("Value of StringEnterspeedProperty cannot be null");
            }
        }
    }
}
