using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAndStatic
{
    public class Address
    {
        public string City { get; set; }

        public string Street {  get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string this[string key]
        {
            get
            {
                if (string.Equals(key, nameof(City), StringComparison.OrdinalIgnoreCase))
                {
                    return City;
                }
                else if (string.Equals(key, nameof(Street), StringComparison.OrdinalIgnoreCase))
                {
                    return Street;
                }
                else if (string.Equals(key, nameof(PostalCode), StringComparison.OrdinalIgnoreCase))
                {
                    return PostalCode;
                }
                else if (string.Equals(key, nameof(Country), StringComparison.OrdinalIgnoreCase))
                {
                    return Country;
                }
                else
                {
                    throw new ArgumentException($"Key '{key}' does not exist.", nameof(key));
                }
            }
        }
    }
}
