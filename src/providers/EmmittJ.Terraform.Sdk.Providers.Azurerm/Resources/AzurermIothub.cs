using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cloud_to_device in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubCloudToDeviceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_to_device";

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<string>? DefaultTtl
    {
        get => GetArgument<TerraformValue<string>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// Feedback block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIothubCloudToDeviceBlockFeedbackBlock>? Feedback
    {
        get => GetArgument<TerraformList<AzurermIothubCloudToDeviceBlockFeedbackBlock>>("feedback");
        set => SetArgument("feedback", value);
    }

}

/// <summary>
/// Block type for feedback in AzurermIothubCloudToDeviceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermIothubCloudToDeviceBlockFeedbackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feedback";

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformValue<string>? LockDuration
    {
        get => GetArgument<TerraformValue<string>>("lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The time_to_live attribute.
    /// </summary>
    public TerraformValue<string>? TimeToLive
    {
        get => GetArgument<TerraformValue<string>>("time_to_live");
        set => SetArgument("time_to_live", value);
    }

}


/// <summary>
/// Block type for fallback_route in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubFallbackRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fallback_route";

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformValue<string>? Condition
    {
        get => GetArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    public TerraformList<string> EndpointNames
    {
        get => GetArgument<TerraformList<string>>("endpoint_names") ?? AsReference("endpoint_names");
        set => SetArgument("endpoint_names", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for file_upload in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubFileUploadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_upload";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformValue<string> ConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformValue<string>? DefaultTtl
    {
        get => GetArgument<TerraformValue<string>>("default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformValue<string>? LockDuration
    {
        get => GetArgument<TerraformValue<string>>("lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => GetArgument<TerraformValue<double>>("max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformValue<bool>? Notifications
    {
        get => GetArgument<TerraformValue<bool>>("notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformValue<string>? SasTtl
    {
        get => GetArgument<TerraformValue<string>>("sas_ttl");
        set => SetArgument("sas_ttl", value);
    }

}


/// <summary>
/// Block type for identity in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for network_rule_set in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubNetworkRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_rule_set";

    /// <summary>
    /// The apply_to_builtin_eventhub_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyToBuiltinEventhubEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("apply_to_builtin_eventhub_endpoint");
        set => SetArgument("apply_to_builtin_eventhub_endpoint", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAction
    {
        get => GetArgument<TerraformValue<string>>("default_action");
        set => SetArgument("default_action", value);
    }

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIothubNetworkRuleSetBlockIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AzurermIothubNetworkRuleSetBlockIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

}

/// <summary>
/// Block type for ip_rule in AzurermIothubNetworkRuleSetBlock.
/// Nesting mode: list
/// </summary>
public class AzurermIothubNetworkRuleSetBlockIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The ip_mask attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpMask is required")]
    public required TerraformValue<string> IpMask
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_mask");
        set => SetArgument("ip_mask", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for sku in AzurermIothub.
/// Nesting mode: list
/// </summary>
public class AzurermIothubSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermIothub.
/// Nesting mode: single
/// </summary>
public class AzurermIothubTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_iothub Terraform resource.
/// Manages a azurerm_iothub resource.
/// </summary>
public partial class AzurermIothub(string name) : TerraformResource("azurerm_iothub", name)
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("endpoint") ?? AsReference("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Enrichment
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("enrichment") ?? AsReference("enrichment");
        set => SetArgument("enrichment", value);
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    public TerraformValue<double>? EventHubPartitionCount
    {
        get => GetArgument<TerraformValue<double>>("event_hub_partition_count");
        set => SetArgument("event_hub_partition_count", value);
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? EventHubRetentionInDays
    {
        get => GetArgument<TerraformValue<double>>("event_hub_retention_in_days");
        set => SetArgument("event_hub_retention_in_days", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Route
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("route") ?? AsReference("route");
        set => SetArgument("route", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    public TerraformValue<string> EventHubEventsEndpoint
        => AsReference("event_hub_events_endpoint");

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    public TerraformValue<string> EventHubEventsNamespace
        => AsReference("event_hub_events_namespace");

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    public TerraformValue<string> EventHubEventsPath
        => AsReference("event_hub_events_path");

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    public TerraformValue<string> EventHubOperationsEndpoint
        => AsReference("event_hub_operations_endpoint");

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    public TerraformValue<string> EventHubOperationsPath
        => AsReference("event_hub_operations_path");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformValue<string> Hostname
        => AsReference("hostname");

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SharedAccessPolicy
        => AsReference("shared_access_policy");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// CloudToDevice block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    public TerraformList<AzurermIothubCloudToDeviceBlock>? CloudToDevice
    {
        get => GetArgument<TerraformList<AzurermIothubCloudToDeviceBlock>>("cloud_to_device");
        set => SetArgument("cloud_to_device", value);
    }

    /// <summary>
    /// FallbackRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    public TerraformList<AzurermIothubFallbackRouteBlock>? FallbackRoute
    {
        get => GetArgument<TerraformList<AzurermIothubFallbackRouteBlock>>("fallback_route");
        set => SetArgument("fallback_route", value);
    }

    /// <summary>
    /// FileUpload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    public TerraformList<AzurermIothubFileUploadBlock>? FileUpload
    {
        get => GetArgument<TerraformList<AzurermIothubFileUploadBlock>>("file_upload");
        set => SetArgument("file_upload", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermIothubIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermIothubIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// NetworkRuleSet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermIothubNetworkRuleSetBlock>? NetworkRuleSet
    {
        get => GetArgument<TerraformList<AzurermIothubNetworkRuleSetBlock>>("network_rule_set");
        set => SetArgument("network_rule_set", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermIothubSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermIothubSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
