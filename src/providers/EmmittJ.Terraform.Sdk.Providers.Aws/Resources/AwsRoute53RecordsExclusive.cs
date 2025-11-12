using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_record_set in .
/// Nesting mode: set
/// </summary>
public partial class AwsRoute53RecordsExclusiveResourceRecordSetBlock() : TerraformBlock("resource_record_set")
{
    /// <summary>
    /// The failover attribute.
    /// </summary>
    [TerraformProperty("failover")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Failover { get; set; }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    [TerraformProperty("health_check_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HealthCheckId { get; set; }

    /// <summary>
    /// The multi_value_answer attribute.
    /// </summary>
    [TerraformProperty("multi_value_answer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultiValueAnswer { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    [TerraformProperty("set_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SetIdentifier { get; set; }

    /// <summary>
    /// The traffic_policy_instance_id attribute.
    /// </summary>
    [TerraformProperty("traffic_policy_instance_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TrafficPolicyInstanceId { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Ttl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53RecordsExclusiveTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_route53_records_exclusive resource.
/// </summary>
public partial class AwsRoute53RecordsExclusive : TerraformResource
{
    public AwsRoute53RecordsExclusive(string name) : base("aws_route53_records_exclusive", name)
    {
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformProperty("zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for resource_record_set.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("resource_record_set")]
    public TerraformSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock> ResourceRecordSet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRoute53RecordsExclusiveTimeoutsBlock Timeouts { get; set; } = new();

}
