﻿#if !PORTABLE
using System.Configuration;
#else
using Microsoft.Extensions.Configuration;
#endif

namespace Serenity.Configuration
{
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.ComponentModel;
    using System;
    using System.Reflection;

    public class AppSettingsJsonConfigRepository : IConfigurationRepository
    {
#if PORTABLE
        public static IConfigurationRoot Configuration { get; private set; }
#endif

        public void Save(Type settingType, object value)
        {
            throw new NotImplementedException();
        }

        public object Load(Type settingType)
        {
            return LocalCache.Get("ApplicationSetting:" + settingType.FullName, TimeSpan.Zero, delegate()
            {
                var keyAttr = settingType.GetCustomAttribute<SettingKeyAttribute>();
                var key = keyAttr == null ? settingType.Name : keyAttr.Value;
#if PORTABLE
                var section = Configuration.GetSection("AppSettings");
                var setting = section[key];
#else
                var setting = ConfigurationManager.AppSettings[key].TrimToNull() );
#endif

                return JSON.ParseTolerant(setting.TrimToNull() ?? "{}", settingType);
            });
        }
    }
}