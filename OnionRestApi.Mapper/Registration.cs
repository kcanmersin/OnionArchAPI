using Microsoft.Extensions.DependencyInjection;
using OnionRestApi.Application.Interfaces.AutoMapper;

namespace OnionRestApi.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
