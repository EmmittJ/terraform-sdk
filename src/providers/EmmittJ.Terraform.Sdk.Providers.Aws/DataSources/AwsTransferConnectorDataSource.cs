using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_transfer_connector.
/// </summary>
public partial class AwsTransferConnectorDataSource : TerraformDataSource
{
    public AwsTransferConnectorDataSource(string name) : base("aws_transfer_connector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [TerraformProperty("access_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessRole { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    [TerraformProperty("as2_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> As2Config { get; }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformProperty("logging_role")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoggingRole { get; }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformProperty("security_policy_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityPolicyName { get; }

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("service_managed_egress_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ServiceManagedEgressIpAddresses { get; }

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    [TerraformProperty("sftp_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SftpConfig { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
