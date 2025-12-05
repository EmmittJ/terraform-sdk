using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_partition Terraform data source.
/// Retrieves information about a aws_partition.
/// </summary>
public partial class AwsPartitionDataSource(string name) : TerraformDataSource("aws_partition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
        => CreateReference("dns_suffix");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
        => CreateReference("partition");

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> ReverseDnsPrefix
        => CreateReference("reverse_dns_prefix");

}
