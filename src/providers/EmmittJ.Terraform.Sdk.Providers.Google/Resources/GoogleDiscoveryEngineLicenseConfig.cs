using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for end_date in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformProperty<double>? Day
    {
        get => GetProperty<TerraformProperty<double>>("day");
        set => WithProperty("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformProperty<double>? Month
    {
        get => GetProperty<TerraformProperty<double>>("month");
        set => WithProperty("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformProperty<double>? Year
    {
        get => GetProperty<TerraformProperty<double>>("year");
        set => WithProperty("year", value);
    }

}

/// <summary>
/// Block type for start_date in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformProperty<double>? Day
    {
        get => GetProperty<TerraformProperty<double>>("day");
        set => WithProperty("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformProperty<double>? Month
    {
        get => GetProperty<TerraformProperty<double>>("month");
        set => WithProperty("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformProperty<double>? Year
    {
        get => GetProperty<TerraformProperty<double>>("year");
        set => WithProperty("year", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_discovery_engine_license_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineLicenseConfig : TerraformResource
{
    public GoogleDiscoveryEngineLicenseConfig(string name) : base("google_discovery_engine_license_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    public TerraformProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    public TerraformProperty<bool>? FreeTrial
    {
        get => GetProperty<TerraformProperty<bool>>("free_trial");
        set => this.WithProperty("free_trial", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The unique id of the license config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigId is required")]
    public required TerraformProperty<string> LicenseConfigId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("license_config_id");
        set => this.WithProperty("license_config_id", value);
    }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCount is required")]
    public required TerraformProperty<double> LicenseCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("license_count");
        set => this.WithProperty("license_count", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTerm is required")]
    public required TerraformProperty<string> SubscriptionTerm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subscription_term");
        set => this.WithProperty("subscription_term", value);
    }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTier is required")]
    public required TerraformProperty<string> SubscriptionTier
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subscription_tier");
        set => this.WithProperty("subscription_tier", value);
    }

    /// <summary>
    /// Block for end_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public List<GoogleDiscoveryEngineLicenseConfigEndDateBlock>? EndDate
    {
        get => GetProperty<List<GoogleDiscoveryEngineLicenseConfigEndDateBlock>>("end_date");
        set => this.WithProperty("end_date", value);
    }

    /// <summary>
    /// Block for start_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public List<GoogleDiscoveryEngineLicenseConfigStartDateBlock>? StartDate
    {
        get => GetProperty<List<GoogleDiscoveryEngineLicenseConfigStartDateBlock>>("start_date");
        set => this.WithProperty("start_date", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineLicenseConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDiscoveryEngineLicenseConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
