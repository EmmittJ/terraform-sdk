using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service.
/// </summary>
public class AwsServiceDataSource : TerraformDataSource
{
    public AwsServiceDataSource(string name) : base("aws_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("partition");
        this.DeclareOutput("supported");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? DnsName
    {
        get => GetProperty<TerraformProperty<string>>("dns_name");
        set => this.WithProperty("dns_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The reverse_dns_name attribute.
    /// </summary>
    public TerraformProperty<string>? ReverseDnsName
    {
        get => GetProperty<TerraformProperty<string>>("reverse_dns_name");
        set => this.WithProperty("reverse_dns_name", value);
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ReverseDnsPrefix
    {
        get => GetProperty<TerraformProperty<string>>("reverse_dns_prefix");
        set => this.WithProperty("reverse_dns_prefix", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformExpression Partition => this["partition"];

    /// <summary>
    /// The supported attribute.
    /// </summary>
    public TerraformExpression Supported => this["supported"];

}
