using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_filter in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerEventFilterBlock : ITerraformBlock
{
    /// <summary>
    /// The include attribute.
    /// </summary>
    [TerraformPropertyName("include")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Include { get; set; }

}

/// <summary>
/// Block type for log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebSessionLoggerLogConfigurationBlock : ITerraformBlock
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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AdditionalEncryptionContext { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

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
    /// Block for event_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event_filter")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerEventFilterBlock>>? EventFilter { get; set; } = new();

    /// <summary>
    /// Block for log_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log_configuration")]
    public TerraformList<TerraformBlock<AwsWorkspaceswebSessionLoggerLogConfigurationBlock>>? LogConfiguration { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformPropertyName("associated_portal_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AssociatedPortalArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "associated_portal_arns");

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    [TerraformPropertyName("session_logger_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SessionLoggerArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "session_logger_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
