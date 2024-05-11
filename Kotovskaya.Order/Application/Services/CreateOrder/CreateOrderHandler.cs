using MediatR;

namespace Kotovskaya.Order.Controllers.Order.Controllers.Categories.Application.Services.GetCategoryItems.Order.Application.Services.CreateOrder;

public class CreateOrderHandler : IRequestHandler<CreateOrderRequest, string>
{
    public async Task<string> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine(123);
        await Task.Delay(200);
        return "123";
    }
}