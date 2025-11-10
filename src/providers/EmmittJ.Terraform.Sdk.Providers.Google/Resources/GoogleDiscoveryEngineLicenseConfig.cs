using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for end_date in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigEndDateBlock : ITerraformBlock
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    [TerraformPropertyName("day")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Day { get; set; }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    [TerraformPropertyName("month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Month { get; set; }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    [TerraformPropertyName("year")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Year { get; set; }

}

/// <summary>
/// Block type for start_date in .
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigStartDateBlock : ITerraformBlock
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    [TerraformPropertyName("day")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Day { get; set; }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    [TerraformPropertyName("month")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Month { get; set; }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    [TerraformPropertyName("year")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Year { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_license_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDiscoveryEngineLicenseConfig : TerraformResource
{
    public GoogleDiscoveryEngineLicenseConfig(string name) : base("google_discovery_engine_license_config", name)
    {
    }

    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    [TerraformPropertyName("auto_renew")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoRenew { get; set; }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    [TerraformPropertyName("free_trial")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? FreeTrial { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The unique id of the license config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigId is required")]
    [TerraformPropertyName("license_config_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseConfigId { get; set; }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCount is required")]
    [TerraformPropertyName("license_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> LicenseCount { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTerm is required")]
    [TerraformPropertyName("subscription_term")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriptionTerm { get; set; }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTier is required")]
    [TerraformPropertyName("subscription_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriptionTier { get; set; }

    /// <summary>
    /// Block for end_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    [TerraformPropertyName("end_date")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineLicenseConfigEndDateBlock>>? EndDate { get; set; } = new();

    /// <summary>
    /// Block for start_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    [TerraformPropertyName("start_date")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineLicenseConfigStartDateBlock>>? StartDate { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineLicenseConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
