using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cloud_to_device in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubCloudToDeviceBlock
{
    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultTtl { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxDeliveryCount { get; set; }

}

/// <summary>
/// Block type for fallback_route in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubFallbackRouteBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformPropertyName("condition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_names")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> EndpointNames { get; set; } = default!;

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for file_upload in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubFileUploadBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformPropertyName("authentication_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformPropertyName("connection_string")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConnectionString { get; set; }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformPropertyName("default_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultTtl { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformPropertyName("identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IdentityId { get; set; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformPropertyName("lock_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformPropertyName("max_delivery_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxDeliveryCount { get; set; }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformPropertyName("notifications")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Notifications { get; set; }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    [TerraformPropertyName("sas_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SasTtl { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubNetworkRuleSetBlock
{
    /// <summary>
    /// The apply_to_builtin_eventhub_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("apply_to_builtin_eventhub_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplyToBuiltinEventhubEndpoint { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformPropertyName("default_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultAction { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubSkuBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformPropertyName("capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("endpoint")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> Endpoint { get; set; } = default!;

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    [TerraformPropertyName("enrichment")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> Enrichment { get; set; } = default!;

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_partition_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EventHubPartitionCount { get; set; }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EventHubRetentionInDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformPropertyName("min_tls_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MinTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The route attribute.
    /// </summary>
    [TerraformPropertyName("route")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> Route { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for cloud_to_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    [TerraformPropertyName("cloud_to_device")]
    public TerraformList<TerraformBlock<AzurermIothubCloudToDeviceBlock>>? CloudToDevice { get; set; }

    /// <summary>
    /// Block for fallback_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    [TerraformPropertyName("fallback_route")]
    public TerraformList<TerraformBlock<AzurermIothubFallbackRouteBlock>>? FallbackRoute { get; set; }

    /// <summary>
    /// Block for file_upload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    [TerraformPropertyName("file_upload")]
    public TerraformList<TerraformBlock<AzurermIothubFileUploadBlock>>? FileUpload { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermIothubIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_rule_set")]
    public TerraformList<TerraformBlock<AzurermIothubNetworkRuleSetBlock>>? NetworkRuleSet { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermIothubSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermIothubTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_events_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventHubEventsEndpoint => new TerraformReference(this, "event_hub_events_endpoint");

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_events_namespace")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventHubEventsNamespace => new TerraformReference(this, "event_hub_events_namespace");

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_events_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventHubEventsPath => new TerraformReference(this, "event_hub_events_path");

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_operations_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventHubOperationsEndpoint => new TerraformReference(this, "event_hub_operations_endpoint");

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    [TerraformPropertyName("event_hub_operations_path")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EventHubOperationsPath => new TerraformReference(this, "event_hub_operations_path");

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformPropertyName("hostname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Hostname => new TerraformReference(this, "hostname");

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("shared_access_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SharedAccessPolicy => new TerraformReference(this, "shared_access_policy");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
