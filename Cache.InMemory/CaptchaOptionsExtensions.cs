﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace WonderfulCaptcha.Cache.InMemory;
public static class CaptchaOptionsExtensions
{
    public static IWonderfulCaptchaBuilder UseInMemoryCacheProvider(this IWonderfulCaptchaBuilder builder, IServiceCollection services)
    {
        services.TryAddScoped<ICacheProvider, InMemoryCacheProvider>();
        return builder;
    }
}
