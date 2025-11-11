using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for app_monitor_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsRumAppMonitorAppMonitorConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_cookies attribute.
    /// </summary>
    [TerraformProperty("allow_cookies")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowCookies { get; set; }

    /// <summary>
    /// The enable_xray attribute.
    /// </summary>
    [TerraformProperty("enable_xray")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableXray { get; set; }

    /// <summary>
    /// The excluded_pages attribute.
    /// </summary>
    [TerraformProperty("excluded_pages")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExcludedPages { get; set; }

    /// <summary>
    /// The favorite_pages attribute.
    /// </summary>
    [TerraformProperty("favorite_pages")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? FavoritePages { get; set; }

    /// <summary>
    /// The guest_role_arn attribute.
    /// </summary>
    [TerraformProperty("guest_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GuestRoleArn { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [TerraformProperty("identity_pool_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdentityPoolId { get; set; }

    /// <summary>
    /// The included_pages attribute.
    /// </summary>
    [TerraformProperty("included_pages")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IncludedPages { get; set; }

    /// <summary>
    /// The session_sample_rate attribute.
    /// </summary>
    [TerraformProperty("session_sample_rate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SessionSampleRate { get; set; }

    /// <summary>
    /// The telemetries attribute.
    /// </summary>
    [TerraformProperty("telemetries")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Telemetries { get; set; }

}

/// <summary>
/// Block type for custom_events in .
/// Nesting mode: list
/// </summary>
public partial class AwsRumAppMonitorCustomEventsBlock : TerraformBlockBase
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

}

/// <summary>
/// Manages a aws_rum_app_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRumAppMonitor : TerraformResource
{
    public AwsRumAppMonitor(string name) : base("aws_rum_app_monitor", name)
    {
    }

    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    [TerraformProperty("cw_log_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CwLogEnabled { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    [TerraformProperty("domain_list")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DomainList { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for app_monitor_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppMonitorConfiguration block(s) allowed")]
    [TerraformProperty("app_monitor_configuration")]
    public TerraformList<TerraformBlock<AwsRumAppMonitorAppMonitorConfigurationBlock>>? AppMonitorConfiguration { get; set; }

    /// <summary>
    /// Block for custom_events.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEvents block(s) allowed")]
    [TerraformProperty("custom_events")]
    public TerraformList<TerraformBlock<AwsRumAppMonitorCustomEventsBlock>>? CustomEvents { get; set; }

    /// <summary>
    /// The app_monitor_id attribute.
    /// </summary>
    [TerraformProperty("app_monitor_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppMonitorId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cw_log_group attribute.
    /// </summary>
    [TerraformProperty("cw_log_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CwLogGroup { get; }

}
