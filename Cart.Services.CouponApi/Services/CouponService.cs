using Cart.Services.CouponApi.Repositories;
using Cart.Services.CouponApi.Models;

namespace Cart.Services.CouponApi.Services
{
  public class CouponService
  {
    private readonly ICouponRepository _couponRepository;

    public CouponService(ICouponRepository couponRepository)
    {
      _couponRepository = couponRepository;
    }

    public async Task<IEnumerable<Coupon>> GetAllCouponsAsync()
    {
      return await _couponRepository.GetAllCouponsAsync();
    }

    public async Task<Coupon> GetCouponByIdAsync(int id)
    {
      return await _couponRepository.GetCouponByIdAsync(id);
    }
  }
}
