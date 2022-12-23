namespace Enterspeed.Source.Sdk.Api.Models.Properties
{
    public abstract class BaseEnterspeedProperty
    {
        public PropertyValidation Validation { get; private set; }

        public BaseEnterspeedProperty()
        {
            Validation = new PropertyValidation();
        }
    }
}
