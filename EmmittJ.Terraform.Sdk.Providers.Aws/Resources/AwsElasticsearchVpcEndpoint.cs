using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticsearch_vpc_endpoint resource.
/// </summary>
public class AwsElasticsearchVpcEndpoint : TerraformResource
{
    public AwsElasticsearchVpcEndpoint(string name) : base("aws_elasticsearch_vpc_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public string? DomainArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_arn")?.Value;
        set => this.WithProperty("domain_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

}
