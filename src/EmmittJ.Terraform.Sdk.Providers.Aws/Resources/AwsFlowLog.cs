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
    public TerraformLiteralProperty<string>? DeliverCrossAccountRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deliver_cross_account_role");
        set => this.WithProperty("deliver_cross_account_role", value);
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EniId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eni_id");
        set => this.WithProperty("eni_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogDestination
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination");
        set => this.WithProperty("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogDestinationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination_type");
        set => this.WithProperty("log_destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_format");
        set => this.WithProperty("log_format", value);
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxAggregationInterval
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_aggregation_interval");
        set => this.WithProperty("max_aggregation_interval", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrafficType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_type");
        set => this.WithProperty("traffic_type", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
