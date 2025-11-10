using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_options in .
/// Nesting mode: list
/// </summary>
public class AwsFlowLogDestinationOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The file_format attribute.
    /// </summary>
    [TerraformPropertyName("file_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FileFormat { get; set; }

    /// <summary>
    /// The hive_compatible_partitions attribute.
    /// </summary>
    [TerraformPropertyName("hive_compatible_partitions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HiveCompatiblePartitions { get; set; }

    /// <summary>
    /// The per_hour_partition attribute.
    /// </summary>
    [TerraformPropertyName("per_hour_partition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PerHourPartition { get; set; }

}

/// <summary>
/// Manages a aws_flow_log resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFlowLog : TerraformResource
{
    public AwsFlowLog(string name) : base("aws_flow_log", name)
    {
    }

    /// <summary>
    /// The deliver_cross_account_role attribute.
    /// </summary>
    [TerraformPropertyName("deliver_cross_account_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliverCrossAccountRole { get; set; }

    /// <summary>
    /// The eni_id attribute.
    /// </summary>
    [TerraformPropertyName("eni_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EniId { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamRoleArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [TerraformPropertyName("log_destination")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogDestination { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "log_destination");

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("log_destination_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogDestinationType { get; set; }

    /// <summary>
    /// The log_format attribute.
    /// </summary>
    [TerraformPropertyName("log_format")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LogFormat { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "log_format");

    /// <summary>
    /// The max_aggregation_interval attribute.
    /// </summary>
    [TerraformPropertyName("max_aggregation_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxAggregationInterval { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The traffic_type attribute.
    /// </summary>
    [TerraformPropertyName("traffic_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrafficType { get; set; }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_attachment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayAttachmentId { get; set; }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("transit_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TransitGatewayId { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcId { get; set; }

    /// <summary>
    /// Block for destination_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationOptions block(s) allowed")]
    [TerraformPropertyName("destination_options")]
    public TerraformList<TerraformBlock<AwsFlowLogDestinationOptionsBlock>>? DestinationOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
