using System.Collections.Generic;

namespace Enterspeed.Source.Sdk.Api.Models
{
    public class PropertyValidation
    {
        public PropertyValidation()
        {
            IsValid = true;
            Errors = new List<string>();
        }

        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
