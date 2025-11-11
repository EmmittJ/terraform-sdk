using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_server.
/// </summary>
public class AwsTransferServerDataSource : TerraformDataSource
{
    public AwsTransferServerDataSource(string name) : base("aws_transfer_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Certificate => new TerraformReference(this, "certificate");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointType => new TerraformReference(this, "endpoint_type");

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_provider_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IdentityProviderType => new TerraformReference(this, "identity_provider_type");

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    [TerraformPropertyName("invocation_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvocationRole => new TerraformReference(this, "invocation_role");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoggingRole => new TerraformReference(this, "logging_role");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Protocols => new TerraformReference(this, "protocols");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityPolicyName => new TerraformReference(this, "security_policy_name");

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    [TerraformPropertyName("structured_log_destinations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> StructuredLogDestinations => new TerraformReference(this, "structured_log_destinations");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
