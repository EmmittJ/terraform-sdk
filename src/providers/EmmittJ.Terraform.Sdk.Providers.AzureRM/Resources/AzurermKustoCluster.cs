using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKustoClusterIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for language_extension in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKustoClusterLanguageExtensionBlock : TerraformBlockBase
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for language_extensions in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermKustoClusterLanguageExtensionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for optimized_auto_scale in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKustoClusterOptimizedAutoScaleBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumInstances is required")]
    [TerraformProperty("maximum_instances")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaximumInstances { get; set; }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
    [TerraformProperty("minimum_instances")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinimumInstances { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKustoClusterSkuBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Capacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKustoClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermKustoClusterVirtualNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The data_management_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataManagementPublicIpId is required")]
    [TerraformProperty("data_management_public_ip_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataManagementPublicIpId { get; set; }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    [TerraformProperty("engine_public_ip_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EnginePublicIpId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKustoCluster : TerraformResource
{
    public AzurermKustoCluster(string name) : base("azurerm_kusto_cluster", name)
    {
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    [TerraformProperty("allowed_fqdns")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AllowedFqdns { get; set; }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    [TerraformProperty("allowed_ip_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? AllowedIpRanges { get; set; }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_stop_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoStopEnabled { get; set; }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("disk_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DiskEncryptionEnabled { get; set; }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    [TerraformProperty("double_encryption_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DoubleEncryptionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    [TerraformProperty("outbound_network_access_restricted")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    [TerraformProperty("public_ip_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicIpType { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The purge_enabled attribute.
    /// </summary>
    [TerraformProperty("purge_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PurgeEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    [TerraformProperty("streaming_ingestion_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? StreamingIngestionEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The trusted_external_tenants attribute.
    /// </summary>
    [TerraformProperty("trusted_external_tenants")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> TrustedExternalTenants { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermKustoClusterIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for language_extension.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("language_extension")]
    public TerraformList<TerraformBlock<AzurermKustoClusterLanguageExtensionBlock>>? LanguageExtension { get; set; }

    /// <summary>
    /// Block for language_extensions.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("language_extensions")]
    public TerraformList<TerraformBlock<AzurermKustoClusterLanguageExtensionsBlock>>? LanguageExtensions { get; set; }

    /// <summary>
    /// Block for optimized_auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    [TerraformProperty("optimized_auto_scale")]
    public TerraformList<TerraformBlock<AzurermKustoClusterOptimizedAutoScaleBlock>>? OptimizedAutoScale { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public TerraformList<TerraformBlock<AzurermKustoClusterSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKustoClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("virtual_network_configuration")]
    public TerraformList<TerraformBlock<AzurermKustoClusterVirtualNetworkConfigurationBlock>>? VirtualNetworkConfiguration { get; set; }

    /// <summary>
    /// The data_ingestion_uri attribute.
    /// </summary>
    [TerraformProperty("data_ingestion_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataIngestionUri { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uri { get; }

}
