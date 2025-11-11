using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service.
/// </summary>
public partial class AwsServiceDataSource : TerraformDataSource
{
    public AwsServiceDataSource(string name) : base("aws_service", name)
    {
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DnsName { get; set; }

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
    /// The reverse_dns_name attribute.
    /// </summary>
    [TerraformProperty("reverse_dns_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReverseDnsName { get; set; }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformProperty("reverse_dns_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ReverseDnsPrefix { get; set; }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformProperty("service_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceId { get; set; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformProperty("partition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Partition { get; }

    /// <summary>
    /// The supported attribute.
    /// </summary>
    [TerraformProperty("supported")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Supported { get; }

}
