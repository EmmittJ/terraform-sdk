using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_traffic_policy_instance resource.
/// </summary>
public partial class AwsRoute53TrafficPolicyInstance : TerraformResource
{
    public AwsRoute53TrafficPolicyInstance(string name) : base("aws_route53_traffic_policy_instance", name)
    {
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    [TerraformProperty("hosted_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostedZoneId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The traffic_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyId is required")]
    [TerraformProperty("traffic_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrafficPolicyId { get; set; }

    /// <summary>
    /// The traffic_policy_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficPolicyVersion is required")]
    [TerraformProperty("traffic_policy_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> TrafficPolicyVersion { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    [TerraformProperty("ttl")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Ttl { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
