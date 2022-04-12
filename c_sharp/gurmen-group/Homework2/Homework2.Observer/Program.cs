using Homework2.Observer.Obsorver;
using Homework2.Observer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddSingleton<OrderContext>(sp =>
{
    OrderContext context = new();

    context.RegisterObserver(new OrderCreatedSendMail());
    context.RegisterObserver(new OrderCreatedSendSms());

    return context;

});

var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
