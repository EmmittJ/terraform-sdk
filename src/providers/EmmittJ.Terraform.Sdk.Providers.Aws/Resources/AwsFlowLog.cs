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
        set => SetProperty("file_format", value);
    }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    public TerraformProperty<bool>? HiveCompatiblePartitions
    {
        set => SetProperty("hive_compatible_partitions", value);
    }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    public TerraformProperty<bool>? PerHourPartition
    {
        set => SetProperty("per_hour_partition", value);
    }

}

/// <summary>
/// Manages a aws_flow_log resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFlowLog : TerraformResource
{
    public AwsFlowLog(string name) : base("aws_flow_log", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("deliver_cross_account_role");
        SetOutput("eni_id");
        SetOutput("iam_role_arn");
        SetOutput("id");
        SetOutput("log_destination");
        SetOutput("log_destination_type");
        SetOutput("log_format");
        SetOutput("max_aggregation_interval");
        SetOutput("region");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("traffic_type");
        SetOutput("transit_gateway_attachment_id");
        SetOutput("transit_gateway_id");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    public TerraformProperty<string> DeliverCrossAccountRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deliver_cross_account_role");
        set => SetProperty("deliver_cross_account_role", value);
    }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    public TerraformProperty<string> EniId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eni_id");
        set => SetProperty("eni_id", value);
    }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_role_arn");
        set => SetProperty("iam_role_arn", value);
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
    /// The log_destination attribute.
    /// </summary>
    public TerraformProperty<string> LogDestination
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_destination");
        set => SetProperty("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformProperty<string> LogDestinationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_destination_type");
        set => SetProperty("log_destination_type", value);
    }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    public TerraformProperty<string> LogFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_format");
        set => SetProperty("log_format", value);
    }

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    public TerraformProperty<double> MaxAggregationInterval
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_aggregation_interval");
        set => SetProperty("max_aggregation_interval", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The traffic_type attribute.
    /// </summary>
    public TerraformProperty<string> TrafficType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_type");
        set => SetProperty("traffic_type", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string> TransitGatewayAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => SetProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for destination_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    public List<AwsFlowLogDestinationOptionsBlock>? DestinationOptions
    {
        set => SetProperty("destination_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
