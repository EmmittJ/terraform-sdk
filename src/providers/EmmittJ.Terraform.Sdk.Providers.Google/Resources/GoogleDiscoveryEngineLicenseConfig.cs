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
        set => SetProperty("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformProperty<double>? Month
    {
        set => SetProperty("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformProperty<double>? Year
    {
        set => SetProperty("year", value);
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
        set => SetProperty("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformProperty<double>? Month
    {
        set => SetProperty("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformProperty<double>? Year
    {
        set => SetProperty("year", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("name");
        SetOutput("auto_renew");
        SetOutput("free_trial");
        SetOutput("id");
        SetOutput("license_config_id");
        SetOutput("license_count");
        SetOutput("location");
        SetOutput("project");
        SetOutput("subscription_term");
        SetOutput("subscription_tier");
    }

    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    public TerraformProperty<bool> AutoRenew
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_renew");
        set => SetProperty("auto_renew", value);
    }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    public TerraformProperty<bool> FreeTrial
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("free_trial");
        set => SetProperty("free_trial", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The unique id of the license config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigId is required")]
    public required TerraformProperty<string> LicenseConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_config_id");
        set => SetProperty("license_config_id", value);
    }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCount is required")]
    public required TerraformProperty<double> LicenseCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("license_count");
        set => SetProperty("license_count", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTerm is required")]
    public required TerraformProperty<string> SubscriptionTerm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_term");
        set => SetProperty("subscription_term", value);
    }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTier is required")]
    public required TerraformProperty<string> SubscriptionTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_tier");
        set => SetProperty("subscription_tier", value);
    }

    /// <summary>
    /// Block for end_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public List<GoogleDiscoveryEngineLicenseConfigEndDateBlock>? EndDate
    {
        set => SetProperty("end_date", value);
    }

    /// <summary>
    /// Block for start_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public List<GoogleDiscoveryEngineLicenseConfigStartDateBlock>? StartDate
    {
        set => SetProperty("start_date", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDiscoveryEngineLicenseConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
