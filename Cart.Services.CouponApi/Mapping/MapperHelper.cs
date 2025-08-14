using AutoMapper;
using Cart.Services.CouponApi.Models;
using Cart.Services.CouponApi.Models.Dto;

namespace Cart.Services.CouponApi.Mapping
{
  public class MapperHelper:Profile
  {
    public MapperHelper()
    {

      CreateMap<Coupon, CouponDto>().ReverseMap();
    }
  }
}
