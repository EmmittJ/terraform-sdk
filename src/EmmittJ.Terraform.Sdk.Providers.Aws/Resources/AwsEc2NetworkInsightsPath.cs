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
    public TerraformProperty<string>? Destination
    {
        get => GetProperty<TerraformProperty<string>>("destination");
        set => this.WithProperty("destination", value);
    }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationIp
    {
        get => GetProperty<TerraformProperty<string>>("destination_ip");
        set => this.WithProperty("destination_ip", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformProperty<double>? DestinationPort
    {
        get => GetProperty<TerraformProperty<double>>("destination_port");
        set => this.WithProperty("destination_port", value);
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
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformProperty<string>? SourceIp
    {
        get => GetProperty<TerraformProperty<string>>("source_ip");
        set => this.WithProperty("source_ip", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
