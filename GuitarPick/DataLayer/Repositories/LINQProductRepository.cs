using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.Repositories
{
    public class LINQProductRepository : IProductRepository
    {
        private GuitarPickDBDataContext _DataContext = new GuitarPickDBDataContext();
        public Product Get(int id)
        {
            Product product = null;
            ProductDO productDO = _DataContext.Product_Get(id).SingleOrDefault();
            if (productDO != null)
            {
                product = new Product();
                product.ProductID = productDO.ProductID;
                product.ProductName = productDO.ProductName;
                product.Description = productDO.Description;
                product.Price = productDO.Price;
            }
            return product;
        }
        public List<Product> GetList()
        {
            List<Product> productList = new List<Product>();
            ISingleResult<ProductDO> productDOs = _DataContext.Product_GetList();
            foreach (var p in productDOs)
            {
                Product product = new Product();
                product.ProductID = p.ProductID;
                product.ProductName = p.ProductName;
                product.Description = p.Description;
                product.Price = p.Price;
                productList.Add(product);
            }
            return productList;
        }
        public void Save(Product product)
        {
            if (product.ProductID == 0)
            {
                _DataContext.Product_InsertUpdate(null, product.ProductName, product.Description, product.Price);
            }
            else
            {
                _DataContext.Product_InsertUpdate(product.ProductID, product.ProductName, product.Description, product.Price);
            }
        }

        public Product GetProductName(int id)
        {
            Product product = null;
            ProductDO productDO = _DataContext.Product_GetProductName(id).SingleOrDefault();
            if (productDO != null)
            {
                product = new Product();
                product.ProductID = productDO.ProductID;
                product.ProductName = productDO.ProductName;
                product.Description = productDO.Description;
                product.Price = productDO.Price;
            }
            return product;
        }
    }
}