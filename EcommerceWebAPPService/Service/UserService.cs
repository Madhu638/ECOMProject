using EcommerceWebAPPService.Model;
using EcommerceWebAPPService.Model.Context;
using EcommerceWebAPPService.Service;
namespace EcommerceWebAPPService.Service
{
    public class UserService : IECOMService<UserDetails>
    {
        private EcomContext _context;
        public UserService(EcomContext context)
        {
            _context = context;
        }
        public ResponseModel DeleteItem(int UserId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                UserDetails _temp = GetDetailsById(UserId);
                if (_temp != null)
                {
                    _context.Remove(_temp);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "User Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "User Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public UserDetails GetDetailsById(int UserId)
        {
            UserDetails user;
            try
            {
                user = _context.Find<UserDetails>(UserId);
            }
            catch (Exception)
            {
                throw;
            }
            return user;
        }

        public List<UserDetails> GetAllList()
        {
            List<UserDetails> userList;
            try
            {
                userList = _context.Set<UserDetails>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return userList;
        }

        public ResponseModel SaveItem(UserDetails userModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                UserDetails _temp = GetDetailsById(userModel.Id);
                if (_temp != null)
                {
                    _temp.FirstName = userModel.FirstName;
                    _temp.LastName = userModel.LastName;
                    _temp.email = userModel.email;
                    _temp.Role = userModel.Role;
                    _context.Update(_temp);
                    model.Messsage = "Product Update Successfully";
                }
                else
                {
                    _context.Add(userModel);
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