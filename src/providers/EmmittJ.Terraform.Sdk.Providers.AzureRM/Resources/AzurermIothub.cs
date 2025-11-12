using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cloud_to_device in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubCloudToDeviceBlock() : TerraformBlock("cloud_to_device")
{
    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultTtl { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformProperty("max_delivery_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDeliveryCount { get; set; }

}

/// <summary>
/// Block type for fallback_route in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubFallbackRouteBlock() : TerraformBlock("fallback_route")
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    [TerraformProperty("condition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Condition { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    [TerraformProperty("endpoint_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> EndpointNames { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for file_upload in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubFileUploadBlock() : TerraformBlock("file_upload")
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformProperty("authentication_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationType { get; set; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformProperty("connection_string")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConnectionString { get; set; }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformProperty("default_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultTtl { get; set; }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    [TerraformProperty("identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityId { get; set; }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformProperty("lock_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LockDuration { get; set; }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformProperty("max_delivery_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxDeliveryCount { get; set; }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformProperty("notifications")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Notifications { get; set; }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    [TerraformProperty("sas_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SasTtl { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for network_rule_set in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubNetworkRuleSetBlock() : TerraformBlock("network_rule_set")
{
    /// <summary>
    /// The apply_to_builtin_eventhub_endpoint attribute.
    /// </summary>
    [TerraformProperty("apply_to_builtin_eventhub_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyToBuiltinEventhubEndpoint { get; set; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultAction { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermIothubSkuBlock() : TerraformBlock("sku")
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [TerraformProperty("capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermIothubTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_iothub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermIothub : TerraformResource
{
    public AzurermIothub(string name) : base("azurerm_iothub", name)
    {
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> Endpoint { get; set; }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    [TerraformProperty("enrichment")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> Enrichment { get; set; }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    [TerraformProperty("event_hub_partition_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? EventHubPartitionCount { get; set; }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    [TerraformProperty("event_hub_retention_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? EventHubRetentionInDays { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthenticationEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    [TerraformProperty("min_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The route attribute.
    /// </summary>
    [TerraformProperty("route")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> Route { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for cloud_to_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    [TerraformProperty("cloud_to_device")]
    public TerraformList<AzurermIothubCloudToDeviceBlock> CloudToDevice { get; set; } = new();

    /// <summary>
    /// Block for fallback_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    [TerraformProperty("fallback_route")]
    public TerraformList<AzurermIothubFallbackRouteBlock> FallbackRoute { get; set; } = new();

    /// <summary>
    /// Block for file_upload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    [TerraformProperty("file_upload")]
    public TerraformList<AzurermIothubFileUploadBlock> FileUpload { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermIothubIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_rule_set")]
    public TerraformList<AzurermIothubNetworkRuleSetBlock> NetworkRuleSet { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public required TerraformList<AzurermIothubSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermIothubTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    [TerraformProperty("event_hub_events_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventHubEventsEndpoint { get; }

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    [TerraformProperty("event_hub_events_namespace")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventHubEventsNamespace { get; }

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    [TerraformProperty("event_hub_events_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventHubEventsPath { get; }

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    [TerraformProperty("event_hub_operations_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventHubOperationsEndpoint { get; }

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    [TerraformProperty("event_hub_operations_path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EventHubOperationsPath { get; }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [TerraformProperty("hostname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Hostname { get; }

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    [TerraformProperty("shared_access_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SharedAccessPolicy { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
