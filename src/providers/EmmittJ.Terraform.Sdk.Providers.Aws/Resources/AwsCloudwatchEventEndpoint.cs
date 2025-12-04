using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_bus in AwsCloudwatchEventEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointEventBusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_bus";

    /// <summary>
    /// The event_bus_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventBusArn is required")]
    public required TerraformValue<string> EventBusArn
    {
        get => GetArgument<TerraformValue<string>>("event_bus_arn");
        set => SetArgument("event_bus_arn", value);
    }

}


/// <summary>
/// Block type for replication_config in AwsCloudwatchEventEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointReplicationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_config";

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for routing_config in AwsCloudwatchEventEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_config";

    /// <summary>
    /// FailoverConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FailoverConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FailoverConfig block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlock> FailoverConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlock>>("failover_config");
        set => SetArgument("failover_config", value);
    }

}

/// <summary>
/// Block type for failover_config in AwsCloudwatchEventEndpointRoutingConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "failover_config";

    /// <summary>
    /// Primary block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Primary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Primary block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockPrimaryBlock> Primary
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockPrimaryBlock>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// Secondary block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secondary is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secondary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Secondary block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockSecondaryBlock> Secondary
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockSecondaryBlock>>("secondary");
        set => SetArgument("secondary", value);
    }

}

/// <summary>
/// Block type for primary in AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockPrimaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary";

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
/// Block type for secondary in AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventEndpointRoutingConfigBlockFailoverConfigBlockSecondaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secondary";

    /// <summary>
    /// The route attribute.
    /// </summary>
    public TerraformValue<string>? Route
    {
        get => GetArgument<TerraformValue<string>>("route");
        set => SetArgument("route", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_event_endpoint Terraform resource.
/// Manages a aws_cloudwatch_event_endpoint resource.
/// </summary>
public partial class AwsCloudwatchEventEndpoint(string name) : TerraformResource("aws_cloudwatch_event_endpoint", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The endpoint_url attribute.
    /// </summary>
    public TerraformValue<string> EndpointUrl
        => AsReference("endpoint_url");

    /// <summary>
    /// EventBus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 EventBus block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 EventBus block(s) allowed")]
    public TerraformList<AwsCloudwatchEventEndpointEventBusBlock>? EventBus
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventEndpointEventBusBlock>>("event_bus");
        set => SetArgument("event_bus", value);
    }

    /// <summary>
    /// ReplicationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfig block(s) allowed")]
    public TerraformList<AwsCloudwatchEventEndpointReplicationConfigBlock>? ReplicationConfig
    {
        get => GetArgument<TerraformList<AwsCloudwatchEventEndpointReplicationConfigBlock>>("replication_config");
        set => SetArgument("replication_config", value);
    }

    /// <summary>
    /// RoutingConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingConfig block(s) allowed")]
    public required TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlock> RoutingConfig
    {
        get => GetRequiredArgument<TerraformList<AwsCloudwatchEventEndpointRoutingConfigBlock>>("routing_config");
        set => SetArgument("routing_config", value);
    }

}
