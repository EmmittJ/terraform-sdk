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
        get => GetRequiredArgument<TerraformValue<string>>("hosted_zone_id");
        set => SetArgument("hosted_zone_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyId is required")]
    public required TerraformValue<string> TrafficPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("traffic_policy_id");
        set => SetArgument("traffic_policy_id", value);
    }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyVersion is required")]
    public required TerraformValue<double> TrafficPolicyVersion
    {
        get => GetRequiredArgument<TerraformValue<double>>("traffic_policy_version");
        set => SetArgument("traffic_policy_version", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<double> Ttl
    {
        get => GetRequiredArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
