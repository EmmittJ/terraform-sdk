using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for endpoint in AwsRoute53TrafficPolicyDocumentDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for rule in AwsRoute53TrafficPolicyDocumentDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// GeoProximityLocation block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockGeoProximityLocationBlock>? GeoProximityLocation
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockGeoProximityLocationBlock>>("geo_proximity_location");
        set => SetArgument("geo_proximity_location", value);
    }

    /// <summary>
    /// Items block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockItemsBlock>? Items
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockItemsBlock>>("items");
        set => SetArgument("items", value);
    }

    /// <summary>
    /// Location block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockLocationBlock>? Location
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockLocationBlock>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Primary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Primary block(s) allowed")]
    public TerraformList<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockPrimaryBlock>? Primary
    {
        get => GetArgument<TerraformList<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockPrimaryBlock>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// Region block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockRegionBlock>? Region
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockRegionBlock>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Secondary block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secondary block(s) allowed")]
    public TerraformList<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockSecondaryBlock>? Secondary
    {
        get => GetArgument<TerraformList<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockSecondaryBlock>>("secondary");
        set => SetArgument("secondary", value);
    }

}

/// <summary>
/// Block type for geo_proximity_location in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockGeoProximityLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo_proximity_location";

    /// <summary>
    /// The bias attribute.
    /// </summary>
    public TerraformValue<string>? Bias
    {
        get => GetArgument<TerraformValue<string>>("bias");
        set => SetArgument("bias", value);
    }

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    public TerraformValue<bool>? EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// The latitude attribute.
    /// </summary>
    public TerraformValue<string>? Latitude
    {
        get => GetArgument<TerraformValue<string>>("latitude");
        set => SetArgument("latitude", value);
    }

    /// <summary>
    /// The longitude attribute.
    /// </summary>
    public TerraformValue<string>? Longitude
    {
        get => GetArgument<TerraformValue<string>>("longitude");
        set => SetArgument("longitude", value);
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
    /// The rule_reference attribute.
    /// </summary>
    public TerraformValue<string>? RuleReference
    {
        get => GetArgument<TerraformValue<string>>("rule_reference");
        set => SetArgument("rule_reference", value);
    }

}

/// <summary>
/// Block type for items in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockItemsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "items";

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

}

/// <summary>
/// Block type for location in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location";

    /// <summary>
    /// The continent attribute.
    /// </summary>
    public TerraformValue<string>? Continent
    {
        get => GetArgument<TerraformValue<string>>("continent");
        set => SetArgument("continent", value);
    }

    /// <summary>
    /// The country attribute.
    /// </summary>
    public TerraformValue<string>? Country
    {
        get => GetArgument<TerraformValue<string>>("country");
        set => SetArgument("country", value);
    }

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    public TerraformValue<bool>? EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool>? IsDefault
    {
        get => GetArgument<TerraformValue<bool>>("is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The rule_reference attribute.
    /// </summary>
    public TerraformValue<string>? RuleReference
    {
        get => GetArgument<TerraformValue<string>>("rule_reference");
        set => SetArgument("rule_reference", value);
    }

    /// <summary>
    /// The subdivision attribute.
    /// </summary>
    public TerraformValue<string>? Subdivision
    {
        get => GetArgument<TerraformValue<string>>("subdivision");
        set => SetArgument("subdivision", value);
    }

}

/// <summary>
/// Block type for primary in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockPrimaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary";

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    public TerraformValue<bool>? EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// The rule_reference attribute.
    /// </summary>
    public TerraformValue<string>? RuleReference
    {
        get => GetArgument<TerraformValue<string>>("rule_reference");
        set => SetArgument("rule_reference", value);
    }

}

/// <summary>
/// Block type for region in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "region";

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    public TerraformValue<bool>? EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
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
    /// The rule_reference attribute.
    /// </summary>
    public TerraformValue<string>? RuleReference
    {
        get => GetArgument<TerraformValue<string>>("rule_reference");
        set => SetArgument("rule_reference", value);
    }

}

/// <summary>
/// Block type for secondary in AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53TrafficPolicyDocumentDataSourceRuleBlockSecondaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary";

    /// <summary>
    /// The endpoint_reference attribute.
    /// </summary>
    public TerraformValue<string>? EndpointReference
    {
        get => GetArgument<TerraformValue<string>>("endpoint_reference");
        set => SetArgument("endpoint_reference", value);
    }

    /// <summary>
    /// The evaluate_target_health attribute.
    /// </summary>
    public TerraformValue<bool>? EvaluateTargetHealth
    {
        get => GetArgument<TerraformValue<bool>>("evaluate_target_health");
        set => SetArgument("evaluate_target_health", value);
    }

    /// <summary>
    /// The health_check attribute.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// The rule_reference attribute.
    /// </summary>
    public TerraformValue<string>? RuleReference
    {
        get => GetArgument<TerraformValue<string>>("rule_reference");
        set => SetArgument("rule_reference", value);
    }

}


/// <summary>
/// Represents a aws_route53_traffic_policy_document Terraform data source.
/// Retrieves information about a aws_route53_traffic_policy_document.
/// </summary>
public partial class AwsRoute53TrafficPolicyDocumentDataSource(string name) : TerraformDataSource("aws_route53_traffic_policy_document", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    public TerraformValue<string>? RecordType
    {
        get => GetArgument<TerraformValue<string>>("record_type");
        set => SetArgument("record_type", value);
    }

    /// <summary>
    /// The start_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? StartEndpoint
    {
        get => GetArgument<TerraformValue<string>>("start_endpoint");
        set => SetArgument("start_endpoint", value);
    }

    /// <summary>
    /// The start_rule attribute.
    /// </summary>
    public TerraformValue<string>? StartRule
    {
        get => GetArgument<TerraformValue<string>>("start_rule");
        set => SetArgument("start_rule", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
        => AsReference("json");

    /// <summary>
    /// Endpoint block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>? Endpoint
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceEndpointBlock>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// Rule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>? Rule
    {
        get => GetArgument<TerraformSet<AwsRoute53TrafficPolicyDocumentDataSourceRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
