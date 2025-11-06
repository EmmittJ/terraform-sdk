using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_traffic_policy_instance resource.
/// </summary>
public class AwsRoute53TrafficPolicyInstance : TerraformResource
{
    public AwsRoute53TrafficPolicyInstance(string name) : base("aws_route53_traffic_policy_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public string? HostedZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hosted_zone_id")?.Value;
        set => this.WithProperty("hosted_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    public string? TrafficPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("traffic_policy_id")?.Value;
        set => this.WithProperty("traffic_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    public double? TrafficPolicyVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("traffic_policy_version")?.Value;
        set => this.WithProperty("traffic_policy_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public double? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ttl")?.Value;
        set => this.WithProperty("ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
