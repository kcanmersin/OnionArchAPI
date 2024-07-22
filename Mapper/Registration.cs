using Microsoft.Extensions.DependencyInjection;
using Api.Application.Interfaces.AutoMapper;

namespace Api.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();
        }
    }
}
