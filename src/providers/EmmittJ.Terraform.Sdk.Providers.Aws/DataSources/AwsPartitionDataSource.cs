using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_partition.
/// </summary>
public class AwsPartitionDataSource : TerraformDataSource
{
    public AwsPartitionDataSource(string name) : base("aws_partition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_suffix");
        SetOutput("partition");
        SetOutput("reverse_dns_prefix");
        SetOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformExpression DnsSuffix => this["dns_suffix"];

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformExpression Partition => this["partition"];

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformExpression ReverseDnsPrefix => this["reverse_dns_prefix"];

}
