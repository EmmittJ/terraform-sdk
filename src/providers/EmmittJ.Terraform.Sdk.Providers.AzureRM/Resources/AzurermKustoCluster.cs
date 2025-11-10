using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for language_extension in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterLanguageExtensionBlock : ITerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for language_extensions in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterLanguageExtensionsBlock : ITerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for optimized_auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterOptimizedAutoScaleBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumInstances is required")]
    [TerraformPropertyName("maximum_instances")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaximumInstances { get; set; }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
    [TerraformPropertyName("minimum_instances")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinimumInstances { get; set; }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterSkuBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformPropertyName("capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Capacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "capacity");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterVirtualNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The data_management_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataManagementPublicIpId is required")]
    [TerraformPropertyName("data_management_public_ip_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataManagementPublicIpId { get; set; }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    [TerraformPropertyName("engine_public_ip_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnginePublicIpId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Manages a azurerm_kusto_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKustoCluster : TerraformResource
{
    public AzurermKustoCluster(string name) : base("azurerm_kusto_cluster", name)
    {
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    [TerraformPropertyName("allowed_fqdns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedFqdns { get; set; }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("allowed_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedIpRanges { get; set; }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_stop_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoStopEnabled { get; set; }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DiskEncryptionEnabled { get; set; }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    [TerraformPropertyName("double_encryption_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DoubleEncryptionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    [TerraformPropertyName("outbound_network_access_restricted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OutboundNetworkAccessRestricted { get; set; }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpType { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The purge_enabled attribute.
    /// </summary>
    [TerraformPropertyName("purge_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PurgeEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("streaming_ingestion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StreamingIngestionEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The trusted_external_tenants attribute.
    /// </summary>
    [TerraformPropertyName("trusted_external_tenants")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> TrustedExternalTenants { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "trusted_external_tenants");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermKustoClusterIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for language_extension.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("language_extension")]
    public TerraformList<TerraformBlock<AzurermKustoClusterLanguageExtensionBlock>>? LanguageExtension { get; set; } = new();

    /// <summary>
    /// Block for language_extensions.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("language_extensions")]
    public TerraformList<TerraformBlock<AzurermKustoClusterLanguageExtensionsBlock>>? LanguageExtensions { get; set; } = new();

    /// <summary>
    /// Block for optimized_auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    [TerraformPropertyName("optimized_auto_scale")]
    public TerraformList<TerraformBlock<AzurermKustoClusterOptimizedAutoScaleBlock>>? OptimizedAutoScale { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermKustoClusterSkuBlock>>? Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKustoClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("virtual_network_configuration")]
    public TerraformList<TerraformBlock<AzurermKustoClusterVirtualNetworkConfigurationBlock>>? VirtualNetworkConfiguration { get; set; } = new();

    /// <summary>
    /// The data_ingestion_uri attribute.
    /// </summary>
    [TerraformPropertyName("data_ingestion_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataIngestionUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_ingestion_uri");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uri");

}
