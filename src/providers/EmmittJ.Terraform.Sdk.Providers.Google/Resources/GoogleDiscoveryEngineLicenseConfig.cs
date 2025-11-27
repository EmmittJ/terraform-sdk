using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for end_date in GoogleDiscoveryEngineLicenseConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => new TerraformReference<double>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => new TerraformReference<double>(this, "month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => new TerraformReference<double>(this, "year");
        set => SetArgument("year", value);
    }

}


/// <summary>
/// Block type for start_date in GoogleDiscoveryEngineLicenseConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => new TerraformReference<double>(this, "day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => new TerraformReference<double>(this, "month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => new TerraformReference<double>(this, "year");
        set => SetArgument("year", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDiscoveryEngineLicenseConfig.
/// Nesting mode: single
/// </summary>
public class GoogleDiscoveryEngineLicenseConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_discovery_engine_license_config Terraform resource.
/// Manages a google_discovery_engine_license_config resource.
/// </summary>
public partial class GoogleDiscoveryEngineLicenseConfig(string name) : TerraformResource("google_discovery_engine_license_config", name)
{
    /// <summary>
    /// Whether the license config should be auto renewed when it reaches the end date.
    /// </summary>
    public TerraformValue<bool>? AutoRenew
    {
        get => new TerraformReference<bool>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// Whether the license config is for free trial.
    /// </summary>
    public TerraformValue<bool>? FreeTrial
    {
        get => new TerraformReference<bool>(this, "free_trial");
        set => SetArgument("free_trial", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The unique id of the license config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseConfigId is required")]
    public required TerraformValue<string> LicenseConfigId
    {
        get => new TerraformReference<string>(this, "license_config_id");
        set => SetArgument("license_config_id", value);
    }

    /// <summary>
    /// Number of licenses purchased.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCount is required")]
    public required TerraformValue<double> LicenseCount
    {
        get => new TerraformReference<double>(this, "license_count");
        set => SetArgument("license_count", value);
    }

    /// <summary>
    /// The geographic location where the data store should reside. The value can
    /// only be one of &amp;quot;global&amp;quot;, &amp;quot;us&amp;quot; and &amp;quot;eu&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Subscription term. Possible values: [&amp;quot;SUBSCRIPTION_TERM_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_MONTH&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_ONE_YEAR&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_YEARS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_THREE_MONTHS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_FOURTEEN_DAYS&amp;quot;, &amp;quot;SUBSCRIPTION_TERM_CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTerm is required")]
    public required TerraformValue<string> SubscriptionTerm
    {
        get => new TerraformReference<string>(this, "subscription_term");
        set => SetArgument("subscription_term", value);
    }

    /// <summary>
    /// Subscription tier information for the license config. Possible values: [&amp;quot;SUBSCRIPTION_TIER_UNSPECIFIED&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_SEARCH_AND_ASSISTANT&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_NOTEBOOK_LM&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_FRONTLINE_WORKER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_STARTER&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_AGENTSPACE_BUSINESS&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_ENTERPRISE&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU&amp;quot;, &amp;quot;SUBSCRIPTION_TIER_EDU_PRO&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionTier is required")]
    public required TerraformValue<string> SubscriptionTier
    {
        get => new TerraformReference<string>(this, "subscription_tier");
        set => SetArgument("subscription_tier", value);
    }

    /// <summary>
    /// The unique full resource name of the license config. Values are of the format
    /// &#39;projects/{project}/locations/{location}/licenseConfigs/{license_config}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// EndDate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public TerraformList<GoogleDiscoveryEngineLicenseConfigEndDateBlock>? EndDate
    {
        get => GetArgument<TerraformList<GoogleDiscoveryEngineLicenseConfigEndDateBlock>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// StartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public required TerraformList<GoogleDiscoveryEngineLicenseConfigStartDateBlock> StartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleDiscoveryEngineLicenseConfigStartDateBlock>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDiscoveryEngineLicenseConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDiscoveryEngineLicenseConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
