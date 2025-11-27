using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_traffic_policy_instance Terraform resource.
/// Manages a aws_route53_traffic_policy_instance resource.
/// </summary>
public partial class AwsRoute53TrafficPolicyInstance(string name) : TerraformResource("aws_route53_traffic_policy_instance", name)
{
    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformValue<string> HostedZoneId
    {
        get => new TerraformReference<string>(this, "hosted_zone_id");
        set => SetArgument("hosted_zone_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyId is required")]
    public required TerraformValue<string> TrafficPolicyId
    {
        get => new TerraformReference<string>(this, "traffic_policy_id");
        set => SetArgument("traffic_policy_id", value);
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyVersion is required")]
    public required TerraformValue<double> TrafficPolicyVersion
    {
        get => new TerraformReference<double>(this, "traffic_policy_version");
        set => SetArgument("traffic_policy_version", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
