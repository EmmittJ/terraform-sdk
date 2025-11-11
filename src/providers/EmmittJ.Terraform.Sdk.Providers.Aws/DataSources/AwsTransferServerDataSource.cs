using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_server.
/// </summary>
public partial class AwsTransferServerDataSource : TerraformDataSource
{
    public AwsTransferServerDataSource(string name) : base("aws_transfer_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Certificate { get; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    [TerraformProperty("endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EndpointType { get; }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [TerraformProperty("identity_provider_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityProviderType { get; }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    [TerraformProperty("invocation_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InvocationRole { get; }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformProperty("logging_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoggingRole { get; }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformProperty("protocols")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Protocols { get; }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformProperty("security_policy_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityPolicyName { get; }

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    [TerraformProperty("structured_log_destinations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> StructuredLogDestinations { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
