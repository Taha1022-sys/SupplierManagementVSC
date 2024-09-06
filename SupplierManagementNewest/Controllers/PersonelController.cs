using Microsoft.AspNetCore.Mvc;
using SupplierManagement.Context;
using SupplierManagementNewest.Entities;

namespace SupplierManagementNewest.Controllers
{
    public class PersonelController
    {
        
        private readonly SMContext _smContext;

        public PersonelController(SMContext context)
        {

            _smContext = context;
        }

      

        [HttpGet("getAllPersonelList")]
        public List<tb_Personel> getAllPersonelList()
        {
            var smlist = _smContext.tb_Personel.ToList();

            return smlist;


        }
        [HttpPost("savePersonel")]
        public void savePersonel(string name,string Surname, string address)
        {
            try
            {
                var newPersonel = new tb_Personel();
                newPersonel.Name = name;
                newPersonel.SurName = Surname;
                newPersonel.Address = address;
                _smContext.Add(newPersonel);
                _smContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}


