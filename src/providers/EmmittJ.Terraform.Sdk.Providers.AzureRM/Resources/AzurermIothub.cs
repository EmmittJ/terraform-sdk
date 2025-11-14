using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for cloud_to_device in .
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
    [TerraformArgument("default_ttl")]
    public TerraformValue<string>? DefaultTtl
    {
        get => new TerraformReference<string>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformArgument("max_delivery_count")]
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

}

/// <summary>
/// Block type for fallback_route in .
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
    [TerraformArgument("condition")]
    public TerraformValue<string>? Condition
    {
        get => new TerraformReference<string>(this, "condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    [TerraformArgument("endpoint_names")]
    public TerraformList<string> EndpointNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "endpoint_names").ResolveNodes(ctx));
        set => SetArgument("endpoint_names", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformArgument("source")]
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

}

/// <summary>
/// Block type for file_upload in .
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
    [TerraformArgument("authentication_type")]
    public TerraformValue<string>? AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformArgument("connection_string")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformArgument("container_name")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformArgument("default_ttl")]
    public TerraformValue<string>? DefaultTtl
    {
        get => new TerraformReference<string>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformArgument("identity_id")]
    public TerraformValue<string>? IdentityId
    {
        get => new TerraformReference<string>(this, "identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformArgument("lock_duration")]
    public TerraformValue<string>? LockDuration
    {
        get => new TerraformReference<string>(this, "lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformArgument("max_delivery_count")]
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformArgument("notifications")]
    public TerraformValue<bool>? Notifications
    {
        get => new TerraformReference<bool>(this, "notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    [TerraformArgument("sas_ttl")]
    public TerraformValue<string>? SasTtl
    {
        get => new TerraformReference<string>(this, "sas_ttl");
        set => SetArgument("sas_ttl", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for network_rule_set in .
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
    [TerraformArgument("apply_to_builtin_eventhub_endpoint")]
    public TerraformValue<bool>? ApplyToBuiltinEventhubEndpoint
    {
        get => new TerraformReference<bool>(this, "apply_to_builtin_eventhub_endpoint");
        set => SetArgument("apply_to_builtin_eventhub_endpoint", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformArgument("default_action")]
    public TerraformValue<string>? DefaultAction
    {
        get => new TerraformReference<string>(this, "default_action");
        set => SetArgument("default_action", value);
    }

}

/// <summary>
/// Block type for sku in .
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
    [TerraformArgument("capacity")]
    public required TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_iothub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIothub : TerraformResource
{
    public AzurermIothub(string name) : base("azurerm_iothub", name)
    {
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformList<object> Endpoint
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "endpoint").ResolveNodes(ctx));
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    [TerraformArgument("enrichment")]
    public TerraformList<object> Enrichment
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "enrichment").ResolveNodes(ctx));
        set => SetArgument("enrichment", value);
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    [TerraformArgument("event_hub_partition_count")]
    public TerraformValue<double>? EventHubPartitionCount
    {
        get => new TerraformReference<double>(this, "event_hub_partition_count");
        set => SetArgument("event_hub_partition_count", value);
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    [TerraformArgument("event_hub_retention_in_days")]
    public TerraformValue<double>? EventHubRetentionInDays
    {
        get => new TerraformReference<double>(this, "event_hub_retention_in_days");
        set => SetArgument("event_hub_retention_in_days", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("local_authentication_enabled")]
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformArgument("min_tls_version")]
    public TerraformValue<string>? MinTlsVersion
    {
        get => new TerraformReference<string>(this, "min_tls_version");
        set => SetArgument("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    [TerraformArgument("route")]
    public TerraformList<object> Route
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "route").ResolveNodes(ctx));
        set => SetArgument("route", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for cloud_to_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    [TerraformArgument("cloud_to_device")]
    public TerraformList<AzurermIothubCloudToDeviceBlock> CloudToDevice { get; set; } = new();

    /// <summary>
    /// Block for fallback_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    [TerraformArgument("fallback_route")]
    public TerraformList<AzurermIothubFallbackRouteBlock> FallbackRoute { get; set; } = new();

    /// <summary>
    /// Block for file_upload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    [TerraformArgument("file_upload")]
    public TerraformList<AzurermIothubFileUploadBlock> FileUpload { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermIothubIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("network_rule_set")]
    public TerraformList<AzurermIothubNetworkRuleSetBlock> NetworkRuleSet { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermIothubSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIothubTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    [TerraformArgument("event_hub_events_endpoint")]
    public TerraformValue<string> EventHubEventsEndpoint
    {
        get => new TerraformReference<string>(this, "event_hub_events_endpoint");
    }

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    [TerraformArgument("event_hub_events_namespace")]
    public TerraformValue<string> EventHubEventsNamespace
    {
        get => new TerraformReference<string>(this, "event_hub_events_namespace");
    }

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    [TerraformArgument("event_hub_events_path")]
    public TerraformValue<string> EventHubEventsPath
    {
        get => new TerraformReference<string>(this, "event_hub_events_path");
    }

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    [TerraformArgument("event_hub_operations_endpoint")]
    public TerraformValue<string> EventHubOperationsEndpoint
    {
        get => new TerraformReference<string>(this, "event_hub_operations_endpoint");
    }

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    [TerraformArgument("event_hub_operations_path")]
    public TerraformValue<string> EventHubOperationsPath
    {
        get => new TerraformReference<string>(this, "event_hub_operations_path");
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformArgument("hostname")]
    public TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
    }

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    [TerraformArgument("shared_access_policy")]
    public TerraformList<object> SharedAccessPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "shared_access_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
