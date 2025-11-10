using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_at_destination in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlock : TerraformBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationAddress
    {
        get => GetProperty<TerraformProperty<string>>("destination_address");
        set => WithProperty("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAddress
    {
        get => GetProperty<TerraformProperty<string>>("source_address");
        set => WithProperty("source_address", value);
    }

}

/// <summary>
/// Block type for filter_at_source in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlock : TerraformBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationAddress
    {
        get => GetProperty<TerraformProperty<string>>("destination_address");
        set => WithProperty("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAddress
    {
        get => GetProperty<TerraformProperty<string>>("source_address");
        set => WithProperty("source_address", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for filter_at_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    public List<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>? FilterAtDestination
    {
        get => GetProperty<List<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>>("filter_at_destination");
        set => this.WithProperty("filter_at_destination", value);
    }

    /// <summary>
    /// Block for filter_at_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    public List<AwsEc2NetworkInsightsPathFilterAtSourceBlock>? FilterAtSource
    {
        get => GetProperty<List<AwsEc2NetworkInsightsPathFilterAtSourceBlock>>("filter_at_source");
        set => this.WithProperty("filter_at_source", value);
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
