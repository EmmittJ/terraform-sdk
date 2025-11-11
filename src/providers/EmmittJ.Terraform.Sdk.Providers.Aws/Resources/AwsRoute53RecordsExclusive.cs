using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_record_set in .
/// Nesting mode: set
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlock
{
    /// <summary>
    /// The failover attribute.
    /// </summary>
    [TerraformPropertyName("failover")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Failover { get; set; }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    [TerraformPropertyName("health_check_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HealthCheckId { get; set; }

    /// <summary>
    /// The multi_value_answer attribute.
    /// </summary>
    [TerraformPropertyName("multi_value_answer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MultiValueAnswer { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    [TerraformPropertyName("set_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SetIdentifier { get; set; }

    /// <summary>
    /// The traffic_policy_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("traffic_policy_instance_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TrafficPolicyInstanceId { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ttl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordsExclusiveTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53_records_exclusive resource.
/// </summary>
public class AwsRoute53RecordsExclusive : TerraformResource
{
    public AwsRoute53RecordsExclusive(string name) : base("aws_route53_records_exclusive", name)
    {
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformPropertyName("zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for resource_record_set.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("resource_record_set")]
    public TerraformSet<TerraformBlock<AwsRoute53RecordsExclusiveResourceRecordSetBlock>>? ResourceRecordSet { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRoute53RecordsExclusiveTimeoutsBlock>? Timeouts { get; set; }

}
