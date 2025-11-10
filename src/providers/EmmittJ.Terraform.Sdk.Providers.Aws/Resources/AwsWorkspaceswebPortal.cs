using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWorkspaceswebPortalTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authentication_type");

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("browser_settings_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BrowserSettingsArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "browser_settings_arn");

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

    /// <summary>
    /// The max_concurrent_sessions attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_sessions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxConcurrentSessions { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_concurrent_sessions");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsWorkspaceswebPortalTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The browser_type attribute.
    /// </summary>
    [TerraformPropertyName("browser_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BrowserType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "browser_type");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("data_protection_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataProtectionSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_protection_settings_arn");

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("ip_access_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAccessSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_access_settings_arn");

    /// <summary>
    /// The network_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("network_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_settings_arn");

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [TerraformPropertyName("portal_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortalArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "portal_arn");

    /// <summary>
    /// The portal_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("portal_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortalEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "portal_endpoint");

    /// <summary>
    /// The portal_status attribute.
    /// </summary>
    [TerraformPropertyName("portal_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PortalStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "portal_status");

    /// <summary>
    /// The renderer_type attribute.
    /// </summary>
    [TerraformPropertyName("renderer_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RendererType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "renderer_type");

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformPropertyName("session_logger_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SessionLoggerArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "session_logger_arn");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformPropertyName("trust_store_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustStoreArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "trust_store_arn");

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("user_access_logging_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserAccessLoggingSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_access_logging_settings_arn");

    /// <summary>
    /// The user_settings_arn attribute.
    /// </summary>
    [TerraformPropertyName("user_settings_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserSettingsArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_settings_arn");

}
