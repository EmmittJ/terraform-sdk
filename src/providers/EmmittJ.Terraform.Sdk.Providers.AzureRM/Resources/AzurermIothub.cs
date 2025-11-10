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
        get => GetProperty<TerraformProperty<string>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformProperty<double>>("max_delivery_count");
        set => WithProperty("max_delivery_count", value);
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
        get => GetProperty<TerraformProperty<string>>("condition");
        set => WithProperty("condition", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The endpoint_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? EndpointNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("endpoint_names");
        set => WithProperty("endpoint_names", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
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
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection_string");
        set => WithProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_name");
        set => WithProperty("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<string>>("default_ttl");
        set => WithProperty("default_ttl", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        get => GetProperty<TerraformProperty<string>>("identity_id");
        set => WithProperty("identity_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string>? LockDuration
    {
        get => GetProperty<TerraformProperty<string>>("lock_duration");
        set => WithProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformProperty<double>>("max_delivery_count");
        set => WithProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    public TerraformProperty<bool>? Notifications
    {
        get => GetProperty<TerraformProperty<bool>>("notifications");
        set => WithProperty("notifications", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? SasTtl
    {
        get => GetProperty<TerraformProperty<string>>("sas_ttl");
        set => WithProperty("sas_ttl", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<bool>>("apply_to_builtin_eventhub_endpoint");
        set => WithProperty("apply_to_builtin_eventhub_endpoint", value);
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => WithProperty("default_action", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("capacity");
        set => WithProperty("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("event_hub_events_endpoint");
        this.DeclareOutput("event_hub_events_namespace");
        this.DeclareOutput("event_hub_events_path");
        this.DeclareOutput("event_hub_operations_endpoint");
        this.DeclareOutput("event_hub_operations_path");
        this.DeclareOutput("hostname");
        this.DeclareOutput("shared_access_policy");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Endpoint
    {
        get => GetProperty<List<TerraformProperty<object>>>("endpoint");
        set => this.WithProperty("endpoint", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Enrichment
    {
        get => GetProperty<List<TerraformProperty<object>>>("enrichment");
        set => this.WithProperty("enrichment", value);
    }

    /// <summary>
    /// The event_hub_partition_count attribute.
    /// </summary>
    public TerraformProperty<double>? EventHubPartitionCount
    {
        get => GetProperty<TerraformProperty<double>>("event_hub_partition_count");
        set => this.WithProperty("event_hub_partition_count", value);
    }

    /// <summary>
    /// The event_hub_retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? EventHubRetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("event_hub_retention_in_days");
        set => this.WithProperty("event_hub_retention_in_days", value);
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
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_enabled");
        set => this.WithProperty("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The min_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("min_tls_version");
        set => this.WithProperty("min_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Route
    {
        get => GetProperty<List<TerraformProperty<object>>>("route");
        set => this.WithProperty("route", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for cloud_to_device.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudToDevice block(s) allowed")]
    public List<AzurermIothubCloudToDeviceBlock>? CloudToDevice
    {
        get => GetProperty<List<AzurermIothubCloudToDeviceBlock>>("cloud_to_device");
        set => this.WithProperty("cloud_to_device", value);
    }

    /// <summary>
    /// Block for fallback_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FallbackRoute block(s) allowed")]
    public List<AzurermIothubFallbackRouteBlock>? FallbackRoute
    {
        get => GetProperty<List<AzurermIothubFallbackRouteBlock>>("fallback_route");
        set => this.WithProperty("fallback_route", value);
    }

    /// <summary>
    /// Block for file_upload.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileUpload block(s) allowed")]
    public List<AzurermIothubFileUploadBlock>? FileUpload
    {
        get => GetProperty<List<AzurermIothubFileUploadBlock>>("file_upload");
        set => this.WithProperty("file_upload", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermIothubIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermIothubIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for network_rule_set.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermIothubNetworkRuleSetBlock>? NetworkRuleSet
    {
        get => GetProperty<List<AzurermIothubNetworkRuleSetBlock>>("network_rule_set");
        set => this.WithProperty("network_rule_set", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermIothubSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermIothubSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermIothubTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
