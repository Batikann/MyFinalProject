using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product Added!";
        public static string ProductLenght = "Product Name Invalid!";
        public static string SystemOff = "System is Now Off!";
        public static string ProductCountOfCategoryError= "The number of products that can be added to this Category has been exceeded. ";
        public static string ProductNameUsed = "Product Name Previously Used";
        public static string CategoryLimitExceded= "Unable to add new product because category limit has been exceeded.";
        internal static string AuthorizationDenied= "you are not authorized ";
    }
}
