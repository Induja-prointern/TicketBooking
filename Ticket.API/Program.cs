using Microsoft.EntityFrameworkCore;
using Ticket.Repositories;
using Ticket.Repositories.Implementation;
using Ticket.Repositories.Interface;
using Ticket.Services;
using Ticket.Services.Implementation;
using Ticket.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IBusService, BusService>();
builder.Services.AddTransient<IBusRepositary, BusRepositary>();
builder.Services.AddTransient<IPaymentRepositary, PaymentRepositary>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddTransient<ITravelTicketRepositary, TravelTicketRepositary>();
builder.Services.AddTransient<ITravelTicketService, TravelTicketService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<IBookingRepositary, BookingRepositary>();
builder.Services.AddTransient<IUserRepositary, UserRepositary>();
builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddAutoMapper(typeof(AutoMapping));
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TicketCs"), b => b.MigrationsAssembly("Ticket.Repositories")));


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
