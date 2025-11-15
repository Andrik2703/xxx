using System.Collections.Generic;

using DataAccess;

namespace ApplicationLogic
{
    public class SupplierManager
    {
        private int id;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string phone;
        private string fax;
        private string homePage;

        public int Id { get { return this.id; } }
        public string CompanyName { get { return this.companyName; } }
        public string ContactName { get { return this.contactName; } }
        public string ContactTitle { get { return this.contactTitle; } }
        public string Address { get { return this.address; } }
        public string City { get { return this.city; } }
        public string Region { get { return this.region; } }
        public string PostalCode { get { return this.postalCode; } }
        public string Country { get { return this.country; } }
        public string Phone { get { return this.phone; } }
        public string Fax { get { return this.fax; } }
        public string HomePage { get { return this.homePage; } }

        public SupplierManager(int id)
        {
            this.id = id;
            this.companyName = "";
            this.contactName = "";
            this.contactTitle = "";
            this.address = "";
            this.city = "";
            this.region = "";
            this.postalCode = "";
            this.country = "";
            this.phone = "";
            this.fax = "";
            this.homePage = "";
        }

        public SupplierManager(
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax,
            string homePage
        )
        {
            this.id = 0;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
            this.homePage = homePage;
        }

        public SupplierManager(
            int id,
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax,
            string homePage
        )
        {
            this.id = id;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = address;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
            this.homePage = homePage;
        }

        public List<SupplierManager> GetAll()
        {
            List<Supplier> suppliersData = new SupplierRepository().GetAll();
            List<SupplierManager> suppliers = new List<SupplierManager>() { };
            foreach (Supplier data in suppliersData)
            {
                suppliers.Add(new SupplierManager(
                    data.SupplierID,
                    data.CompanyName,
                    data.ContactName,
                    data.ContactTitle,
                    data.Address,
                    data.City,
                    data.Region,
                    data.PostalCode,
                    data.Country,
                    data.Phone,
                    data.Fax,
                    data.HomePage
                ));
            }
            return suppliers;
        }

        public bool Find()
        {
            Supplier supplier = new Supplier() { SupplierID = this.id };
            bool found = new SupplierRepository().Find(supplier);
            if (found)
            {
                this.companyName = supplier.CompanyName;
                this.contactName = supplier.ContactName;
                this.contactTitle = supplier.ContactTitle;
                this.address = supplier.Address;
                this.city = supplier.City;
                this.region = supplier.Region;
                this.postalCode = supplier.PostalCode;
                this.country = supplier.Country;
                this.phone = supplier.Phone;
                this.fax = supplier.Fax;
                this.homePage = supplier.HomePage;
            }
            return found;
        }

        public bool Insert()
        {
            Supplier supplier = new Supplier()
            {
                CompanyName = this.CompanyName,
                ContactName = this.ContactName,
                ContactTitle = this.ContactTitle,
                Address = this.Address,
                City = this.City,
                Region = this.Region,
                PostalCode = this.PostalCode,
                Country = this.Country,
                Phone = this.Phone,
                Fax = this.Fax,
                HomePage = this.HomePage,
            };
            return new SupplierRepository().Insert(supplier);
        }

        public bool Update()
        {
            Supplier supplier = new Supplier()
            {
                SupplierID = this.id,
                CompanyName = this.CompanyName,
                ContactName = this.ContactName,
                ContactTitle = this.ContactTitle,
                Address = this.Address,
                City = this.City,
                Region = this.Region,
                PostalCode = this.PostalCode,
                Country = this.Country,
                Phone = this.Phone,
                Fax = this.Fax,
                HomePage = this.HomePage,
            };
            return new SupplierRepository().Update(supplier);
        }

        public bool Delete()
        {
            return new SupplierRepository().Delete(this.id);
        }
    }
}
