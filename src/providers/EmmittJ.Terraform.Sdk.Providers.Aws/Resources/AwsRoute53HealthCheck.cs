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
    public TerraformProperty<TerraformProperty<double>>? ChildHealthThreshold { get; set; }

    /// <summary>
    /// The child_healthchecks attribute.
    /// </summary>
    [TerraformPropertyName("child_healthchecks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ChildHealthchecks { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_name attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_alarm_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudwatchAlarmName { get; set; }

    /// <summary>
    /// The cloudwatch_alarm_region attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_alarm_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudwatchAlarmRegion { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// The enable_sni attribute.
    /// </summary>
    [TerraformPropertyName("enable_sni")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableSni { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_sni");

    /// <summary>
    /// The failure_threshold attribute.
    /// </summary>
    [TerraformPropertyName("failure_threshold")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> FailureThreshold { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "failure_threshold");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Fqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The insufficient_data_health_status attribute.
    /// </summary>
    [TerraformPropertyName("insufficient_data_health_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InsufficientDataHealthStatus { get; set; }

    /// <summary>
    /// The invert_healthcheck attribute.
    /// </summary>
    [TerraformPropertyName("invert_healthcheck")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InvertHealthcheck { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddress { get; set; }

    /// <summary>
    /// The measure_latency attribute.
    /// </summary>
    [TerraformPropertyName("measure_latency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MeasureLatency { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The reference_name attribute.
    /// </summary>
    [TerraformPropertyName("reference_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReferenceName { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Regions { get; set; }

    /// <summary>
    /// The request_interval attribute.
    /// </summary>
    [TerraformPropertyName("request_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RequestInterval { get; set; }

    /// <summary>
    /// The resource_path attribute.
    /// </summary>
    [TerraformPropertyName("resource_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourcePath { get; set; }

    /// <summary>
    /// The routing_control_arn attribute.
    /// </summary>
    [TerraformPropertyName("routing_control_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoutingControlArn { get; set; }

    /// <summary>
    /// The search_string attribute.
    /// </summary>
    [TerraformPropertyName("search_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SearchString { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Triggers { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "triggers");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
