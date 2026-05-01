using FraudDetection.Api.Config;
using FraudDetection.Api.Endpoints;
using FraudDetection.Ioc;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureOpenApi();
builder.Services.ConfigureOptions<ConfigureKestrelOptions>();

var app = builder.Build();

app.AddFraudEndpoints();

app.MapOpenApi();
app.MapScalarApiReference();

app.UseHttpsRedirection();

app.Run();