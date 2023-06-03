﻿using System;

namespace TinfoilWebServer.Settings.ConfigModels;

/// <summary>
/// Model of the JSON settings automatically deserialized by ASP.NET configuration system
/// </summary>
public class AppSettingsModel
{
    public string[]? ServedDirectories { get; set; }

    public bool? StripDirectoryNames { get; set; }

    public bool? ServeEmptyDirectories { get; set; } = false;

    public string[]? AllowedExt { get; set; }

    public string? MessageOfTheDay { get; set; }

    public string[]? ExtraRepositories { get; set; }

    public CacheExpirationSettingsModel? CacheExpiration { get; set; }

    public AuthenticationSettingsModel? Authentication { get; set; }
}

public class CacheExpirationSettingsModel
{
    public bool? Enabled { get; set; }

    public TimeSpan? ExpirationDelay { get; set; }
}

public class AuthenticationSettingsModel
{

    public bool? Enabled { get; set; } = true;

    public AllowedUserModel[]? Users { get; set; }

}

public class AllowedUserModel
{
    public string? Name { get; set; }

    public string? Pwd { get; set; }

}