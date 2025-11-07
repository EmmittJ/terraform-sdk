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
    public TerraformProperty<string>? HostedZoneId
    {
        get => GetProperty<TerraformProperty<string>>("hosted_zone_id");
        set => this.WithProperty("hosted_zone_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? TrafficPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("traffic_policy_id");
        set => this.WithProperty("traffic_policy_id", value);
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    public TerraformProperty<double>? TrafficPolicyVersion
    {
        get => GetProperty<TerraformProperty<double>>("traffic_policy_version");
        set => this.WithProperty("traffic_policy_version", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
