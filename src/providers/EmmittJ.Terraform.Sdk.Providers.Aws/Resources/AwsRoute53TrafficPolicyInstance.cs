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
        SetOutput("arn");
        SetOutput("hosted_zone_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("traffic_policy_id");
        SetOutput("traffic_policy_version");
        SetOutput("ttl");
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformProperty<string> HostedZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hosted_zone_id");
        set => SetProperty("hosted_zone_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyId is required")]
    public required TerraformProperty<string> TrafficPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("traffic_policy_id");
        set => SetProperty("traffic_policy_id", value);
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyVersion is required")]
    public required TerraformProperty<double> TrafficPolicyVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("traffic_policy_version");
        set => SetProperty("traffic_policy_version", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformProperty<double> Ttl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ttl");
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
