using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_partition.
/// </summary>
public class AwsPartitionDataSource : TerraformDataSource
{
    public AwsPartitionDataSource(string name) : base("aws_partition", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsSuffix => new TerraformReference(this, "dns_suffix");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Partition => new TerraformReference(this, "partition");

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReverseDnsPrefix => new TerraformReference(this, "reverse_dns_prefix");

}
