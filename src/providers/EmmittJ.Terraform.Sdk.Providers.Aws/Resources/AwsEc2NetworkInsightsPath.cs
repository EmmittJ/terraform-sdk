using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_at_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2NetworkInsightsPathFilterAtDestinationBlock() : TerraformBlock("filter_at_destination")
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformProperty("destination_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformProperty("source_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceAddress { get; set; }

}

/// <summary>
/// Block type for filter_at_source in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2NetworkInsightsPathFilterAtSourceBlock() : TerraformBlock("filter_at_source")
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformProperty("destination_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformProperty("source_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceAddress { get; set; }

}

/// <summary>
/// Manages a aws_ec2_network_insights_path resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEc2NetworkInsightsPath : TerraformResource
{
    public AwsEc2NetworkInsightsPath(string name) : base("aws_ec2_network_insights_path", name)
    {
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformProperty("destination")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Destination { get; set; }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    [TerraformProperty("destination_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DestinationIp { get; set; }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [TerraformProperty("destination_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DestinationPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    [TerraformProperty("source_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceIp { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for filter_at_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    [TerraformProperty("filter_at_destination")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtDestinationBlock> FilterAtDestination { get; set; } = new();

    /// <summary>
    /// Block for filter_at_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    [TerraformProperty("filter_at_source")]
    public TerraformList<AwsEc2NetworkInsightsPathFilterAtSourceBlock> FilterAtSource { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformProperty("destination_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DestinationArn { get; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformProperty("source_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceArn { get; }

}
