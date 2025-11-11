using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_health_check resource.
/// </summary>
public class AwsRoute53HealthCheck : TerraformResource
{
    public AwsRoute53HealthCheck(string name) : base("aws_route53_health_check", name)
    {
    }

    /// <summary>
    /// The child_health_threshold attribute.
    /// </summary>
    [TerraformPropertyName("child_health_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ChildHealthThreshold { get; set; }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    [TerraformPropertyName("child_healthchecks")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ChildHealthchecks { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_alarm_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudwatchAlarmName { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_alarm_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudwatchAlarmRegion { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    [TerraformPropertyName("enable_sni")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableSni { get; set; } = default!;

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [TerraformPropertyName("failure_threshold")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> FailureThreshold { get; set; } = default!;

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    [TerraformPropertyName("insufficient_data_health_status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InsufficientDataHealthStatus { get; set; }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    [TerraformPropertyName("invert_healthcheck")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InvertHealthcheck { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    [TerraformPropertyName("measure_latency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MeasureLatency { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    [TerraformPropertyName("reference_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReferenceName { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    [TerraformPropertyName("request_interval")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RequestInterval { get; set; }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    [TerraformPropertyName("resource_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourcePath { get; set; }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    [TerraformPropertyName("routing_control_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoutingControlArn { get; set; }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformPropertyName("search_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SearchString { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Triggers { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
