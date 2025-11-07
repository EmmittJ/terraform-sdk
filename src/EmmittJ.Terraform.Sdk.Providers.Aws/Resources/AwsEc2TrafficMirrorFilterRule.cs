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
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block");
        set => this.WithProperty("destination_cidr_block", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<double>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RuleAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_action");
        set => this.WithProperty("rule_action", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RuleNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rule_number");
        set => this.WithProperty("rule_number", value);
    }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_cidr_block");
        set => this.WithProperty("source_cidr_block", value);
    }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrafficDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_direction");
        set => this.WithProperty("traffic_direction", value);
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrafficMirrorFilterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_mirror_filter_id");
        set => this.WithProperty("traffic_mirror_filter_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
