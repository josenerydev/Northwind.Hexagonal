namespace Northwind.Domain.Production
{
    public sealed class NameShouldNotBeEmptyException : DomainException
    {
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        {
        }
    }
}