using AutoMapper;
using Cart.Services.CouponApi.Models;
using Cart.Services.CouponApi.Models.Dto;

namespace Cart.Services.CouponApi.Mapping
{
  public class MapperConfig:Profile
  {
    public MapperConfig()
    {
      
      CreateMap<Coupon, CouponDto>().ReverseMap();
  }
}
