using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
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
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
    public required TerraformValue<double> MaximumInstances
    {
        get => new TerraformReference<double>(this, "maximum_instances");
        set => SetArgument("maximum_instances", value);
    }

    /// <summary>
    /// The minimum_instances attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumInstances is required")]
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
    public TerraformValue<double> Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public required TerraformValue<string> DataManagementPublicIpId
    {
        get => new TerraformReference<string>(this, "data_management_public_ip_id");
        set => SetArgument("data_management_public_ip_id", value);
    }

    /// <summary>
    /// The engine_public_ip_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnginePublicIpId is required")]
    public required TerraformValue<string> EnginePublicIpId
    {
        get => new TerraformReference<string>(this, "engine_public_ip_id");
        set => SetArgument("engine_public_ip_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Represents a azurerm_kusto_cluster Terraform resource.
/// Manages a azurerm_kusto_cluster resource.
/// </summary>
public partial class AzurermKustoCluster(string name) : TerraformResource("azurerm_kusto_cluster", name)
{
    /// <summary>
    /// The allowed_fqdns attribute.
    /// </summary>
    public TerraformList<string>? AllowedFqdns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_fqdns").ResolveNodes(ctx));
        set => SetArgument("allowed_fqdns", value);
    }

    /// <summary>
    /// The allowed_ip_ranges attribute.
    /// </summary>
    public TerraformList<string>? AllowedIpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_ip_ranges").ResolveNodes(ctx));
        set => SetArgument("allowed_ip_ranges", value);
    }

    /// <summary>
    /// The auto_stop_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoStopEnabled
    {
        get => new TerraformReference<bool>(this, "auto_stop_enabled");
        set => SetArgument("auto_stop_enabled", value);
    }

    /// <summary>
    /// The disk_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DiskEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "disk_encryption_enabled");
        set => SetArgument("disk_encryption_enabled", value);
    }

    /// <summary>
    /// The double_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DoubleEncryptionEnabled
    {
        get => new TerraformReference<bool>(this, "double_encryption_enabled");
        set => SetArgument("double_encryption_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformValue<bool>? OutboundNetworkAccessRestricted
    {
        get => new TerraformReference<bool>(this, "outbound_network_access_restricted");
        set => SetArgument("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The public_ip_type attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpType
    {
        get => new TerraformReference<string>(this, "public_ip_type");
        set => SetArgument("public_ip_type", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The purge_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PurgeEnabled
    {
        get => new TerraformReference<bool>(this, "purge_enabled");
        set => SetArgument("purge_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The streaming_ingestion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamingIngestionEnabled
    {
        get => new TerraformReference<bool>(this, "streaming_ingestion_enabled");
        set => SetArgument("streaming_ingestion_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The trusted_external_tenants attribute.
    /// </summary>
    public TerraformList<string> TrustedExternalTenants
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "trusted_external_tenants").ResolveNodes(ctx));
        set => SetArgument("trusted_external_tenants", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The data_ingestion_uri attribute.
    /// </summary>
    public TerraformValue<string> DataIngestionUri
    {
        get => new TerraformReference<string>(this, "data_ingestion_uri");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermKustoClusterIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermKustoClusterIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// LanguageExtension block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermKustoClusterLanguageExtensionBlock>? LanguageExtension
    {
        get => GetArgument<TerraformList<AzurermKustoClusterLanguageExtensionBlock>>("language_extension");
        set => SetArgument("language_extension", value);
    }

    /// <summary>
    /// LanguageExtensions block (nesting mode: list).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermKustoClusterLanguageExtensionsBlock>? LanguageExtensions
    {
        get => GetArgument<TerraformList<AzurermKustoClusterLanguageExtensionsBlock>>("language_extensions");
        set => SetArgument("language_extensions", value);
    }

    /// <summary>
    /// OptimizedAutoScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OptimizedAutoScale block(s) allowed")]
    public TerraformList<AzurermKustoClusterOptimizedAutoScaleBlock>? OptimizedAutoScale
    {
        get => GetArgument<TerraformList<AzurermKustoClusterOptimizedAutoScaleBlock>>("optimized_auto_scale");
        set => SetArgument("optimized_auto_scale", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermKustoClusterSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermKustoClusterSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKustoClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKustoClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VirtualNetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualNetworkConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermKustoClusterVirtualNetworkConfigurationBlock>? VirtualNetworkConfiguration
    {
        get => GetArgument<TerraformList<AzurermKustoClusterVirtualNetworkConfigurationBlock>>("virtual_network_configuration");
        set => SetArgument("virtual_network_configuration", value);
    }

}
