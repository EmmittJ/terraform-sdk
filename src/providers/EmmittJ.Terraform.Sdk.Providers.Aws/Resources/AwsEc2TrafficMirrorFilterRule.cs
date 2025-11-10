using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_port_range in .
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock : ITerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FromPort { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ToPort { get; set; }

}

/// <summary>
/// Block type for source_port_range in .
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock : ITerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformPropertyName("from_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FromPort { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformPropertyName("to_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ToPort { get; set; }

}

/// <summary>
/// Manages a aws_ec2_traffic_mirror_filter_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2TrafficMirrorFilterRule : TerraformResource
{
    public AwsEc2TrafficMirrorFilterRule(string name) : base("aws_ec2_traffic_mirror_filter_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    [TerraformPropertyName("destination_cidr_block")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationCidrBlock { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    [TerraformPropertyName("rule_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleAction { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformPropertyName("rule_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RuleNumber { get; set; }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCidrBlock is required")]
    [TerraformPropertyName("source_cidr_block")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceCidrBlock { get; set; }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficDirection is required")]
    [TerraformPropertyName("traffic_direction")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TrafficDirection { get; set; }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    [TerraformPropertyName("traffic_mirror_filter_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TrafficMirrorFilterId { get; set; }

    /// <summary>
    /// Block for destination_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    [TerraformPropertyName("destination_port_range")]
    public TerraformList<TerraformBlock<AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock>>? DestinationPortRange { get; set; } = new();

    /// <summary>
    /// Block for source_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    [TerraformPropertyName("source_port_range")]
    public TerraformList<TerraformBlock<AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock>>? SourcePortRange { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
