using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsEc2NetworkInsightsPathDataSourceFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_path.
/// </summary>
public partial class AwsEc2NetworkInsightsPathDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsPathDataSource(string name) : base("aws_ec2_network_insights_path", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [TerraformProperty("network_insights_path_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkInsightsPathId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public TerraformSet<AwsEc2NetworkInsightsPathDataSourceFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformProperty("destination")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Destination { get; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformProperty("destination_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationArn { get; }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    [TerraformProperty("destination_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationIp { get; }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [TerraformProperty("destination_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> DestinationPort { get; }

    /// <summary>
    /// The filter_at_destination attribute.
    /// </summary>
    [TerraformProperty("filter_at_destination")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FilterAtDestination { get; }

    /// <summary>
    /// The filter_at_source attribute.
    /// </summary>
    [TerraformProperty("filter_at_source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FilterAtSource { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Source { get; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformProperty("source_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceArn { get; }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    [TerraformProperty("source_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceIp { get; }

}
