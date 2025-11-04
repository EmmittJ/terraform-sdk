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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_cidr_block attribute.
    /// </summary>
    public string? DestinationCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_cidr_block")?.Value;
        set => this.WithProperty("destination_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public double? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<double>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The rule_action attribute.
    /// </summary>
    public string? RuleAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_action")?.Value;
        set => this.WithProperty("rule_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    public double? RuleNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("rule_number")?.Value;
        set => this.WithProperty("rule_number", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The source_cidr_block attribute.
    /// </summary>
    public string? SourceCidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_cidr_block")?.Value;
        set => this.WithProperty("source_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The traffic_direction attribute.
    /// </summary>
    public string? TrafficDirection
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_direction")?.Value;
        set => this.WithProperty("traffic_direction", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The traffic_mirror_filter_id attribute.
    /// </summary>
    public string? TrafficMirrorFilterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_mirror_filter_id")?.Value;
        set => this.WithProperty("traffic_mirror_filter_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
