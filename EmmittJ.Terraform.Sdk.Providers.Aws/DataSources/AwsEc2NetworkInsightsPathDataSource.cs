using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    public string? NetworkInsightsPathId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_insights_path_id")?.Value;
        set => this.WithProperty("network_insights_path_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
