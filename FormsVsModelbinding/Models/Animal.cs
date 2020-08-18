using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormsVsModelbinding.Models
{
    public class Animal
    {
        /// <summary>
        /// Pet lisence ID
        /// </summary>
        public string AnimalId { get; set; }
        /// <summary>
        /// Pets name
        /// </summary>
        public string AnimalName { get; set; }
        /// <summary>
        /// Type of animal pet is
        /// </summary>
        public string AnimalSpecies { get; set; }
        /// <summary>
        /// Pet owners full name (ex. John doe)
        /// </summary>
        public string OwnerName { get; set; }
        /// <summary>
        /// Pet owners phone number
        /// </summary>
        public string OwnerPhoneNumber { get; set; }
    }
}
