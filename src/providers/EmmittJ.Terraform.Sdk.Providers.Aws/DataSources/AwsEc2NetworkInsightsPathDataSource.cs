using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2NetworkInsightsPathDataSourceFilterBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ec2_network_insights_path.
/// </summary>
public class AwsEc2NetworkInsightsPathDataSource : TerraformDataSource
{
    public AwsEc2NetworkInsightsPathDataSource(string name) : base("aws_ec2_network_insights_path", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The network_insights_path_id attribute.
    /// </summary>
    [TerraformPropertyName("network_insights_path_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkInsightsPathId { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("filter")]
    public TerraformSet<TerraformBlock<AwsEc2NetworkInsightsPathDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Destination => new TerraformReference(this, "destination");

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformPropertyName("destination_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestinationArn => new TerraformReference(this, "destination_arn");

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    [TerraformPropertyName("destination_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestinationIp => new TerraformReference(this, "destination_ip");

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [TerraformPropertyName("destination_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DestinationPort => new TerraformReference(this, "destination_port");

    /// <summary>
    /// The filter_at_destination attribute.
    /// </summary>
    [TerraformPropertyName("filter_at_destination")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FilterAtDestination => new TerraformReference(this, "filter_at_destination");

    /// <summary>
    /// The filter_at_source attribute.
    /// </summary>
    [TerraformPropertyName("filter_at_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FilterAtSource => new TerraformReference(this, "filter_at_source");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Protocol => new TerraformReference(this, "protocol");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Source => new TerraformReference(this, "source");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceArn => new TerraformReference(this, "source_arn");

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    [TerraformPropertyName("source_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceIp => new TerraformReference(this, "source_ip");

}
