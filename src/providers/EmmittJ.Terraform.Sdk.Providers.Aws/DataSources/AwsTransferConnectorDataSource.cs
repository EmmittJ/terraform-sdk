using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_connector.
/// </summary>
public class AwsTransferConnectorDataSource : TerraformDataSource
{
    public AwsTransferConnectorDataSource(string name) : base("aws_transfer_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [TerraformPropertyName("access_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessRole => new TerraformReference(this, "access_role");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    [TerraformPropertyName("as2_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> As2Config => new TerraformReference(this, "as2_config");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoggingRole => new TerraformReference(this, "logging_role");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecurityPolicyName => new TerraformReference(this, "security_policy_name");

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("service_managed_egress_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ServiceManagedEgressIpAddresses => new TerraformReference(this, "service_managed_egress_ip_addresses");

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    [TerraformPropertyName("sftp_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SftpConfig => new TerraformReference(this, "sftp_config");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
