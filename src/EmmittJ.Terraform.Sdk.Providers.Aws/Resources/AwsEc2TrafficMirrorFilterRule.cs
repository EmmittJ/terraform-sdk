using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_traffic_mirror_filter_rule resource.
/// </summary>
public class AwsEc2TrafficMirrorFilterRule : TerraformResource
{
    public AwsEc2TrafficMirrorFilterRule(string name) : base("aws_ec2_traffic_mirror_filter_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<double>? Protocol
    {
        get => GetProperty<TerraformProperty<double>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    public TerraformProperty<string>? RuleAction
    {
        get => GetProperty<TerraformProperty<string>>("rule_action");
        set => this.WithProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    public TerraformProperty<double>? RuleNumber
    {
        get => GetProperty<TerraformProperty<double>>("rule_number");
        set => this.WithProperty("rule_number", value);
    }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("source_cidr_block");
        set => this.WithProperty("source_cidr_block", value);
    }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficDirection
    {
        get => GetProperty<TerraformProperty<string>>("traffic_direction");
        set => this.WithProperty("traffic_direction", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficMirrorFilterId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_mirror_filter_id");
        set => this.WithProperty("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
