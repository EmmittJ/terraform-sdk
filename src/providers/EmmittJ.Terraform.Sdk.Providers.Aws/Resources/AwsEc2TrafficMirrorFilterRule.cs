using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_port_range in .
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double>? FromPort
    {
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double>? ToPort
    {
        set => SetProperty("to_port", value);
    }

}

/// <summary>
/// Block type for source_port_range in .
/// Nesting mode: list
/// </summary>
public class AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock : TerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double>? FromPort
    {
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double>? ToPort
    {
        set => SetProperty("to_port", value);
    }

}

/// <summary>
/// Manages a aws_ec2_traffic_mirror_filter_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEc2TrafficMirrorFilterRule : TerraformResource
{
    public AwsEc2TrafficMirrorFilterRule(string name) : base("aws_ec2_traffic_mirror_filter_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("destination_cidr_block");
        SetOutput("id");
        SetOutput("protocol");
        SetOutput("region");
        SetOutput("rule_action");
        SetOutput("rule_number");
        SetOutput("source_cidr_block");
        SetOutput("traffic_direction");
        SetOutput("traffic_mirror_filter_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationCidrBlock is required")]
    public required TerraformProperty<string> DestinationCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_cidr_block");
        set => SetProperty("destination_cidr_block", value);
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
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<double> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<double>>("protocol");
        set => SetProperty("protocol", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformProperty<string> RuleAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rule_action");
        set => SetProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rule_number");
        set => SetProperty("rule_number", value);
    }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceCidrBlock is required")]
    public required TerraformProperty<string> SourceCidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_cidr_block");
        set => SetProperty("source_cidr_block", value);
    }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficDirection is required")]
    public required TerraformProperty<string> TrafficDirection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_direction");
        set => SetProperty("traffic_direction", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficMirrorFilterId is required")]
    public required TerraformProperty<string> TrafficMirrorFilterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_mirror_filter_id");
        set => SetProperty("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// Block for destination_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationPortRange block(s) allowed")]
    public List<AwsEc2TrafficMirrorFilterRuleDestinationPortRangeBlock>? DestinationPortRange
    {
        set => SetProperty("destination_port_range", value);
    }

    /// <summary>
    /// Block for source_port_range.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourcePortRange block(s) allowed")]
    public List<AwsEc2TrafficMirrorFilterRuleSourcePortRangeBlock>? SourcePortRange
    {
        set => SetProperty("source_port_range", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
