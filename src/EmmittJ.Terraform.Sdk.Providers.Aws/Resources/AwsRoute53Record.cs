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
        get => GetProperty<TerraformProperty<bool>>("evaluate_target_health");
        set => WithProperty("evaluate_target_health", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => WithProperty("zone_id", value);
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
        get => GetProperty<TerraformProperty<string>>("collection_id");
        set => WithProperty("collection_id", value);
    }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    public required TerraformProperty<string> LocationName
    {
        get => GetProperty<TerraformProperty<string>>("location_name");
        set => WithProperty("location_name", value);
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
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("continent");
        set => WithProperty("continent", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformProperty<string>? Country
    {
        get => GetProperty<TerraformProperty<string>>("country");
        set => WithProperty("country", value);
    }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    public TerraformProperty<string>? Subdivision
    {
        get => GetProperty<TerraformProperty<string>>("subdivision");
        set => WithProperty("subdivision", value);
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
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => WithProperty("aws_region", value);
    }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    public TerraformProperty<double>? Bias
    {
        get => GetProperty<TerraformProperty<double>>("bias");
        set => WithProperty("bias", value);
    }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    public TerraformProperty<string>? LocalZoneGroup
    {
        get => GetProperty<TerraformProperty<string>>("local_zone_group");
        set => WithProperty("local_zone_group", value);
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
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
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
        this.DeclareOutput("fqdn");
    }

    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowOverwrite
    {
        get => GetProperty<TerraformProperty<bool>>("allow_overwrite");
        set => this.WithProperty("allow_overwrite", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformProperty<string>? HealthCheckId
    {
        get => GetProperty<TerraformProperty<string>>("health_check_id");
        set => this.WithProperty("health_check_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public TerraformProperty<bool>? MultivalueAnswerRoutingPolicy
    {
        get => GetProperty<TerraformProperty<bool>>("multivalue_answer_routing_policy");
        set => this.WithProperty("multivalue_answer_routing_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The records attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Records
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("records");
        set => this.WithProperty("records", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? SetIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("set_identifier");
        set => this.WithProperty("set_identifier", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformProperty<string> ZoneId
    {
        get => GetProperty<TerraformProperty<string>>("zone_id");
        set => this.WithProperty("zone_id", value);
    }

    /// <summary>
    /// Block for alias.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alias block(s) allowed")]
    public List<AwsRoute53RecordAliasBlock>? Alias
    {
        get => GetProperty<List<AwsRoute53RecordAliasBlock>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// Block for cidr_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordCidrRoutingPolicyBlock>? CidrRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordCidrRoutingPolicyBlock>>("cidr_routing_policy");
        set => this.WithProperty("cidr_routing_policy", value);
    }

    /// <summary>
    /// Block for failover_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordFailoverRoutingPolicyBlock>? FailoverRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordFailoverRoutingPolicyBlock>>("failover_routing_policy");
        set => this.WithProperty("failover_routing_policy", value);
    }

    /// <summary>
    /// Block for geolocation_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeolocationRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordGeolocationRoutingPolicyBlock>? GeolocationRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordGeolocationRoutingPolicyBlock>>("geolocation_routing_policy");
        set => this.WithProperty("geolocation_routing_policy", value);
    }

    /// <summary>
    /// Block for geoproximity_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoproximityRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordGeoproximityRoutingPolicyBlock>? GeoproximityRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordGeoproximityRoutingPolicyBlock>>("geoproximity_routing_policy");
        set => this.WithProperty("geoproximity_routing_policy", value);
    }

    /// <summary>
    /// Block for latency_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LatencyRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordLatencyRoutingPolicyBlock>? LatencyRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordLatencyRoutingPolicyBlock>>("latency_routing_policy");
        set => this.WithProperty("latency_routing_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53RecordTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53RecordTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for weighted_routing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeightedRoutingPolicy block(s) allowed")]
    public List<AwsRoute53RecordWeightedRoutingPolicyBlock>? WeightedRoutingPolicy
    {
        get => GetProperty<List<AwsRoute53RecordWeightedRoutingPolicyBlock>>("weighted_routing_policy");
        set => this.WithProperty("weighted_routing_policy", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
