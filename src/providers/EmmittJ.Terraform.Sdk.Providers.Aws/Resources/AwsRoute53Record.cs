using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alias in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordAliasBlock
{
    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluateTargetHealth is required")]
    [TerraformPropertyName("evaluate_target_health")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EvaluateTargetHealth { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformPropertyName("zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ZoneId { get; set; }

}

/// <summary>
/// Block type for cidr_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordCidrRoutingPolicyBlock
{
    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformPropertyName("collection_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    [TerraformPropertyName("location_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LocationName { get; set; }

}

/// <summary>
/// Block type for failover_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordFailoverRoutingPolicyBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for geolocation_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeolocationRoutingPolicyBlock
{
    /// <summary>
    /// The continent attribute.
    /// </summary>
    [TerraformPropertyName("continent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Continent { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    [TerraformPropertyName("subdivision")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subdivision { get; set; }

}

/// <summary>
/// Block type for geoproximity_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeoproximityRoutingPolicyBlock
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformPropertyName("aws_region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AwsRegion { get; set; }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    [TerraformPropertyName("bias")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Bias { get; set; }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    [TerraformPropertyName("local_zone_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalZoneGroup { get; set; }

}

/// <summary>
/// Block type for latency_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordLatencyRoutingPolicyBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for weighted_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordWeightedRoutingPolicyBlock
{
    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    [TerraformPropertyName("weight")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Weight { get; set; }

}

/// <summary>
/// Manages a aws_route53_record resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53Record : TerraformResource
{
    public AwsRoute53Record(string name) : base("aws_route53_record", name)
    {
    }

    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    [TerraformPropertyName("allow_overwrite")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AllowOverwrite { get; set; } = default!;

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    [TerraformPropertyName("health_check_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HealthCheckId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("multivalue_answer_routing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The records attribute.
    /// </summary>
    [TerraformPropertyName("records")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Records { get; set; }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    [TerraformPropertyName("set_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SetIdentifier { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Ttl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformPropertyName("zone_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for alias.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alias block(s) allowed")]
    [TerraformPropertyName("alias")]
    public TerraformList<TerraformBlock<AwsRoute53RecordAliasBlock>>? Alias { get; set; }

    /// <summary>
    /// Block for cidr_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("cidr_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordCidrRoutingPolicyBlock>>? CidrRoutingPolicy { get; set; }

    /// <summary>
    /// Block for failover_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("failover_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordFailoverRoutingPolicyBlock>>? FailoverRoutingPolicy { get; set; }

    /// <summary>
    /// Block for geolocation_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeolocationRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("geolocation_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordGeolocationRoutingPolicyBlock>>? GeolocationRoutingPolicy { get; set; }

    /// <summary>
    /// Block for geoproximity_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoproximityRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("geoproximity_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordGeoproximityRoutingPolicyBlock>>? GeoproximityRoutingPolicy { get; set; }

    /// <summary>
    /// Block for latency_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LatencyRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("latency_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordLatencyRoutingPolicyBlock>>? LatencyRoutingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRoute53RecordTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for weighted_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeightedRoutingPolicy block(s) allowed")]
    [TerraformPropertyName("weighted_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordWeightedRoutingPolicyBlock>>? WeightedRoutingPolicy { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

}
