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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformProperty<string> HostedZoneId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hosted_zone_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyId is required")]
    public required TerraformProperty<string> TrafficPolicyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("traffic_policy_id");
        set => this.WithProperty("traffic_policy_id", value);
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyVersion is required")]
    public required TerraformProperty<double> TrafficPolicyVersion
    {
        get => GetRequiredProperty<TerraformProperty<double>>("traffic_policy_version");
        set => this.WithProperty("traffic_policy_version", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformProperty<double> Ttl
    {
        get => GetRequiredProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
