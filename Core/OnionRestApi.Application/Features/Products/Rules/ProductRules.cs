using OnionRestApi.Application.Bases;
using OnionRestApi.Application.Features.Products.Exceptions;
using OnionRestApi.Domain.Entities;

namespace OnionRestApi.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        {
            if (products.Any(x=>x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
