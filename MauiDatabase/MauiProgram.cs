using Microsoft.Extensions.Logging;
using MauiDatabase.Data;
using Microsoft.EntityFrameworkCore;
using MauiDatabase.Repositories;
using MauiDatabase.Shared;

namespace MauiDatabase;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
        builder.Services.AddDbContext<AppDbContext>(a => a.UseSqlite(ProjectConfig.DatabasePath));

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		builder.Services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
		builder.Services.AddSingleton(typeof(INoteRepository), typeof(NoteRepository));

		return builder.Build();
	}
}
