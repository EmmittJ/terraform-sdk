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
    public string? DnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_name")?.Value;
        set => this.WithProperty("dns_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reverse_dns_name attribute.
    /// </summary>
    public string? ReverseDnsName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reverse_dns_name")?.Value;
        set => this.WithProperty("reverse_dns_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public string? ReverseDnsPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reverse_dns_prefix")?.Value;
        set => this.WithProperty("reverse_dns_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public string? ServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_id")?.Value;
        set => this.WithProperty("service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
