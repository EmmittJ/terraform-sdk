using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cloud_to_device in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubCloudToDeviceBlock : TerraformBlock
{
    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTtl
    {
        set => SetProperty("default_ttl", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        set => SetProperty("max_delivery_count", value);
    }

}

/// <summary>
/// Block type for fallback_route in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubFallbackRouteBlock : TerraformBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EndpointNames
    {
        set => SetProperty("endpoint_names", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
    }

}

/// <summary>
/// Block type for file_upload in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubFileUploadBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationType
    {
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTtl
    {
        set => SetProperty("default_ttl", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string>? LockDuration
    {
        set => SetProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        set => SetProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformProperty<bool>? Notifications
    {
        set => SetProperty("notifications", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? SasTtl
    {
        set => SetProperty("sas_ttl", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

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
/// Block type for network_rule_set in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubNetworkRuleSetBlock : TerraformBlock
{
    /// <summary>
    /// The apply_to_builtin_eventhub_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyToBuiltinEventhubEndpoint
    {
        set => SetProperty("apply_to_builtin_eventhub_endpoint", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAction
    {
        set => SetProperty("default_action", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermIothubSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformProperty<double> Capacity
    {
        set => SetProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_iothub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermIothub : TerraformResource
{
    public AzurermIothub(string name) : base("azurerm_iothub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("event_hub_events_endpoint");
        SetOutput("event_hub_events_namespace");
        SetOutput("event_hub_events_path");
        SetOutput("event_hub_operations_endpoint");
        SetOutput("event_hub_operations_path");
        SetOutput("hostname");
        SetOutput("shared_access_policy");
        SetOutput("type");
        SetOutput("endpoint");
        SetOutput("enrichment");
        SetOutput("event_hub_partition_count");
        SetOutput("event_hub_retention_in_days");
        SetOutput("id");
        SetOutput("local_authentication_enabled");
        SetOutput("location");
        SetOutput("min_tls_version");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("route");
        SetOutput("tags");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public List<TerraformProperty<object>> Endpoint
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("endpoint");
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public List<TerraformProperty<object>> Enrichment
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("enrichment");
        set => SetProperty("enrichment", value);
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    public TerraformProperty<double> EventHubPartitionCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("event_hub_partition_count");
        set => SetProperty("event_hub_partition_count", value);
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> EventHubRetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("event_hub_retention_in_days");
        set => SetProperty("event_hub_retention_in_days", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthenticationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_enabled");
        set => SetProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("min_tls_version");
        set => SetProperty("min_tls_version", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    public List<TerraformProperty<object>> Route
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("route");
        set => SetProperty("route", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for cloud_to_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    public List<AzurermIothubCloudToDeviceBlock>? CloudToDevice
    {
        set => SetProperty("cloud_to_device", value);
    }

    /// <summary>
    /// Block for fallback_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    public List<AzurermIothubFallbackRouteBlock>? FallbackRoute
    {
        set => SetProperty("fallback_route", value);
    }

    /// <summary>
    /// Block for file_upload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    public List<AzurermIothubFileUploadBlock>? FileUpload
    {
        set => SetProperty("file_upload", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermIothubIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermIothubNetworkRuleSetBlock>? NetworkRuleSet
    {
        set => SetProperty("network_rule_set", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermIothubSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The event_hub_events_endpoint attribute.
    /// </summary>
    public TerraformExpression EventHubEventsEndpoint => this["event_hub_events_endpoint"];

    /// <summary>
    /// The event_hub_events_namespace attribute.
    /// </summary>
    public TerraformExpression EventHubEventsNamespace => this["event_hub_events_namespace"];

    /// <summary>
    /// The event_hub_events_path attribute.
    /// </summary>
    public TerraformExpression EventHubEventsPath => this["event_hub_events_path"];

    /// <summary>
    /// The event_hub_operations_endpoint attribute.
    /// </summary>
    public TerraformExpression EventHubOperationsEndpoint => this["event_hub_operations_endpoint"];

    /// <summary>
    /// The event_hub_operations_path attribute.
    /// </summary>
    public TerraformExpression EventHubOperationsPath => this["event_hub_operations_path"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The shared_access_policy attribute.
    /// </summary>
    public TerraformExpression SharedAccessPolicy => this["shared_access_policy"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
