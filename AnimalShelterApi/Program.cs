using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

//api thing
var MyAllowSpecificOrigins = "_MyAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(
										builder => 
										{ 
											builder.AllowAnyOrigin()
											.AllowAnyMethod()
											.AllowAnyHeader();
										});
});

builder.Services.AddControllers();

builder.Services.AddDbContext<AnimalShelterApiContext>(
									dbContextOptions => dbContextOptions
									.UseMySql(
										builder.Configuration["ConnectionStrings:DefaultConnection"],
										ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
									)
								)
							);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

builder.Services.AddApiVersioning(opt => 
																		{
																			opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
																			opt.AssumeDefaultVersionWhenUnspecified = true;
																			opt.ReportApiVersions = true;
																			opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(), new HeaderApiVersionReader("x-api-version"), new MediaTypeApiVersionReader("x-api-version"));
																		});

builder.Services.AddVersionedApiExplorer(setup => 
{
		setup.GroupNameFormat = "'v'VVV";
		setup.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(options =>
	{
		foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions.Reverse())
		{
			options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
				description.GroupName.ToUpperInvariant());
		}
	});
}
else
{
	app.UseHttpsRedirection();
}

app.UseStaticFiles();
//app.usecors

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
