using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalRApi.Hubs
{
    public class SignalRHub:Hub
    {
        //    private readonly ICategoryService _categoryService;
        //    private readonly IProductService _productService;
        //    private readonly IOrderService _orderService;
        //    private readonly IMoneyCaseService _moneyCaseService;
        //    private readonly IMenuTableService _menuTableService;
        //    private readonly IBookingService _bookingService;
        //    private readonly INotificationService _notificationService;
        //    public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
        //    {
        //        _categoryService = categoryService;
        //        _productService = productService;
        //        _orderService = orderService;
        //        _moneyCaseService = moneyCaseService;
        //        _menuTableService = menuTableService;
        //        _bookingService = bookingService;
        //        _notificationService = notificationService;
        //    }


        SignalRContext context = new SignalRContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();

            await Clients.All.SendAsync("ReceiveCategoryCount", value);

        }



    }
}
