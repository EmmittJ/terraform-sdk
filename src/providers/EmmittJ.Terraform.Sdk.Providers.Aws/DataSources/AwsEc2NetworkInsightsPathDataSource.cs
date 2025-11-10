using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsPathDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_path.
/// </summary>
public class AwsEc2NetworkInsightsPathDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsPathDataSource(string name) : base("aws_ec2_network_insights_path", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("destination");
        this.DeclareOutput("destination_arn");
        this.DeclareOutput("destination_ip");
        this.DeclareOutput("destination_port");
        this.DeclareOutput("filter_at_destination");
        this.DeclareOutput("filter_at_source");
        this.DeclareOutput("protocol");
        this.DeclareOutput("source");
        this.DeclareOutput("source_arn");
        this.DeclareOutput("source_ip");
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
    /// The network_insights_path_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkInsightsPathId
    {
        get => GetProperty<TerraformProperty<string>>("network_insights_path_id");
        set => this.WithProperty("network_insights_path_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The destination attribute.
    /// </summary>
    public TerraformExpression Destination => this["destination"];

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public TerraformExpression DestinationArn => this["destination_arn"];

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    public TerraformExpression DestinationIp => this["destination_ip"];

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    public TerraformExpression DestinationPort => this["destination_port"];

    /// <summary>
    /// The filter_at_destination attribute.
    /// </summary>
    public TerraformExpression FilterAtDestination => this["filter_at_destination"];

    /// <summary>
    /// The filter_at_source attribute.
    /// </summary>
    public TerraformExpression FilterAtSource => this["filter_at_source"];

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformExpression Source => this["source"];

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformExpression SourceArn => this["source_arn"];

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformExpression SourceIp => this["source_ip"];

}
