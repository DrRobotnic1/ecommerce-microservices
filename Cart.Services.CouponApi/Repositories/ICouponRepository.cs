using Cart.Services.CouponApi.Models;

namespace Cart.Services.CouponApi.Repositories
{
  public interface ICouponRepository
  {
    Task<IEnumerable<Coupon>> GetAllCouponsAsync();
    Task<Coupon> GetCouponByIdAsync(int id);
  }
}
