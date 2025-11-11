using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_partition.
/// </summary>
public partial class AwsPartitionDataSource : TerraformDataSource
{
    public AwsPartitionDataSource(string name) : base("aws_partition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformProperty("dns_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsSuffix { get; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformProperty("partition")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Partition { get; }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformProperty("reverse_dns_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReverseDnsPrefix { get; }

}
