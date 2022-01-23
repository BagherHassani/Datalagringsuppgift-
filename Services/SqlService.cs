using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift1Datalagring.Data;
using uppgift1Datalagring.Models;

namespace uppgift1Datalagring.Services
{
   
   
    internal class SqlService 
    {
      
        private readonly SqlContext _context = new SqlContext();

        public int CreatAdress(Adress adress)
        {
            var _adress = _context.Adresses.Where(x => x.PostalCode == adress.PostalCode && x.StreetName == adress.StreetName).FirstOrDefault();
            if (_adress == null)
            {
                var adressEntity = new AdressEntity
                {
                    StreetName = adress.StreetName,
                    PostalCode = adress.PostalCode,
                    City = adress.City,
                    Country = adress.Country
                };

                _context.Adresses.Add(adressEntity);
                _context.SaveChanges();
                return adressEntity.Id;
            }
            return _adress.Id;
        }

        public int CreatArende (Arende arende)
        {
            var _arende = _context.Arendes.Where(x => x.Kund == arende.Kund).FirstOrDefault();

            if (_arende == null)
            {
                var arendeEntity = new ArendeEntity
                {
                  Kund = arende.Kund,
                  Rubrik = arende.Rubrik,
                  Beskrivning = arende.Beskrivning,
                  Datum = arende.Datum,
                  DatumChange = arende.DatumChange,
                  Status = arende.Status 
                };

                _context.Arendes.Add(arendeEntity);
                _context.SaveChanges();
              
            }
            return _arende.Id;
        }

        public int CreatCustomer(Customer customer)
        {
            var customerEntity = new CustomerEntity();
            var kund = _context.Customers.Where(x => x.Email == customer.Email).FirstOrDefault();

            if (kund == null)
            {
                
                
                customerEntity.Name = customer.Name;
                customerEntity.Email = customer.Email;
                customerEntity.Mobilenummer = customer.Mobilenummer;
                customerEntity.Telefonummer = customer.telefonummer;

                customerEntity.AdressId = CreatAdress(customer.Adress);
                //customerEntity.ArendeID = CreatArende(customer.Arende);

                _context.Customers.Add(customerEntity);
                _context.SaveChanges();
                //return customerEntity.Id;

                //_customer.Name = customer.Name;
                //_customer.Email = customer.Email;
                //_customer.Mobilenummer = customer.Mobilenummer;
                //_customer.Mobilenummer = customer.telefonummer;
                //_customer.Adress = CreatAdress(customer.Adress);

                //_context.Customers.Add(customerentityr);
                //_context.SaveChanges();
                //return customerEntity.Id;



            }
            return kund.Id;
        }


        public IEnumerable<ArendeEntity> GetAll()
        {

            return _context.Arendes;
        }

        public IEnumerable<CustomerEntity> GetAllCustomer ()
        {

            return _context.Customers;
        }



    }
   
}
