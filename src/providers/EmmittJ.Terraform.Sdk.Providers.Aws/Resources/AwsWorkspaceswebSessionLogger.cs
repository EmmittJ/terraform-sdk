using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_filter in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerEventFilterBlock
{
    /// <summary>
    /// The include attribute.
    /// </summary>
    [TerraformPropertyName("include")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Include { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerLogConfigurationBlock
{
}

/// <summary>
/// Manages a aws_workspacesweb_session_logger resource.
/// </summary>
public class AwsWorkspaceswebSessionLogger : TerraformResource
{
    public AwsWorkspaceswebSessionLogger(string name) : base("aws_workspacesweb_session_logger", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("additional_encryption_context")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? AdditionalEncryptionContext { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

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
    /// Block for event_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_filter")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerEventFilterBlock>>? EventFilter { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AssociatedPortalArns => new TerraformReference(this, "associated_portal_arns");

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformPropertyName("session_logger_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SessionLoggerArn => new TerraformReference(this, "session_logger_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
