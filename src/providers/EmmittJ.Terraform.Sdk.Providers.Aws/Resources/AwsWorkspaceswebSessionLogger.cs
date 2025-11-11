using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspaceswebSessionLoggerEventFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The include attribute.
    /// </summary>
    [TerraformProperty("include")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Include { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsWorkspaceswebSessionLoggerLogConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_workspacesweb_session_logger resource.
/// </summary>
public partial class AwsWorkspaceswebSessionLogger : TerraformResource
{
    public AwsWorkspaceswebSessionLogger(string name) : base("aws_workspacesweb_session_logger", name)
    {
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    [TerraformProperty("additional_encryption_context")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? AdditionalEncryptionContext { get; set; }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerManagedKey { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

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
    /// Block for event_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event_filter")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerEventFilterBlock>>? EventFilter { get; set; }

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("log_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>>? LogConfiguration { get; set; }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformProperty("associated_portal_arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AssociatedPortalArns { get; }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformProperty("session_logger_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SessionLoggerArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
