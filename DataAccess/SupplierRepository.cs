using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class SupplierRepository
    {
        public List<Supplier> GetAll()
        {
            var list = new List<Supplier>();

            try
            {
                using (var db = new NorthwindEntities())
                {
                    list = db.Suppliers.ToList();
                }
            }
            catch
            {
                list = new List<Supplier>() { };
            }

            return list;
        }

        public bool Find(Supplier supplier)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Supplier found = db.Suppliers.FirstOrDefault(s => s.SupplierID == supplier.SupplierID);
                    if (found != null)
                    {
                        supplier.CompanyName = found.CompanyName;
                        supplier.ContactName = found.ContactName;
                        supplier.ContactName = found.ContactTitle;
                        supplier.Address = found.Address;
                        supplier.City = found.City;
                        supplier.Region = found.Region;
                        supplier.PostalCode = found.PostalCode;
                        supplier.Country = found.Country;
                        supplier.Phone = found.Phone;
                        supplier.Fax = found.Fax;
                        supplier.HomePage = found.HomePage;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        public bool Insert(Supplier supplier)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Supplier supplier)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Supplier found = db.Suppliers.FirstOrDefault();
                    if (found != null)
                    {
                        found.CompanyName = supplier.CompanyName;
                        found.ContactName = supplier.ContactName;
                        found.ContactName = supplier.ContactTitle;
                        found.Address = supplier.Address;
                        found.City = supplier.City;
                        found.Region = supplier.Region;
                        found.PostalCode = supplier.PostalCode;
                        found.Country = supplier.Country;
                        found.Phone = supplier.Phone;
                        found.Fax = supplier.Fax;
                        found.HomePage = supplier.HomePage;
                        db.SaveChanges();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int supplierId)
        {
            try
            {
                using (var db = new NorthwindEntities())
                {
                    Supplier found = db.Suppliers.FirstOrDefault();
                    if (found != null)
                    {
                        db.Suppliers.Remove(found);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
