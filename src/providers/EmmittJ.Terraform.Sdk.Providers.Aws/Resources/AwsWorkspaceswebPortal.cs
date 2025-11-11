using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWorkspaceswebPortalTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_workspacesweb_portal resource.
/// </summary>
public class AwsWorkspaceswebPortal : TerraformResource
{
    public AwsWorkspaceswebPortal(string name) : base("aws_workspacesweb_portal", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("additional_encryption_context")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationType { get; set; } = default!;

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("browser_settings_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BrowserSettingsArn { get; set; } = default!;

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceType { get; set; } = default!;

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_sessions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxConcurrentSessions { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsWorkspaceswebPortalTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The browser_type attribute.
    /// </summary>
    [TerraformPropertyName("browser_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BrowserType => new TerraformReference(this, "browser_type");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("data_protection_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DataProtectionSettingsArn => new TerraformReference(this, "data_protection_settings_arn");

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("ip_access_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAccessSettingsArn => new TerraformReference(this, "ip_access_settings_arn");

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("network_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkSettingsArn => new TerraformReference(this, "network_settings_arn");

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [TerraformPropertyName("portal_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalArn => new TerraformReference(this, "portal_arn");

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("portal_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalEndpoint => new TerraformReference(this, "portal_endpoint");

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    [TerraformPropertyName("portal_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PortalStatus => new TerraformReference(this, "portal_status");

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    [TerraformPropertyName("renderer_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RendererType => new TerraformReference(this, "renderer_type");

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformPropertyName("session_logger_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SessionLoggerArn => new TerraformReference(this, "session_logger_arn");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformPropertyName("trust_store_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrustStoreArn => new TerraformReference(this, "trust_store_arn");

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("user_access_logging_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserAccessLoggingSettingsArn => new TerraformReference(this, "user_access_logging_settings_arn");

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("user_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserSettingsArn => new TerraformReference(this, "user_settings_arn");

}
