using System;
using Google.Cloud.Firestore;

namespace BlazorNorthwind.Shared.Models
{
    [FirestoreData]
    public class Cities
    {
        public string CityName { get; set; }
    }
}
