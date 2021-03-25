using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {    
        public static string BrandAdded = "Brand registration is successful";
        public static string BrandUpdated = "Brand update process is successful";
        public static string BrandDeleted = "Brand deletion successful";
        public static string BrandAddError = "The brand you want to add already exists. Enter a different brand.";


        public static string ColorAdded = "Color registration is successful";
        public static string ColorUpdated = "Color update process is successful";
        public static string ColorDeleted = "Color deletion successful";
        public static string ColorAddError = "The color you want to add already exists. Enter a different brand.";


        public static string CarAdded = "Car registration is successful";
        public static string CarDeleted = "Car deletion successful";
        public static string CarUpdated = "Car update process is successful";
        public static string CarAddError = "Licanse plate must be more then 2 characters";
        public static string LicancePlateExxistError = "This lisance plate exist already on the system.";

        public static string UserAdded = "User registration is successful";
        public static string UserUpdated = "User update process is successful";
        public static string UserDeleted = "User deletion successful";


        public static string CustomerAdded = "Customer registration is successful";
        public static string CustomerUpdated = "Customer update process is successful";
        public static string CustomerDeleted = "Customer deletion successful";


        public static string RentalAdded = "The car rental process was completed successfully.";
        public static string RentalDeleted = "Car rental has been canceled.";
        public static string RentalUpdated = "Car rental process has been updated.";
        public static string RentalFailedAddOrUpdate = "You cannot rent this car as it has not yet been delivered.";
        public static string RentalReturned = "The vehicle you rented has been delivered.";
        
    }
}
