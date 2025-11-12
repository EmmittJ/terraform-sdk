using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsWorkspaceswebPortalTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_portal resource.
/// </summary>
public partial class AwsWorkspaceswebPortal : TerraformResource
{
    public AwsWorkspaceswebPortal(string name) : base("aws_workspacesweb_portal", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformProperty("additional_encryption_context")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    [TerraformProperty("browser_settings_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BrowserSettingsArn { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_sessions")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxConcurrentSessions { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsWorkspaceswebPortalTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The browser_type attribute.
    /// </summary>
    [TerraformProperty("browser_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BrowserType { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [TerraformProperty("data_protection_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataProtectionSettingsArn { get; }

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    [TerraformProperty("ip_access_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAccessSettingsArn { get; }

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    [TerraformProperty("network_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkSettingsArn { get; }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [TerraformProperty("portal_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalArn { get; }

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    [TerraformProperty("portal_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalEndpoint { get; }

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    [TerraformProperty("portal_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalStatus { get; }

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    [TerraformProperty("renderer_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RendererType { get; }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformProperty("session_logger_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SessionLoggerArn { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformProperty("trust_store_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustStoreArn { get; }

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [TerraformProperty("user_access_logging_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserAccessLoggingSettingsArn { get; }

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [TerraformProperty("user_settings_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserSettingsArn { get; }

}
