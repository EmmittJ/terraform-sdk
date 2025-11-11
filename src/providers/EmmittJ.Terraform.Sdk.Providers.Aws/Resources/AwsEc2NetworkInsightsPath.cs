using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_at_destination in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformPropertyName("destination_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformPropertyName("source_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceAddress { get; set; }

}

/// <summary>
/// Block type for filter_at_source in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformPropertyName("destination_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformPropertyName("source_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceAddress { get; set; }

}

/// <summary>
/// Manages a aws_ec2_network_insights_path resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2NetworkInsightsPath : TerraformResource
{
    public AwsEc2NetworkInsightsPath(string name) : base("aws_ec2_network_insights_path", name)
    {
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Destination { get; set; }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    [TerraformPropertyName("destination_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DestinationIp { get; set; }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [TerraformPropertyName("destination_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DestinationPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    [TerraformPropertyName("source_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceIp { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for filter_at_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    [TerraformPropertyName("filter_at_destination")]
    public TerraformList<TerraformBlock<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>>? FilterAtDestination { get; set; }

    /// <summary>
    /// Block for filter_at_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    [TerraformPropertyName("filter_at_source")]
    public TerraformList<TerraformBlock<AwsEc2NetworkInsightsPathFilterAtSourceBlock>>? FilterAtSource { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformPropertyName("destination_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DestinationArn => new TerraformReference(this, "destination_arn");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceArn => new TerraformReference(this, "source_arn");

}
