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
        set => SetProperty("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAddress
    {
        set => SetProperty("source_address", value);
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
        set => SetProperty("destination_address", value);
    }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    public TerraformProperty<string>? SourceAddress
    {
        set => SetProperty("source_address", value);
    }

}

/// <summary>
/// Manages a aws_ec2_network_insights_path resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2NetworkInsightsPath : TerraformResource
{
    public AwsEc2NetworkInsightsPath(string name) : base("aws_ec2_network_insights_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("destination_arn");
        SetOutput("source_arn");
        SetOutput("destination");
        SetOutput("destination_ip");
        SetOutput("destination_port");
        SetOutput("id");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("source");
        SetOutput("source_ip");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformProperty<string> Destination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination");
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformProperty<string> DestinationIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_ip");
        set => SetProperty("destination_ip", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformProperty<double> DestinationPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("destination_port");
        set => SetProperty("destination_port", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformProperty<string> SourceIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_ip");
        set => SetProperty("source_ip", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for filter_at_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    public List<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>? FilterAtDestination
    {
        set => SetProperty("filter_at_destination", value);
    }

    /// <summary>
    /// Block for filter_at_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    public List<AwsEc2NetworkInsightsPathFilterAtSourceBlock>? FilterAtSource
    {
        set => SetProperty("filter_at_source", value);
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
