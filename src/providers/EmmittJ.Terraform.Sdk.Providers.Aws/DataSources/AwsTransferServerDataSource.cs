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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Certificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_type");

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_provider_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityProviderType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_provider_type");

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    [TerraformPropertyName("invocation_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvocationRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invocation_role");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoggingRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logging_role");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Protocols => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "protocols");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityPolicyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_policy_name");

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    [TerraformPropertyName("structured_log_destinations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> StructuredLogDestinations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "structured_log_destinations");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
