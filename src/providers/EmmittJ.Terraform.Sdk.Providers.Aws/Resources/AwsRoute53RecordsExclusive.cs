using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_record_set in AwsRoute53RecordsExclusive.
/// Nesting mode: set
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_record_set";

    /// <summary>
    /// The failover attribute.
    /// </summary>
    public TerraformValue<string>? Failover
    {
        get => GetArgument<TerraformValue<string>>("failover");
        set => SetArgument("failover", value);
    }

    /// <summary>
    /// The health_check_id attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheckId
    {
        get => GetArgument<TerraformValue<string>>("health_check_id");
        set => SetArgument("health_check_id", value);
    }

    /// <summary>
    /// The multi_value_answer attribute.
    /// </summary>
    public TerraformValue<bool>? MultiValueAnswer
    {
        get => GetArgument<TerraformValue<bool>>("multi_value_answer");
        set => SetArgument("multi_value_answer", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The set_identifier attribute.
    /// </summary>
    public TerraformValue<string>? SetIdentifier
    {
        get => GetArgument<TerraformValue<string>>("set_identifier");
        set => SetArgument("set_identifier", value);
    }

    /// <summary>
    /// The traffic_policy_instance_id attribute.
    /// </summary>
    public TerraformValue<string>? TrafficPolicyInstanceId
    {
        get => GetArgument<TerraformValue<string>>("traffic_policy_instance_id");
        set => SetArgument("traffic_policy_instance_id", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// AliasTarget block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockAliasTargetBlock>? AliasTarget
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockAliasTargetBlock>>("alias_target");
        set => SetArgument("alias_target", value);
    }

    /// <summary>
    /// CidrRoutingConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockCidrRoutingConfigBlock>? CidrRoutingConfig
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockCidrRoutingConfigBlock>>("cidr_routing_config");
        set => SetArgument("cidr_routing_config", value);
    }

    /// <summary>
    /// Geolocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeolocationBlock>? Geolocation
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeolocationBlock>>("geolocation");
        set => SetArgument("geolocation", value);
    }

    /// <summary>
    /// GeoproximityLocation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlock>? GeoproximityLocation
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlock>>("geoproximity_location");
        set => SetArgument("geoproximity_location", value);
    }

    /// <summary>
    /// ResourceRecords block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockResourceRecordsBlock>? ResourceRecords
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockResourceRecordsBlock>>("resource_records");
        set => SetArgument("resource_records", value);
    }

}

/// <summary>
/// Block type for alias_target in AwsRoute53RecordsExclusiveResourceRecordSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockAliasTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alias_target";

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsName is required")]
    public required TerraformValue<string> DnsName
    {
        get => GetArgument<TerraformValue<string>>("dns_name");
        set => SetArgument("dns_name", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluateTargetHealth is required")]
    public required TerraformValue<bool> EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostedZoneId is required")]
    public required TerraformValue<string> HostedZoneId
    {
        get => GetArgument<TerraformValue<string>>("hosted_zone_id");
        set => SetArgument("hosted_zone_id", value);
    }

}

/// <summary>
/// Block type for cidr_routing_config in AwsRoute53RecordsExclusiveResourceRecordSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockCidrRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cidr_routing_config";

    /// <summary>
    /// The collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionId is required")]
    public required TerraformValue<string> CollectionId
    {
        get => GetArgument<TerraformValue<string>>("collection_id");
        set => SetArgument("collection_id", value);
    }

    /// <summary>
    /// The location_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationName is required")]
    public required TerraformValue<string> LocationName
    {
        get => GetArgument<TerraformValue<string>>("location_name");
        set => SetArgument("location_name", value);
    }

}

/// <summary>
/// Block type for geolocation in AwsRoute53RecordsExclusiveResourceRecordSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockGeolocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geolocation";

    /// <summary>
    /// The continent_code attribute.
    /// </summary>
    public TerraformValue<string>? ContinentCode
    {
        get => GetArgument<TerraformValue<string>>("continent_code");
        set => SetArgument("continent_code", value);
    }

    /// <summary>
    /// The country_code attribute.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// The subdivision_code attribute.
    /// </summary>
    public TerraformValue<string>? SubdivisionCode
    {
        get => GetArgument<TerraformValue<string>>("subdivision_code");
        set => SetArgument("subdivision_code", value);
    }

}

/// <summary>
/// Block type for geoproximity_location in AwsRoute53RecordsExclusiveResourceRecordSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geoproximity_location";

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformValue<string>? AwsRegion
    {
        get => GetArgument<TerraformValue<string>>("aws_region");
        set => SetArgument("aws_region", value);
    }

    /// <summary>
    /// The bias attribute.
    /// </summary>
    public TerraformValue<double>? Bias
    {
        get => GetArgument<TerraformValue<double>>("bias");
        set => SetArgument("bias", value);
    }

    /// <summary>
    /// The local_zone_group attribute.
    /// </summary>
    public TerraformValue<string>? LocalZoneGroup
    {
        get => GetArgument<TerraformValue<string>>("local_zone_group");
        set => SetArgument("local_zone_group", value);
    }

    /// <summary>
    /// Coordinates block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlockCoordinatesBlock>? Coordinates
    {
        get => GetArgument<TerraformList<AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlockCoordinatesBlock>>("coordinates");
        set => SetArgument("coordinates", value);
    }

}

/// <summary>
/// Block type for coordinates in AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockGeoproximityLocationBlockCoordinatesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("latitude");
        set => SetArgument("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Longitude is required")]
    public required TerraformValue<string> Longitude
    {
        get => GetArgument<TerraformValue<string>>("longitude");
        set => SetArgument("longitude", value);
    }

}

/// <summary>
/// Block type for resource_records in AwsRoute53RecordsExclusiveResourceRecordSetBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53RecordsExclusiveResourceRecordSetBlockResourceRecordsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_records";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53RecordsExclusive.
/// Nesting mode: single
/// </summary>
public class AwsRoute53RecordsExclusiveTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_route53_records_exclusive Terraform resource.
/// Manages a aws_route53_records_exclusive resource.
/// </summary>
public partial class AwsRoute53RecordsExclusive(string name) : TerraformResource("aws_route53_records_exclusive", name)
{
    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneId is required")]
    public required TerraformValue<string> ZoneId
    {
        get => GetArgument<TerraformValue<string>>("zone_id");
        set => SetArgument("zone_id", value);
    }

    /// <summary>
    /// ResourceRecordSet block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock>? ResourceRecordSet
    {
        get => GetArgument<TerraformSet<AwsRoute53RecordsExclusiveResourceRecordSetBlock>>("resource_record_set");
        set => SetArgument("resource_record_set", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53RecordsExclusiveTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53RecordsExclusiveTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
