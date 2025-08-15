using Cart.Services.CouponApi.Data;
using Cart.Services.CouponApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Cart.Services.CouponApi.Repositories
{
  public class CouponRepository : ICouponRepository
  {
    
    private readonly CouponDbContext _context;

    public CouponRepository(CouponDbContext context)
    {
      _context = context;
    }

    public async Task<Coupon> AddAsync(Coupon coupon)
    {
      await _context.AddAsync(coupon);
      _context.SaveChanges();
      return coupon;
    }

    public async Task<IEnumerable<Coupon>> GetAllCouponsAsync()
    {
      return await _context.Coupons.ToListAsync();
    }

    public async Task<Coupon> GetCouponByIdAsync(int id)
    {
      return await _context.Coupons.FirstOrDefaultAsync(c => c.CouponId == id);
    }
  }
}
