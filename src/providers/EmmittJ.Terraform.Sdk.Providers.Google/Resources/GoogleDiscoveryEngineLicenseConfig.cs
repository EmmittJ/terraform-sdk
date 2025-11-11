using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for end_date in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineLicenseConfigEndDateBlock : TerraformBlockBase
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    [TerraformProperty("day")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Day { get; set; }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    [TerraformProperty("month")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Month { get; set; }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    [TerraformProperty("year")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Year { get; set; }

}

/// <summary>
/// Block type for start_date in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDiscoveryEngineLicenseConfigStartDateBlock : TerraformBlockBase
{
    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    [TerraformProperty("day")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Day { get; set; }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    [TerraformProperty("month")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Month { get; set; }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    [TerraformProperty("year")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Year { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDiscoveryEngineLicenseConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_discovery_engine_license_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDiscoveryEngineLicenseConfig : TerraformResource
{
    public GoogleDiscoveryEngineLicenseConfig(string name) : base("google_discovery_engine_license_config", name)
    {
    }

    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoRenew { get; set; }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    [TerraformProperty("free_trial")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? FreeTrial { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique id of the license config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigId is required")]
    [TerraformProperty("license_config_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseConfigId { get; set; }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCount is required")]
    [TerraformProperty("license_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> LicenseCount { get; set; }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTerm is required")]
    [TerraformProperty("subscription_term")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubscriptionTerm { get; set; }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTier is required")]
    [TerraformProperty("subscription_tier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubscriptionTier { get; set; }

    /// <summary>
    /// Block for end_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    [TerraformProperty("end_date")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineLicenseConfigEndDateBlock>>? EndDate { get; set; }

    /// <summary>
    /// Block for start_date.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    [TerraformProperty("start_date")]
    public TerraformList<TerraformBlock<GoogleDiscoveryEngineLicenseConfigStartDateBlock>>? StartDate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDiscoveryEngineLicenseConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
