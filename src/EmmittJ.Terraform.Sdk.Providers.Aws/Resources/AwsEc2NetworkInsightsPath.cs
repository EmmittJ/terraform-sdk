using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_network_insights_path resource.
/// </summary>
public class AwsEc2NetworkInsightsPath : TerraformResource
{
    public AwsEc2NetworkInsightsPath(string name) : base("aws_ec2_network_insights_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("destination_arn");
        this.DeclareOutput("source_arn");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public string? Destination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination")?.Value;
        set => this.WithProperty("destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public string? DestinationIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_ip")?.Value;
        set => this.WithProperty("destination_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public double? DestinationPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("destination_port")?.Value;
        set => this.WithProperty("destination_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public string? SourceIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_ip")?.Value;
        set => this.WithProperty("source_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformExpression DestinationArn => this["destination_arn"];

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformExpression SourceArn => this["source_arn"];

}
