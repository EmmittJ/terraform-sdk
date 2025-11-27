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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
    {
        get => new TerraformReference<string>(this, "dns_suffix");
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string> Partition
    {
        get => new TerraformReference<string>(this, "partition");
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformValue<string> ReverseDnsPrefix
    {
        get => new TerraformReference<string>(this, "reverse_dns_prefix");
    }

}
