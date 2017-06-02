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
        public virtual Product Get(int id)
        {
            Product product = null;
            ProductDO productDO = _DataContext.Product_Get(id).SingleOrDefault();
            if (productDO != null)
            {
                product = new Product();
                product.ProductID = productDO.ProductID;
                product.ProductName = productDO.ProductName;
                product.Picture = productDO.Picture;
                product.Price = productDO.Price;
            }
            return product;


        }
        public virtual List<Product> GetList()
        {
            List<Product> productList = new List<Product>();
            ISingleResult<ProductDO> productDOs = _DataContext.Product_GetList();
            foreach (var p in productDOs)
            {
                Product product = new Product();
                product.ProductID = productDO.ProductID;
                product.ProductName = productDO.ProductName;
                product.Picture = productDO.Picture;
                product.Price = productDO.Price;
                productList.Add(product);
            }
            return productList;


        }
        public virtual void Save(Product product)
        {
            if (product.ProductID == 0)
            {
                _DataContext.Product_InsertUpdate(null,product.ProductName, product.Picture, product.Price);
            }
            else
            {
                _DataContext.Product_InsertUpdate(product.ProductID, product.ProductName, product.Picture, product.Price);
            }


        }
    }