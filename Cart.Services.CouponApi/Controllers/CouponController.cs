using Cart.Services.CouponApi.Data;
using Cart.Services.CouponApi.Models;
using Cart.Services.CouponApi.Models.Dto;
using Cart.Services.CouponApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cart.Services.CouponApi.Controllers
{

  public class CouponController : BaseController
  {
    private readonly CouponService _couponService;

    public CouponController(CouponService couponService)
    {
      _couponService = couponService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
      var coupons = await _couponService.GetAllCouponsAsync();
      return Ok(coupons);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
      var coupon = await _couponService.GetCouponByIdAsync(id);
      if (coupon == null)
      {
        return NotFound();
      }
      return Ok(coupon);
    }
    [HttpPost]
    public async Task<IActionResult> AddAsync(CouponDto request)
    {
      if (request == null)
        return null;
      await _couponService.AddCouponAsync(request);
      return Ok("successfully created");
    }

  }
}
