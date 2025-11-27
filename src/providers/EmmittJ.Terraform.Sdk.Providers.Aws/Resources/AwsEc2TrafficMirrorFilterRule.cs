using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_port_range in AwsEc2TrafficMirrorFilterRule.
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Block type for source_port_range in AwsEc2TrafficMirrorFilterRule.
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_port_range";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformValue<double>? FromPort
    {
        get => new TerraformReference<double>(this, "from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => new TerraformReference<double>(this, "to_port");
        set => SetArgument("to_port", value);
    }

}


/// <summary>
/// Represents a aws_ec2_traffic_mirror_filter_rule Terraform resource.
/// Manages a aws_ec2_traffic_mirror_filter_rule resource.
/// </summary>
public partial class AwsEc2TrafficMirrorFilterRule(string name) : TerraformResource("aws_ec2_traffic_mirror_filter_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformValue<string> DestinationCidrBlock
    {
        get => new TerraformReference<string>(this, "destination_cidr_block");
        set => SetArgument("destination_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<double>? Protocol
    {
        get => new TerraformReference<double>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => new TerraformReference<string>(this, "rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => new TerraformReference<double>(this, "rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCidrBlock is required")]
    public required TerraformValue<string> SourceCidrBlock
    {
        get => new TerraformReference<string>(this, "source_cidr_block");
        set => SetArgument("source_cidr_block", value);
    }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficDirection is required")]
    public required TerraformValue<string> TrafficDirection
    {
        get => new TerraformReference<string>(this, "traffic_direction");
        set => SetArgument("traffic_direction", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    public required TerraformValue<string> TrafficMirrorFilterId
    {
        get => new TerraformReference<string>(this, "traffic_mirror_filter_id");
        set => SetArgument("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// DestinationPortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    public TerraformList<AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock>? DestinationPortRange
    {
        get => GetArgument<TerraformList<AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock>>("destination_port_range");
        set => SetArgument("destination_port_range", value);
    }

    /// <summary>
    /// SourcePortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    public TerraformList<AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock>? SourcePortRange
    {
        get => GetArgument<TerraformList<AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock>>("source_port_range");
        set => SetArgument("source_port_range", value);
    }

}
