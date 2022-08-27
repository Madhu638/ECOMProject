using EcommerceWebAPPService.Model;
using EcommerceWebAPPService.Model.Context;
using EcommerceWebAPPService.Service;

namespace EcommerceWebAPPService.ContextClass
{
    public class ProductService : IECOMService<Product>
    {
        private EcomContext _context;
        public ProductService(EcomContext context)
        {
            _context = context;
        }
        public ResponseModel DeleteItem(int productID)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Product _temp = GetDetailsById(productID);
                if (_temp != null)
                {
                    _context.Remove(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Product Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Employee Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public Product GetDetailsById(int prodId)
        {
            Product prod;
            try
            {
                prod = _context.Find<Product>(prodId);
            }
            catch (Exception)
            {
                throw;
            }
            return prod;
        }

        public List<Product> GetAllList()
        {
            List<Product> prodList;
            try
            {
                prodList = _context.Set<Product>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return prodList;
        }

        public ResponseModel SaveItem(Product productModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Product _temp = GetDetailsById(productModel.ProductId);
                if (_temp != null)
                {
                    _temp.ProductId = productModel.ProductId;
                    _temp.ProdDetails = productModel.ProdDetails;
                    _temp.ProdName = productModel.ProdName;
                    _temp.Title = productModel.Title;
                    _context.Update(_temp);
                    model.Messsage = "Product Update Successfully";
                }
                else
                {
                    _context.Add(productModel);
                    model.Messsage = "product Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

    }
}
