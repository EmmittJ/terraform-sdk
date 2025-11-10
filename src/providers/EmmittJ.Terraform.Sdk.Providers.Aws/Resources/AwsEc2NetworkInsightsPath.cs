using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_at_destination in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtDestinationBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformPropertyName("destination_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformPropertyName("source_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceAddress { get; set; }

}

/// <summary>
/// Block type for filter_at_source in .
/// Nesting mode: list
/// </summary>
public class AwsEc2NetworkInsightsPathFilterAtSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_address attribute.
    /// </summary>
    [TerraformPropertyName("destination_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationAddress { get; set; }

    /// <summary>
    /// The source_address attribute.
    /// </summary>
    [TerraformPropertyName("source_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceAddress { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? Destination { get; set; }

    /// <summary>
    /// The destination_ip attribute.
    /// </summary>
    [TerraformPropertyName("destination_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationIp { get; set; }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [TerraformPropertyName("destination_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DestinationPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    [TerraformPropertyName("source_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceIp { get; set; }

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
    /// Block for filter_at_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtDestination block(s) allowed")]
    [TerraformPropertyName("filter_at_destination")]
    public TerraformList<TerraformBlock<AwsEc2NetworkInsightsPathFilterAtDestinationBlock>>? FilterAtDestination { get; set; } = new();

    /// <summary>
    /// Block for filter_at_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterAtSource block(s) allowed")]
    [TerraformPropertyName("filter_at_source")]
    public TerraformList<TerraformBlock<AwsEc2NetworkInsightsPathFilterAtSourceBlock>>? FilterAtSource { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [TerraformPropertyName("destination_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DestinationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "destination_arn");

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_arn");

}
