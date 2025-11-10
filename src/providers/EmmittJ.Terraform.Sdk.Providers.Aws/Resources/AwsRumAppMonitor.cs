using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for app_monitor_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorAppMonitorConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_cookies attribute.
    /// </summary>
    [TerraformPropertyName("allow_cookies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowCookies { get; set; }

    /// <summary>
    /// The enable_xray attribute.
    /// </summary>
    [TerraformPropertyName("enable_xray")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableXray { get; set; }

    /// <summary>
    /// The excluded_pages attribute.
    /// </summary>
    [TerraformPropertyName("excluded_pages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ExcludedPages { get; set; }

    /// <summary>
    /// The favorite_pages attribute.
    /// </summary>
    [TerraformPropertyName("favorite_pages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? FavoritePages { get; set; }

    /// <summary>
    /// The guest_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("guest_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GuestRoleArn { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("identity_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityPoolId { get; set; }

    /// <summary>
    /// The included_pages attribute.
    /// </summary>
    [TerraformPropertyName("included_pages")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IncludedPages { get; set; }

    /// <summary>
    /// The session_sample_rate attribute.
    /// </summary>
    [TerraformPropertyName("session_sample_rate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SessionSampleRate { get; set; }

    /// <summary>
    /// The telemetries attribute.
    /// </summary>
    [TerraformPropertyName("telemetries")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Telemetries { get; set; }

}

/// <summary>
/// Block type for custom_events in .
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorCustomEventsBlock : ITerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

}

/// <summary>
/// Manages a aws_rum_app_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRumAppMonitor : TerraformResource
{
    public AwsRumAppMonitor(string name) : base("aws_rum_app_monitor", name)
    {
    }

    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cw_log_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CwLogEnabled { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Domain { get; set; }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    [TerraformPropertyName("domain_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DomainList { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for app_monitor_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppMonitorConfiguration block(s) allowed")]
    [TerraformPropertyName("app_monitor_configuration")]
    public TerraformList<TerraformBlock<AwsRumAppMonitorAppMonitorConfigurationBlock>>? AppMonitorConfiguration { get; set; } = new();

    /// <summary>
    /// Block for custom_events.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEvents block(s) allowed")]
    [TerraformPropertyName("custom_events")]
    public TerraformList<TerraformBlock<AwsRumAppMonitorCustomEventsBlock>>? CustomEvents { get; set; } = new();

    /// <summary>
    /// The app_monitor_id attribute.
    /// </summary>
    [TerraformPropertyName("app_monitor_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppMonitorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_monitor_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cw_log_group attribute.
    /// </summary>
    [TerraformPropertyName("cw_log_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CwLogGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cw_log_group");

}
