﻿using System;
using System.Threading.Tasks;
using Abp.Dependency;

namespace Abp.MqMessages.MqHandlers
{
    public abstract class AbpMqHandlerBase : AbpServiceBase, ITransientDependency
    {
        public AbpMqHandlerBase(string localizationSourceName)
        {
            LocalizationSourceName = localizationSourceName;
        }

        protected async Task<bool> IsTrueSetting(string settingKey)
        {
            return string.Equals("true", await SettingManager.GetSettingValueForApplicationAsync(settingKey), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}