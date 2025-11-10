using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_options in .
/// Nesting mode: list
/// </summary>
public class AwsFlowLogDestinationOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The file_format attribute.
    /// </summary>
    public TerraformProperty<string>? FileFormat
    {
        get => GetProperty<TerraformProperty<string>>("file_format");
        set => WithProperty("file_format", value);
    }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    public TerraformProperty<bool>? HiveCompatiblePartitions
    {
        get => GetProperty<TerraformProperty<bool>>("hive_compatible_partitions");
        set => WithProperty("hive_compatible_partitions", value);
    }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    public TerraformProperty<bool>? PerHourPartition
    {
        get => GetProperty<TerraformProperty<bool>>("per_hour_partition");
        set => WithProperty("per_hour_partition", value);
    }

}

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
    public TerraformProperty<string>? DeliverCrossAccountRole
    {
        get => GetProperty<TerraformProperty<string>>("deliver_cross_account_role");
        set => this.WithProperty("deliver_cross_account_role", value);
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformProperty<string>? EniId
    {
        get => GetProperty<TerraformProperty<string>>("eni_id");
        set => this.WithProperty("eni_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_role_arn");
        set => this.WithProperty("iam_role_arn", value);
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
    /// The log_destination attribute.
    /// </summary>
    public TerraformProperty<string>? LogDestination
    {
        get => GetProperty<TerraformProperty<string>>("log_destination");
        set => this.WithProperty("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformProperty<string>? LogDestinationType
    {
        get => GetProperty<TerraformProperty<string>>("log_destination_type");
        set => this.WithProperty("log_destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public TerraformProperty<string>? LogFormat
    {
        get => GetProperty<TerraformProperty<string>>("log_format");
        set => this.WithProperty("log_format", value);
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAggregationInterval
    {
        get => GetProperty<TerraformProperty<double>>("max_aggregation_interval");
        set => this.WithProperty("max_aggregation_interval", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The traffic_type attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficType
    {
        get => GetProperty<TerraformProperty<string>>("traffic_type");
        set => this.WithProperty("traffic_type", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for destination_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    public List<AwsFlowLogDestinationOptionsBlock>? DestinationOptions
    {
        get => GetProperty<List<AwsFlowLogDestinationOptionsBlock>>("destination_options");
        set => this.WithProperty("destination_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
