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
        this.DeclareOutput("dns_suffix");
        this.DeclareOutput("partition");
        this.DeclareOutput("reverse_dns_prefix");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
