using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_health_check resource.
/// </summary>
public partial class AwsRoute53HealthCheck : TerraformResource
{
    public AwsRoute53HealthCheck(string name) : base("aws_route53_health_check", name)
    {
    }

    /// <summary>
    /// The child_health_threshold attribute.
    /// </summary>
    [TerraformProperty("child_health_threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ChildHealthThreshold { get; set; }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    [TerraformProperty("child_healthchecks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ChildHealthchecks { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_alarm_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudwatchAlarmName { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_alarm_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudwatchAlarmRegion { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    [TerraformProperty("enable_sni")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableSni { get; set; }

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [TerraformProperty("failure_threshold")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> FailureThreshold { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    [TerraformProperty("insufficient_data_health_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InsufficientDataHealthStatus { get; set; }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    [TerraformProperty("invert_healthcheck")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InvertHealthcheck { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    [TerraformProperty("measure_latency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MeasureLatency { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    [TerraformProperty("reference_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReferenceName { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    [TerraformProperty("request_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RequestInterval { get; set; }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    [TerraformProperty("resource_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourcePath { get; set; }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    [TerraformProperty("routing_control_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoutingControlArn { get; set; }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformProperty("search_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SearchString { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Triggers { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
