using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Repositories;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework;

public class EfCargoCaompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
{
    public EfCargoCaompanyDal(CargoContext context) : base(context)
    {
    }
}