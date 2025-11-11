using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alias in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordAliasBlock : TerraformBlockBase
{
    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluateTargetHealth is required")]
    [TerraformProperty("evaluate_target_health")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> EvaluateTargetHealth { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformProperty("zone_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ZoneId { get; set; }

}

/// <summary>
/// Block type for cidr_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordCidrRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    [TerraformProperty("collection_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CollectionId { get; set; }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    [TerraformProperty("location_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LocationName { get; set; }

}

/// <summary>
/// Block type for failover_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordFailoverRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for geolocation_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordGeolocationRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The continent attribute.
    /// </summary>
    [TerraformProperty("continent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Continent { get; set; }

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformProperty("country")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    [TerraformProperty("subdivision")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subdivision { get; set; }

}

/// <summary>
/// Block type for geoproximity_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordGeoproximityRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformProperty("aws_region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AwsRegion { get; set; }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    [TerraformProperty("bias")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Bias { get; set; }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    [TerraformProperty("local_zone_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LocalZoneGroup { get; set; }

}

/// <summary>
/// Block type for latency_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordLatencyRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRoute53RecordTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for weighted_routing_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsRoute53RecordWeightedRoutingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    [TerraformProperty("weight")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Weight { get; set; }

}

/// <summary>
/// Manages a aws_route53_record resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRoute53Record : TerraformResource
{
    public AwsRoute53Record(string name) : base("aws_route53_record", name)
    {
    }

    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    [TerraformProperty("allow_overwrite")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> AllowOverwrite { get; set; }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    [TerraformProperty("health_check_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HealthCheckId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    [TerraformProperty("multivalue_answer_routing_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MultivalueAnswerRoutingPolicy { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The records attribute.
    /// </summary>
    [TerraformProperty("records")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Records { get; set; }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    [TerraformProperty("set_identifier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SetIdentifier { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Ttl { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    [TerraformProperty("zone_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ZoneId { get; set; }

    /// <summary>
    /// Block for alias.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alias block(s) allowed")]
    [TerraformProperty("alias")]
    public TerraformList<TerraformBlock<AwsRoute53RecordAliasBlock>>? Alias { get; set; }

    /// <summary>
    /// Block for cidr_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrRoutingPolicy block(s) allowed")]
    [TerraformProperty("cidr_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordCidrRoutingPolicyBlock>>? CidrRoutingPolicy { get; set; }

    /// <summary>
    /// Block for failover_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRoutingPolicy block(s) allowed")]
    [TerraformProperty("failover_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordFailoverRoutingPolicyBlock>>? FailoverRoutingPolicy { get; set; }

    /// <summary>
    /// Block for geolocation_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeolocationRoutingPolicy block(s) allowed")]
    [TerraformProperty("geolocation_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordGeolocationRoutingPolicyBlock>>? GeolocationRoutingPolicy { get; set; }

    /// <summary>
    /// Block for geoproximity_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoproximityRoutingPolicy block(s) allowed")]
    [TerraformProperty("geoproximity_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordGeoproximityRoutingPolicyBlock>>? GeoproximityRoutingPolicy { get; set; }

    /// <summary>
    /// Block for latency_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LatencyRoutingPolicy block(s) allowed")]
    [TerraformProperty("latency_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordLatencyRoutingPolicyBlock>>? LatencyRoutingPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsRoute53RecordTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for weighted_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeightedRoutingPolicy block(s) allowed")]
    [TerraformProperty("weighted_routing_policy")]
    public TerraformList<TerraformBlock<AwsRoute53RecordWeightedRoutingPolicyBlock>>? WeightedRoutingPolicy { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fqdn { get; }

}
