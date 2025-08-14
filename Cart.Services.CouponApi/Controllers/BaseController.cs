using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cart.Services.CouponApi.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public abstract class BaseController : ControllerBase
  {
  }
}
