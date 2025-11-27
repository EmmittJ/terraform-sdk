using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alias in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordAliasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alias";

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluateTargetHealth is required")]
    public required TerraformValue<bool> EvaluateTargetHealth
    {
        get => new TerraformReference<bool>(this, "evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

}


/// <summary>
/// Block type for cidr_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordCidrRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_routing_policy";

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformValue<string> CollectionId
    {
        get => new TerraformReference<string>(this, "collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    public required TerraformValue<string> LocationName
    {
        get => new TerraformReference<string>(this, "location_name");
        set => SetArgument("location_name", value);
    }

}


/// <summary>
/// Block type for failover_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordFailoverRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_routing_policy";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for geolocation_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeolocationRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geolocation_routing_policy";

    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformValue<string>? Continent
    {
        get => new TerraformReference<string>(this, "continent");
        set => SetArgument("continent", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => new TerraformReference<string>(this, "country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    public TerraformValue<string>? Subdivision
    {
        get => new TerraformReference<string>(this, "subdivision");
        set => SetArgument("subdivision", value);
    }

}


/// <summary>
/// Block type for geoproximity_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordGeoproximityRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geoproximity_routing_policy";

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string>? AwsRegion
    {
        get => new TerraformReference<string>(this, "aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    public TerraformValue<double>? Bias
    {
        get => new TerraformReference<double>(this, "bias");
        set => SetArgument("bias", value);
    }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    public TerraformValue<string>? LocalZoneGroup
    {
        get => new TerraformReference<string>(this, "local_zone_group");
        set => SetArgument("local_zone_group", value);
    }

    /// <summary>
    /// Coordinates block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53RecordGeoproximityRoutingPolicyBlockCoordinatesBlock>? Coordinates
    {
        get => GetArgument<TerraformSet<AwsRoute53RecordGeoproximityRoutingPolicyBlockCoordinatesBlock>>("coordinates");
        set => SetArgument("coordinates", value);
    }

}

/// <summary>
/// Block type for coordinates in AwsRoute53RecordGeoproximityRoutingPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsRoute53RecordGeoproximityRoutingPolicyBlockCoordinatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "coordinates";

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Latitude is required")]
    public required TerraformValue<string> Latitude
    {
        get => new TerraformReference<string>(this, "latitude");
        set => SetArgument("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Longitude is required")]
    public required TerraformValue<string> Longitude
    {
        get => new TerraformReference<string>(this, "longitude");
        set => SetArgument("longitude", value);
    }

}


/// <summary>
/// Block type for latency_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordLatencyRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "latency_routing_policy";

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53Record.
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for weighted_routing_policy in AwsRoute53Record.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordWeightedRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weighted_routing_policy";

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Represents a aws_route53_record Terraform resource.
/// Manages a aws_route53_record resource.
/// </summary>
public partial class AwsRoute53Record(string name) : TerraformResource("aws_route53_record", name)
{
    /// <summary>
    /// The allow_overwrite attribute.
    /// </summary>
    public TerraformValue<bool> AllowOverwrite
    {
        get => new TerraformReference<bool>(this, "allow_overwrite");
        set => SetArgument("allow_overwrite", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckId
    {
        get => new TerraformReference<string>(this, "health_check_id");
        set => SetArgument("health_check_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The multivalue_answer_routing_policy attribute.
    /// </summary>
    public TerraformValue<bool>? MultivalueAnswerRoutingPolicy
    {
        get => new TerraformReference<bool>(this, "multivalue_answer_routing_policy");
        set => SetArgument("multivalue_answer_routing_policy", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The records attribute.
    /// </summary>
    public TerraformSet<string>? Records
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "records").ResolveNodes(ctx));
        set => SetArgument("records", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SetIdentifier
    {
        get => new TerraformReference<string>(this, "set_identifier");
        set => SetArgument("set_identifier", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// Alias block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Alias block(s) allowed")]
    public TerraformList<AwsRoute53RecordAliasBlock>? Alias
    {
        get => GetArgument<TerraformList<AwsRoute53RecordAliasBlock>>("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// CidrRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CidrRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordCidrRoutingPolicyBlock>? CidrRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordCidrRoutingPolicyBlock>>("cidr_routing_policy");
        set => SetArgument("cidr_routing_policy", value);
    }

    /// <summary>
    /// FailoverRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordFailoverRoutingPolicyBlock>? FailoverRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordFailoverRoutingPolicyBlock>>("failover_routing_policy");
        set => SetArgument("failover_routing_policy", value);
    }

    /// <summary>
    /// GeolocationRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeolocationRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordGeolocationRoutingPolicyBlock>? GeolocationRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordGeolocationRoutingPolicyBlock>>("geolocation_routing_policy");
        set => SetArgument("geolocation_routing_policy", value);
    }

    /// <summary>
    /// GeoproximityRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GeoproximityRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordGeoproximityRoutingPolicyBlock>? GeoproximityRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordGeoproximityRoutingPolicyBlock>>("geoproximity_routing_policy");
        set => SetArgument("geoproximity_routing_policy", value);
    }

    /// <summary>
    /// LatencyRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LatencyRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordLatencyRoutingPolicyBlock>? LatencyRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordLatencyRoutingPolicyBlock>>("latency_routing_policy");
        set => SetArgument("latency_routing_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53RecordTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53RecordTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WeightedRoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeightedRoutingPolicy block(s) allowed")]
    public TerraformList<AwsRoute53RecordWeightedRoutingPolicyBlock>? WeightedRoutingPolicy
    {
        get => GetArgument<TerraformList<AwsRoute53RecordWeightedRoutingPolicyBlock>>("weighted_routing_policy");
        set => SetArgument("weighted_routing_policy", value);
    }

}
