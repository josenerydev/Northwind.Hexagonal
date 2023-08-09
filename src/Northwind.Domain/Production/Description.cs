namespace Northwind.Domain.Production
{
    public sealed class Description
    {
        private string _text;

        public Description(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new NameShouldNotBeEmptyException("The 'Description' field is required");

            _text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public static implicit operator Description(string text)
        {
            return new Description(text);
        }

        public static implicit operator string(Description description)
        {
            return description._text;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((Description)obj)._text == _text;
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }
    }
}