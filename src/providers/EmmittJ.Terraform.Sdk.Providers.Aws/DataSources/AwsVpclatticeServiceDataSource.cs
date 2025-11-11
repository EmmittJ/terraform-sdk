using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_service.
/// </summary>
public partial class AwsVpclatticeServiceDataSource : TerraformDataSource
{
    public AwsVpclatticeServiceDataSource(string name) : base("aws_vpclattice_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    [TerraformProperty("service_identifier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceIdentifier { get; set; }

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
    /// The auth_type attribute.
    /// </summary>
    [TerraformProperty("auth_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AuthType { get; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [TerraformProperty("custom_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomDomainName { get; }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformProperty("dns_entry")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DnsEntry { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
