using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SupplierManagement.Context;
using SupplierManagementNewest.Entities;
using static SupplierManagementNewest.Controllers.SupplierController;

namespace SupplierManagementNewest.Controllers
{
    public class SupplierController : Controller
    {
        private readonly SMContext _smContext;

        public SupplierController(SMContext context)
        {

            _smContext = context;
        }

        public IActionResult Index()
        {
            try
            {
                if (_smContext.Database.CanConnect())
                {

                }
                var smlist = _smContext.tb_Suppliers.ToList();

            }
            catch (Exception ex)
            {

                throw;
            }
            return View();

        }

        [HttpGet("getAllSupplierList")]
        public List<tb_Supplier> getAllSupplierList()
        {
            var smlist = _smContext.tb_Suppliers.ToList();

            return smlist;

        }
        [HttpPost("saveSupplier")]
        public void saveSupplier(string name, string address)
        {
            try
            {
                var newSupplier = new tb_Supplier();
                newSupplier.Name = name;
                newSupplier.Address = address;
                _smContext.Add(newSupplier);
                _smContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }

        }
        [HttpGet("GetSupplierById/{id:int}")]
        public tb_Supplier getSupplierById(int id)
        {
            var supplier = _smContext.tb_Suppliers.FirstOrDefault(x => x.SupplierId == id);
            return supplier;

        }

        [HttpPost("updateSupplier")]
      
        public void updateSupplier([FromBody] updateData updateData)
        {

            try
            {
                var existingSupplier = _smContext.tb_Suppliers.FirstOrDefault(x => x.SupplierId == updateData.SupplierId);
                if (existingSupplier != null)
                {
                    existingSupplier.Name = updateData.Name;
                    existingSupplier.Address = updateData.Address;
                }
                _smContext.Update(existingSupplier);
                _smContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public class updateData
        {
            public int SupplierId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
        [HttpDelete("deleteSupplier")]

        public void deleteSupplier(int supplierId)
        {
            try
            {
                var existingSupplier = _smContext.tb_Suppliers.FirstOrDefault(x => x.SupplierId == supplierId);
                if (existingSupplier != null)
                {
                    _smContext.Remove(existingSupplier);
                    _smContext.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw;
            }



        }
    }

}