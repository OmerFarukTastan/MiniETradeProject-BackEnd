using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "Maintenance is started";
        public static string ProductsListed = "Products are listed";
        public static string ProductCountOfCategoryError = "Max number of products in one category cannot be higher than 10";
        public static string ProductNameAlreadyExists = "Product name is exist";
        public static string CategoryLimitExceded = "Category limit is exceded";
        public static string AuthorizationDenied = "You have no authorization";
        public static string UserRegistered = "User is registered successfully";
        public static string UserNotFound = "User have not found";
        public static string PasswordError  = "Wrong password";
        public static string SuccessfulLogin = "Login is successfully ";
        public static string UserAlreadyExists = "User is already exists";
        public static string AccessTokenCreated = "Access token is created";
    }
}
