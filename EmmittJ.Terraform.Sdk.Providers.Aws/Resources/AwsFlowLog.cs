using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_flow_log resource.
/// </summary>
public class AwsFlowLog : TerraformResource
{
    public AwsFlowLog(string name) : base("aws_flow_log", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    public string? DeliverCrossAccountRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deliver_cross_account_role")?.Value;
        set => this.WithProperty("deliver_cross_account_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public string? EniId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eni_id")?.Value;
        set => this.WithProperty("eni_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public string? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn")?.Value;
        set => this.WithProperty("iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The log_destination attribute.
    /// </summary>
    public string? LogDestination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination")?.Value;
        set => this.WithProperty("log_destination", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public string? LogDestinationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination_type")?.Value;
        set => this.WithProperty("log_destination_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public string? LogFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_format")?.Value;
        set => this.WithProperty("log_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? LogGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_group_name")?.Value;
        set => this.WithProperty("log_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public double? MaxAggregationInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_aggregation_interval")?.Value;
        set => this.WithProperty("max_aggregation_interval", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The traffic_type attribute.
    /// </summary>
    public string? TrafficType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_type")?.Value;
        set => this.WithProperty("traffic_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public string? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id")?.Value;
        set => this.WithProperty("transit_gateway_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
