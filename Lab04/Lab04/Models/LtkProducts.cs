using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Lab04.Models
{
    public class Products
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
    }

    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
        Products GetProductById(string id);
        void AddProduct(Products product);
        void UpdateProduct(Products product);
        void DeleteProduct(string id);
    }


    public class XmlProductRepository : IProductRepository
    {
        private readonly string _xmlFilePath;

        public XmlProductRepository(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            XDocument doc = XDocument.Load(_xmlFilePath);
            return doc.Descendants("Product")
                      .Select(p => new Products
                      {
                          ProductId = p.Element("ProductId")?.Value,
                          ProductName = p.Element("ProductName")?.Value,
                          Unit = p.Element("Unit")?.Value,
                          Price = decimal.TryParse(p.Element("Price")?.Value, out decimal price) ? price : 0
                      }).ToList();
        }

        public Products GetProductById(string productId)
        {
            XDocument doc = XDocument.Load(_xmlFilePath);
            var element = doc.Descendants("Product")
                             .FirstOrDefault(p => p.Element("ProductId")?.Value == productId);

            if (element == null)
                return null;

            return new Products
            {
                ProductId = element.Element("ProductId")?.Value,
                ProductName = element.Element("ProductName")?.Value,
                Unit = element.Element("Unit")?.Value,
                Price = decimal.TryParse(element.Element("Price")?.Value, out decimal price) ? price : 0
            };
        }

        public void AddProduct(Products product)
        {
            XDocument doc = XDocument.Load(_xmlFilePath);
            XElement newProduct = new XElement("Product",
                new XElement("ProductId", product.ProductId),
                new XElement("ProductName", product.ProductName),
                new XElement("Unit", product.Unit),
                new XElement("Price", product.Price)
            );

            doc.Element("Products")?.Add(newProduct);
            doc.Save(_xmlFilePath);
        }

        public void UpdateProduct(Products product)
        {
            XDocument doc = XDocument.Load(_xmlFilePath);
            var element = doc.Descendants("Product")
                             .FirstOrDefault(p => p.Element("ProductId")?.Value == product.ProductId);

            if (element != null)
            {
                element.Element("ProductName")?.SetValue(product.ProductName);
                element.Element("Unit")?.SetValue(product.Unit);
                element.Element("Price")?.SetValue(product.Price);
                doc.Save(_xmlFilePath);
            }
        }

        public void DeleteProduct(string productId)
        {
            XDocument doc = XDocument.Load(_xmlFilePath);
            var element = doc.Descendants("Product")
                             .FirstOrDefault(p => p.Element("ProductId")?.Value == productId);

            if (element != null)
            {
                element.Remove();
                doc.Save(_xmlFilePath);
            }
        }
    }
}
