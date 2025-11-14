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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterIdentityBlock : TerraformBlock
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
/// Block type for language_extension in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterLanguageExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "language_extension";

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformArgument("image")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
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
/// Block type for language_extensions in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterLanguageExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "language_extensions";

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformArgument("image")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
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
/// Block type for optimized_auto_scale in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterOptimizedAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "optimized_auto_scale";

    /// <summary>
    /// The maximum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumInstances is required")]
    [TerraformArgument("maximum_instances")]
    public required TerraformValue<double> MaximumInstances
    {
        get => new TerraformReference<double>(this, "maximum_instances");
        set => SetArgument("maximum_instances", value);
    }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
    [TerraformArgument("minimum_instances")]
    public required TerraformValue<double> MinimumInstances
    {
        get => new TerraformReference<double>(this, "minimum_instances");
        set => SetArgument("minimum_instances", value);
    }

}

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermKustoClusterSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformArgument("capacity")]
    public TerraformValue<double> Capacity
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
public class AzurermKustoClusterTimeoutsBlock : TerraformBlock
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
/// Block type for virtual_network_configuration in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKustoClusterVirtualNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_network_configuration";

    /// <summary>
    /// The data_management_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataManagementPublicIpId is required")]
    [TerraformArgument("data_management_public_ip_id")]
    public required TerraformValue<string> DataManagementPublicIpId
    {
        get => new TerraformReference<string>(this, "data_management_public_ip_id");
        set => SetArgument("data_management_public_ip_id", value);
    }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    [TerraformArgument("engine_public_ip_id")]
    public required TerraformValue<string> EnginePublicIpId
    {
        get => new TerraformReference<string>(this, "engine_public_ip_id");
        set => SetArgument("engine_public_ip_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
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
    }

    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    [TerraformArgument("allowed_fqdns")]
    public TerraformList<string>? AllowedFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_fqdns").ResolveNodes(ctx));
        set => SetArgument("allowed_fqdns", value);
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    [TerraformArgument("allowed_ip_ranges")]
    public TerraformList<string>? AllowedIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("allowed_ip_ranges", value);
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_stop_enabled")]
    public TerraformValue<bool>? AutoStopEnabled
    {
        get => new TerraformReference<bool>(this, "auto_stop_enabled");
        set => SetArgument("auto_stop_enabled", value);
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("disk_encryption_enabled")]
    public TerraformValue<bool>? DiskEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "disk_encryption_enabled");
        set => SetArgument("disk_encryption_enabled", value);
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    [TerraformArgument("double_encryption_enabled")]
    public TerraformValue<bool>? DoubleEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "double_encryption_enabled");
        set => SetArgument("double_encryption_enabled", value);
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    [TerraformArgument("outbound_network_access_restricted")]
    public TerraformValue<bool>? OutboundNetworkAccessRestricted
    {
        get => new TerraformReference<bool>(this, "outbound_network_access_restricted");
        set => SetArgument("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    [TerraformArgument("public_ip_type")]
    public TerraformValue<string>? PublicIpType
    {
        get => new TerraformReference<string>(this, "public_ip_type");
        set => SetArgument("public_ip_type", value);
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
    /// The purge_enabled attribute.
    /// </summary>
    [TerraformArgument("purge_enabled")]
    public TerraformValue<bool>? PurgeEnabled
    {
        get => new TerraformReference<bool>(this, "purge_enabled");
        set => SetArgument("purge_enabled", value);
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
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    [TerraformArgument("streaming_ingestion_enabled")]
    public TerraformValue<bool>? StreamingIngestionEnabled
    {
        get => new TerraformReference<bool>(this, "streaming_ingestion_enabled");
        set => SetArgument("streaming_ingestion_enabled", value);
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
    /// The trusted_external_tenants attribute.
    /// </summary>
    [TerraformArgument("trusted_external_tenants")]
    public TerraformList<string> TrustedExternalTenants
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_external_tenants").ResolveNodes(ctx));
        set => SetArgument("trusted_external_tenants", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermKustoClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for language_extension.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("language_extension")]
    public TerraformList<AzurermKustoClusterLanguageExtensionBlock> LanguageExtension { get; set; } = new();

    /// <summary>
    /// Block for language_extensions.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("language_extensions")]
    public TerraformList<AzurermKustoClusterLanguageExtensionsBlock> LanguageExtensions { get; set; } = new();

    /// <summary>
    /// Block for optimized_auto_scale.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    [TerraformArgument("optimized_auto_scale")]
    public TerraformList<AzurermKustoClusterOptimizedAutoScaleBlock> OptimizedAutoScale { get; set; } = new();

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformArgument("sku")]
    public required TerraformList<AzurermKustoClusterSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKustoClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("virtual_network_configuration")]
    public TerraformList<AzurermKustoClusterVirtualNetworkConfigurationBlock> VirtualNetworkConfiguration { get; set; } = new();

    /// <summary>
    /// The data_ingestion_uri attribute.
    /// </summary>
    [TerraformArgument("data_ingestion_uri")]
    public TerraformValue<string> DataIngestionUri
    {
        get => new TerraformReference<string>(this, "data_ingestion_uri");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformArgument("uri")]
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

}
