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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformPropertyName("dns_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_suffix");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Partition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "partition");

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    [TerraformPropertyName("reverse_dns_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReverseDnsPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reverse_dns_prefix");

}
