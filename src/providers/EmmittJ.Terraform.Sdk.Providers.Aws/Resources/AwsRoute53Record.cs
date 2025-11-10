using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alias in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordAliasBlock : TerraformBlock
{
    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluateTargetHealth is required")]
    public required TerraformProperty<bool> EvaluateTargetHealth
    {
        set => SetProperty("evaluate_target_health", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        set => SetProperty("zone_id", value);
    }

}

/// <summary>
/// Block type for cidr_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordCidrRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformProperty<string> CollectionId
    {
        set => SetProperty("collection_id", value);
    }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    public required TerraformProperty<string> LocationName
    {
        set => SetProperty("location_name", value);
    }

}

/// <summary>
/// Block type for failover_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordFailoverRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for geolocation_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeolocationRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformProperty<string>? Continent
    {
        set => SetProperty("continent", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformProperty<string>? Country
    {
        set => SetProperty("country", value);
    }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    public TerraformProperty<string>? Subdivision
    {
        set => SetProperty("subdivision", value);
    }

}

/// <summary>
/// Block type for geoproximity_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeoproximityRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string>? AwsRegion
    {
        set => SetProperty("aws_region", value);
    }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    public TerraformProperty<double>? Bias
    {
        set => SetProperty("bias", value);
    }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    public TerraformProperty<string>? LocalZoneGroup
    {
        set => SetProperty("local_zone_group", value);
    }

}

/// <summary>
/// Block type for latency_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordLatencyRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformProperty<string> Region
    {
        set => SetProperty("region", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for weighted_routing_policy in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordWeightedRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<double> Weight
    {
        set => SetProperty("weight", value);
    }

}

/// <summary>
/// Manages a aws_route53_record resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRoute53Record : TerraformResource
{
    public AwsRoute53Record(string name) : base("aws_route53_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fqdn");
        SetOutput("allow_overwrite");
        SetOutput("health_check_id");
        SetOutput("id");
        SetOutput("multivalue_answer_routing_policy");
        SetOutput("name");
        SetOutput("records");
        SetOutput("set_identifier");
        SetOutput("ttl");
        SetOutput("type");
        SetOutput("zone_id");
    }

    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    public TerraformProperty<bool> AllowOverwrite
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_overwrite");
        set => SetProperty("allow_overwrite", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformProperty<string> HealthCheckId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("health_check_id");
        set => SetProperty("health_check_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public TerraformProperty<bool> MultivalueAnswerRoutingPolicy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("multivalue_answer_routing_policy");
        set => SetProperty("multivalue_answer_routing_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The records attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Records
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("records");
        set => SetProperty("records", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformProperty<string> SetIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("set_identifier");
        set => SetProperty("set_identifier", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double> Ttl
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ttl");
        set => SetProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_id");
        set => SetProperty("zone_id", value);
    }

    /// <summary>
    /// Block for alias.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alias block(s) allowed")]
    public List<AwsRoute53RecordAliasBlock>? Alias
    {
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// Block for cidr_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordCidrRoutingPolicyBlock>? CidrRoutingPolicy
    {
        set => SetProperty("cidr_routing_policy", value);
    }

    /// <summary>
    /// Block for failover_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordFailoverRoutingPolicyBlock>? FailoverRoutingPolicy
    {
        set => SetProperty("failover_routing_policy", value);
    }

    /// <summary>
    /// Block for geolocation_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeolocationRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordGeolocationRoutingPolicyBlock>? GeolocationRoutingPolicy
    {
        set => SetProperty("geolocation_routing_policy", value);
    }

    /// <summary>
    /// Block for geoproximity_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoproximityRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordGeoproximityRoutingPolicyBlock>? GeoproximityRoutingPolicy
    {
        set => SetProperty("geoproximity_routing_policy", value);
    }

    /// <summary>
    /// Block for latency_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LatencyRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordLatencyRoutingPolicyBlock>? LatencyRoutingPolicy
    {
        set => SetProperty("latency_routing_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53RecordTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for weighted_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeightedRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordWeightedRoutingPolicyBlock>? WeightedRoutingPolicy
    {
        set => SetProperty("weighted_routing_policy", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
