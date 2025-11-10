using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterIdentityBlock : TerraformBlock
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
/// Block type for language_extension in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterLanguageExtensionBlock : TerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
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
/// Block type for language_extensions in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterLanguageExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
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
/// Block type for optimized_auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterOptimizedAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumInstances is required")]
    public required TerraformProperty<double> MaximumInstances
    {
        set => SetProperty("maximum_instances", value);
    }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
    public required TerraformProperty<double> MinimumInstances
    {
        set => SetProperty("minimum_instances", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterSkuBlock : TerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformProperty<double>? Capacity
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
public class AzurermKustoClusterTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The data_management_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataManagementPublicIpId is required")]
    public required TerraformProperty<string> DataManagementPublicIpId
    {
        set => SetProperty("data_management_public_ip_id", value);
    }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    public required TerraformProperty<string> EnginePublicIpId
    {
        set => SetProperty("engine_public_ip_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Manages a azurerm_kusto_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKustoCluster : TerraformResource
{
    public AzurermKustoCluster(string name) : base("azurerm_kusto_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("data_ingestion_uri");
        SetOutput("uri");
        SetOutput("allowed_fqdns");
        SetOutput("allowed_ip_ranges");
        SetOutput("auto_stop_enabled");
        SetOutput("disk_encryption_enabled");
        SetOutput("double_encryption_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("outbound_network_access_restricted");
        SetOutput("public_ip_type");
        SetOutput("public_network_access_enabled");
        SetOutput("purge_enabled");
        SetOutput("resource_group_name");
        SetOutput("streaming_ingestion_enabled");
        SetOutput("tags");
        SetOutput("trusted_external_tenants");
        SetOutput("zones");
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>> AllowedFqdns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("allowed_fqdns");
        set => SetProperty("allowed_fqdns", value);
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>> AllowedIpRanges
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("allowed_ip_ranges");
        set => SetProperty("allowed_ip_ranges", value);
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoStopEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_stop_enabled");
        set => SetProperty("auto_stop_enabled", value);
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DiskEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disk_encryption_enabled");
        set => SetProperty("disk_encryption_enabled", value);
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DoubleEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("double_encryption_enabled");
        set => SetProperty("double_encryption_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformProperty<bool> OutboundNetworkAccessRestricted
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("outbound_network_access_restricted");
        set => SetProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    public TerraformProperty<string> PublicIpType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ip_type");
        set => SetProperty("public_ip_type", value);
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
    /// The purge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PurgeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("purge_enabled");
        set => SetProperty("purge_enabled", value);
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
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> StreamingIngestionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("streaming_ingestion_enabled");
        set => SetProperty("streaming_ingestion_enabled", value);
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
    /// The trusted_external_tenants attribute.
    /// </summary>
    public List<TerraformProperty<string>> TrustedExternalTenants
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("trusted_external_tenants");
        set => SetProperty("trusted_external_tenants", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermKustoClusterIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for language_extension.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKustoClusterLanguageExtensionBlock>? LanguageExtension
    {
        set => SetProperty("language_extension", value);
    }

    /// <summary>
    /// Block for language_extensions.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public List<AzurermKustoClusterLanguageExtensionsBlock>? LanguageExtensions
    {
        set => SetProperty("language_extensions", value);
    }

    /// <summary>
    /// Block for optimized_auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    public List<AzurermKustoClusterOptimizedAutoScaleBlock>? OptimizedAutoScale
    {
        set => SetProperty("optimized_auto_scale", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermKustoClusterSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AzurermKustoClusterVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        set => SetProperty("virtual_network_configuration", value);
    }

    /// <summary>
    /// The data_ingestion_uri attribute.
    /// </summary>
    public TerraformExpression DataIngestionUri => this["data_ingestion_uri"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
