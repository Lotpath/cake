﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Cake.Common.Tools.MSBuild
{
    /// <summary>
    /// Contains functionality related to MSBuild settings.
    /// </summary>
    public static class MSBuildSettingsExtensions
    {
        /// <summary>
        /// Adds a MSBuild target to the configuration.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="target">The MSBuild target.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings WithTarget(this MSBuildSettings settings, string target)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            settings.Targets.Add(target);
            return settings;
        }

        /// <summary>
        /// Sets the tool version.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="version">The version.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings UseToolVersion(this MSBuildSettings settings, MSBuildToolVersion version)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            settings.ToolVersion = version;
            return settings;
        }

        /// <summary>
        /// Sets the platform target.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="target">The target.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings SetPlatformTarget(this MSBuildSettings settings, PlatformTarget target)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            settings.PlatformTarget = target;
            return settings;
        }

        /// <summary>
        /// Adds a property to the configuration.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="name">The property name.</param>
        /// <param name="values">The property values.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings WithProperty(this MSBuildSettings settings, string name, params string[] values)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            IList<string> currValue;
            currValue = new List<string>(
                settings.Properties.TryGetValue(name, out currValue) && currValue != null
                    ? currValue.Concat(values)
                    : values
                );
            
            settings.Properties[name] = currValue;
            return settings;
        }

        /// <summary>
        /// Sets the configuration.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings SetConfiguration(this MSBuildSettings settings, string configuration)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            settings.Configuration = configuration;
            return settings;
        }

        /// <summary>
        /// Sets the maximum CPU count.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="maxCpuCount">The maximum CPU count.</param>
        /// <returns>The same <see cref="MSBuildSettings"/> instance so that multiple calls can be chained.</returns>
        public static MSBuildSettings SetMaxCpuCount(this MSBuildSettings settings, int maxCpuCount)
        {
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }
            settings.MaxCpuCount = Math.Max(0, maxCpuCount);
            return settings;
        }
    }
}
