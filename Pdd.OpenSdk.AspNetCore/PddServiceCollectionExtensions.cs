using System;
using Pdd.OpenSdk.AspNetCore;
using Pdd.OpenSdk.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PddServiceExtensions
    {

        /// <summary>
        /// 添加批多多服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        public static void AddPdd(this IServiceCollection services, Action<PddOptions> optionsAction = null)
        {
            if (optionsAction != null)
            {
                services.Configure(optionsAction);
            }
            services.AddSingleton<IPddService, PddService>();
        }
    }
}
