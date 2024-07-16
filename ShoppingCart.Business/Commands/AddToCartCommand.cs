using ShoppingCart.Business.Models;
using ShoppingCart.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Business.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly Product _product;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository
            ,IProductRepository productRepository
            ,Product product)
        {
            _product = product;
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }
        public bool CanExecute()
        {
            if (_product == null) return false;

            return _productRepository.GetStockFor(_product.ArticleId) > 0;
        }

        public void Execute()
        {
            if (_product == null) return;

            _productRepository.DecreaseStockBy(_product.ArticleId, 1);

            _shoppingCartRepository.Add(_product);

        }

        public void Undo()
        {
            if (_product == null) return;

            var item = _shoppingCartRepository.Get(_product.ArticleId);

            _productRepository.IncreaseStockBy(_product.ArticleId, item.Quantity);

            _shoppingCartRepository.RemoveAll(_product.ArticleId);
        }
    }
}
