using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using YoutubeApi.Application.Interfaces.AutoMapper;
using IMapper = YoutubeApi.Application.Interfaces.AutoMapper.IMapper;

namespace YoutubeApi.Mapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, AutoMapper.Mapper>();

        }
    }
}

