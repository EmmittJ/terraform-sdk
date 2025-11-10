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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The access_role attribute.
    /// </summary>
    [TerraformPropertyName("access_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_role");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The as2_config attribute.
    /// </summary>
    [TerraformPropertyName("as2_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> As2Config => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "as2_config");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    [TerraformPropertyName("logging_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoggingRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logging_role");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    [TerraformPropertyName("security_policy_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecurityPolicyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "security_policy_name");

    /// <summary>
    /// The service_managed_egress_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("service_managed_egress_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ServiceManagedEgressIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "service_managed_egress_ip_addresses");

    /// <summary>
    /// The sftp_config attribute.
    /// </summary>
    [TerraformPropertyName("sftp_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SftpConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sftp_config");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
