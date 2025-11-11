using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_port_range in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock : TerraformBlockBase
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FromPort { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ToPort { get; set; }

}

/// <summary>
/// Block type for source_port_range in .
/// Nesting mode: list
/// </summary>
public partial class AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock : TerraformBlockBase
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [TerraformProperty("from_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FromPort { get; set; }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [TerraformProperty("to_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? ToPort { get; set; }

}

/// <summary>
/// Manages a aws_ec2_traffic_mirror_filter_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEc2TrafficMirrorFilterRule : TerraformResource
{
    public AwsEc2TrafficMirrorFilterRule(string name) : base("aws_ec2_traffic_mirror_filter_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    [TerraformProperty("destination_cidr_block")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationCidrBlock { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Protocol { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    [TerraformProperty("rule_action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleAction { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformProperty("rule_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RuleNumber { get; set; }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCidrBlock is required")]
    [TerraformProperty("source_cidr_block")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceCidrBlock { get; set; }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficDirection is required")]
    [TerraformProperty("traffic_direction")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrafficDirection { get; set; }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    [TerraformProperty("traffic_mirror_filter_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrafficMirrorFilterId { get; set; }

    /// <summary>
    /// Block for destination_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    [TerraformProperty("destination_port_range")]
    public TerraformList<TerraformBlock<AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock>>? DestinationPortRange { get; set; }

    /// <summary>
    /// Block for source_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    [TerraformProperty("source_port_range")]
    public TerraformList<TerraformBlock<AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock>>? SourcePortRange { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
