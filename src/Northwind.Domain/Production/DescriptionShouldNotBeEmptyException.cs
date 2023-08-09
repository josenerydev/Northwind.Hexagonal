namespace Northwind.Domain.Production
{
    public sealed class DescriptionShouldNotBeEmptyException : DomainException
    {
        internal DescriptionShouldNotBeEmptyException(string message)
            : base(message)
        {
        }
    }
}