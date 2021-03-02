using System;
using System.ComponentModel.DataAnnotations;
using Google.Cloud.Firestore;


namespace BlazorNorthwind.Shared.Models
{
    [FirestoreData]
    public class Employee
    {
        public string EmployeeId { get; set; }
        public DateTime date { get; set; }
        [FirestoreProperty]
        [Display(Name = "نام")]
        public string EmployeeName { get; set; }
        [FirestoreProperty]
        public string CityName { get; set; }
        [FirestoreProperty]
        public string Designation { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
    }
}
