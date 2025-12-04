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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
        => AsReference("dns_suffix");

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
        => AsReference("partition");

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> ReverseDnsPrefix
        => AsReference("reverse_dns_prefix");

}
