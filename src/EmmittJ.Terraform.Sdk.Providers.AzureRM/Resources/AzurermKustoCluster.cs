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
        get => GetRequiredProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
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
/// Block type for language_extensions in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterLanguageExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        get => GetRequiredProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("maximum_instances");
        set => WithProperty("maximum_instances", value);
    }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
    public required TerraformProperty<double> MinimumInstances
    {
        get => GetRequiredProperty<TerraformProperty<double>>("minimum_instances");
        set => WithProperty("minimum_instances", value);
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
        get => GetProperty<TerraformProperty<double>>("capacity");
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
public class AzurermKustoClusterTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The data_management_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataManagementPublicIpId is required")]
    public required TerraformProperty<string> DataManagementPublicIpId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("data_management_public_ip_id");
        set => WithProperty("data_management_public_ip_id", value);
    }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    public required TerraformProperty<string> EnginePublicIpId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_public_ip_id");
        set => WithProperty("engine_public_ip_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        this.DeclareOutput("data_ingestion_uri");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedFqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_fqdns");
        set => this.WithProperty("allowed_fqdns", value);
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedIpRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_ip_ranges");
        set => this.WithProperty("allowed_ip_ranges", value);
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoStopEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("auto_stop_enabled");
        set => this.WithProperty("auto_stop_enabled", value);
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiskEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("disk_encryption_enabled");
        set => this.WithProperty("disk_encryption_enabled", value);
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DoubleEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("double_encryption_enabled");
        set => this.WithProperty("double_encryption_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformProperty<bool>? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformProperty<bool>>("outbound_network_access_restricted");
        set => this.WithProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpType
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_type");
        set => this.WithProperty("public_ip_type", value);
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
    /// The purge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PurgeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("purge_enabled");
        set => this.WithProperty("purge_enabled", value);
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
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StreamingIngestionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("streaming_ingestion_enabled");
        set => this.WithProperty("streaming_ingestion_enabled", value);
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
    /// The trusted_external_tenants attribute.
    /// </summary>
    public List<TerraformProperty<string>>? TrustedExternalTenants
    {
        get => GetProperty<List<TerraformProperty<string>>>("trusted_external_tenants");
        set => this.WithProperty("trusted_external_tenants", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermKustoClusterIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermKustoClusterIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for language_extension.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKustoClusterLanguageExtensionBlock>? LanguageExtension
    {
        get => GetProperty<List<AzurermKustoClusterLanguageExtensionBlock>>("language_extension");
        set => this.WithProperty("language_extension", value);
    }

    /// <summary>
    /// Block for language_extensions.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermKustoClusterLanguageExtensionsBlock>? LanguageExtensions
    {
        get => GetProperty<List<AzurermKustoClusterLanguageExtensionsBlock>>("language_extensions");
        set => this.WithProperty("language_extensions", value);
    }

    /// <summary>
    /// Block for optimized_auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    public List<AzurermKustoClusterOptimizedAutoScaleBlock>? OptimizedAutoScale
    {
        get => GetProperty<List<AzurermKustoClusterOptimizedAutoScaleBlock>>("optimized_auto_scale");
        set => this.WithProperty("optimized_auto_scale", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermKustoClusterSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermKustoClusterSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKustoClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    public List<AzurermKustoClusterVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        get => GetProperty<List<AzurermKustoClusterVirtualNetworkConfigurationBlock>>("virtual_network_configuration");
        set => this.WithProperty("virtual_network_configuration", value);
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
