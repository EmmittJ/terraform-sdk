using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for auto_scale in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolAutoScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scale";

    /// <summary>
    /// The evaluation_interval attribute.
    /// </summary>
    public TerraformValue<string>? EvaluationInterval
    {
        get => GetArgument<TerraformValue<string>>("evaluation_interval");
        set => SetArgument("evaluation_interval", value);
    }

    /// <summary>
    /// The formula attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Formula is required")]
    public required TerraformValue<string> Formula
    {
        get => GetRequiredArgument<TerraformValue<string>>("formula");
        set => SetArgument("formula", value);
    }

}


/// <summary>
/// Block type for certificate in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The store_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoreLocation is required")]
    public required TerraformValue<string> StoreLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("store_location");
        set => SetArgument("store_location", value);
    }

    /// <summary>
    /// The store_name attribute.
    /// </summary>
    public TerraformValue<string>? StoreName
    {
        get => GetArgument<TerraformValue<string>>("store_name");
        set => SetArgument("store_name", value);
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformSet<string>? Visibility
    {
        get => GetArgument<TerraformSet<string>>("visibility");
        set => SetArgument("visibility", value);
    }

}


/// <summary>
/// Block type for container_configuration in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolContainerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_configuration";

    /// <summary>
    /// The container_image_names attribute.
    /// </summary>
    public TerraformSet<string>? ContainerImageNames
    {
        get => GetArgument<TerraformSet<string>>("container_image_names");
        set => SetArgument("container_image_names", value);
    }

    /// <summary>
    /// The container_registries attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>>? ContainerRegistries
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("container_registries");
        set => SetArgument("container_registries", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for data_disks in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDataDisksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disks";

    /// <summary>
    /// The caching attribute.
    /// </summary>
    public TerraformValue<string>? Caching
    {
        get => GetArgument<TerraformValue<string>>("caching");
        set => SetArgument("caching", value);
    }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskSizeGb is required")]
    public required TerraformValue<double> DiskSizeGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("disk_size_gb");
        set => SetArgument("disk_size_gb", value);
    }

    /// <summary>
    /// The lun attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lun is required")]
    public required TerraformValue<double> Lun
    {
        get => GetRequiredArgument<TerraformValue<double>>("lun");
        set => SetArgument("lun", value);
    }

    /// <summary>
    /// The storage_account_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountType
    {
        get => GetArgument<TerraformValue<string>>("storage_account_type");
        set => SetArgument("storage_account_type", value);
    }

}


/// <summary>
/// Block type for disk_encryption in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolDiskEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_encryption";

    /// <summary>
    /// The disk_encryption_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskEncryptionTarget is required")]
    public required TerraformValue<string> DiskEncryptionTarget
    {
        get => GetRequiredArgument<TerraformValue<string>>("disk_encryption_target");
        set => SetArgument("disk_encryption_target", value);
    }

}


/// <summary>
/// Block type for extensions in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolExtensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extensions";

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformValue<bool>? AutoUpgradeMinorVersion
    {
        get => GetArgument<TerraformValue<bool>>("auto_upgrade_minor_version");
        set => SetArgument("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutomaticUpgradeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("automatic_upgrade_enabled");
        set => SetArgument("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformValue<string>? ProtectedSettings
    {
        get => GetArgument<TerraformValue<string>>("protected_settings");
        set => SetArgument("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformSet<string>? ProvisionAfterExtensions
    {
        get => GetArgument<TerraformSet<string>>("provision_after_extensions");
        set => SetArgument("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetRequiredArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The settings_json attribute.
    /// </summary>
    public TerraformValue<string>? SettingsJson
    {
        get => GetArgument<TerraformValue<string>>("settings_json");
        set => SetArgument("settings_json", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformValue<string>? TypeHandlerVersion
    {
        get => GetArgument<TerraformValue<string>>("type_handler_version");
        set => SetArgument("type_handler_version", value);
    }

}


/// <summary>
/// Block type for fixed_scale in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolFixedScaleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_scale";

    /// <summary>
    /// The node_deallocation_method attribute.
    /// </summary>
    public TerraformValue<string>? NodeDeallocationMethod
    {
        get => GetArgument<TerraformValue<string>>("node_deallocation_method");
        set => SetArgument("node_deallocation_method", value);
    }

    /// <summary>
    /// The resize_timeout attribute.
    /// </summary>
    public TerraformValue<string>? ResizeTimeout
    {
        get => GetArgument<TerraformValue<string>>("resize_timeout");
        set => SetArgument("resize_timeout", value);
    }

    /// <summary>
    /// The target_dedicated_nodes attribute.
    /// </summary>
    public TerraformValue<double>? TargetDedicatedNodes
    {
        get => GetArgument<TerraformValue<double>>("target_dedicated_nodes");
        set => SetArgument("target_dedicated_nodes", value);
    }

    /// <summary>
    /// The target_low_priority_nodes attribute.
    /// </summary>
    public TerraformValue<double>? TargetLowPriorityNodes
    {
        get => GetArgument<TerraformValue<double>>("target_low_priority_nodes");
        set => SetArgument("target_low_priority_nodes", value);
    }

}


/// <summary>
/// Block type for identity in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for mount in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mount";

    /// <summary>
    /// AzureBlobFileSystem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobFileSystem block(s) allowed")]
    public TerraformList<AzurermBatchPoolMountBlockAzureBlobFileSystemBlock>? AzureBlobFileSystem
    {
        get => GetArgument<TerraformList<AzurermBatchPoolMountBlockAzureBlobFileSystemBlock>>("azure_blob_file_system");
        set => SetArgument("azure_blob_file_system", value);
    }

    /// <summary>
    /// AzureFileShare block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolMountBlockAzureFileShareBlock>? AzureFileShare
    {
        get => GetArgument<TerraformList<AzurermBatchPoolMountBlockAzureFileShareBlock>>("azure_file_share");
        set => SetArgument("azure_file_share", value);
    }

    /// <summary>
    /// CifsMount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolMountBlockCifsMountBlock>? CifsMount
    {
        get => GetArgument<TerraformList<AzurermBatchPoolMountBlockCifsMountBlock>>("cifs_mount");
        set => SetArgument("cifs_mount", value);
    }

    /// <summary>
    /// NfsMount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolMountBlockNfsMountBlock>? NfsMount
    {
        get => GetArgument<TerraformList<AzurermBatchPoolMountBlockNfsMountBlock>>("nfs_mount");
        set => SetArgument("nfs_mount", value);
    }

}

/// <summary>
/// Block type for azure_blob_file_system in AzurermBatchPoolMountBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlockAzureBlobFileSystemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_file_system";

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformValue<string>? AccountKey
    {
        get => GetArgument<TerraformValue<string>>("account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The blobfuse_options attribute.
    /// </summary>
    public TerraformValue<string>? BlobfuseOptions
    {
        get => GetArgument<TerraformValue<string>>("blobfuse_options");
        set => SetArgument("blobfuse_options", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The relative_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeMountPath is required")]
    public required TerraformValue<string> RelativeMountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("relative_mount_path");
        set => SetArgument("relative_mount_path", value);
    }

    /// <summary>
    /// The sas_key attribute.
    /// </summary>
    public TerraformValue<string>? SasKey
    {
        get => GetArgument<TerraformValue<string>>("sas_key");
        set => SetArgument("sas_key", value);
    }

}

/// <summary>
/// Block type for azure_file_share in AzurermBatchPoolMountBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlockAzureFileShareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_file_share";

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountKey is required")]
    public required TerraformValue<string> AccountKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The azure_file_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureFileUrl is required")]
    public required TerraformValue<string> AzureFileUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("azure_file_url");
        set => SetArgument("azure_file_url", value);
    }

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformValue<string>? MountOptions
    {
        get => GetArgument<TerraformValue<string>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The relative_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeMountPath is required")]
    public required TerraformValue<string> RelativeMountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("relative_mount_path");
        set => SetArgument("relative_mount_path", value);
    }

}

/// <summary>
/// Block type for cifs_mount in AzurermBatchPoolMountBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlockCifsMountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cifs_mount";

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformValue<string>? MountOptions
    {
        get => GetArgument<TerraformValue<string>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The relative_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeMountPath is required")]
    public required TerraformValue<string> RelativeMountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("relative_mount_path");
        set => SetArgument("relative_mount_path", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

}

/// <summary>
/// Block type for nfs_mount in AzurermBatchPoolMountBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolMountBlockNfsMountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs_mount";

    /// <summary>
    /// The mount_options attribute.
    /// </summary>
    public TerraformValue<string>? MountOptions
    {
        get => GetArgument<TerraformValue<string>>("mount_options");
        set => SetArgument("mount_options", value);
    }

    /// <summary>
    /// The relative_mount_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeMountPath is required")]
    public required TerraformValue<string> RelativeMountPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("relative_mount_path");
        set => SetArgument("relative_mount_path", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for network_configuration in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AcceleratedNetworkingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("accelerated_networking_enabled");
        set => SetArgument("accelerated_networking_enabled", value);
    }

    /// <summary>
    /// The dynamic_vnet_assignment_scope attribute.
    /// </summary>
    public TerraformValue<string>? DynamicVnetAssignmentScope
    {
        get => GetArgument<TerraformValue<string>>("dynamic_vnet_assignment_scope");
        set => SetArgument("dynamic_vnet_assignment_scope", value);
    }

    /// <summary>
    /// The public_address_provisioning_type attribute.
    /// </summary>
    public TerraformValue<string>? PublicAddressProvisioningType
    {
        get => GetArgument<TerraformValue<string>>("public_address_provisioning_type");
        set => SetArgument("public_address_provisioning_type", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformSet<string>? PublicIps
    {
        get => GetArgument<TerraformSet<string>>("public_ips");
        set => SetArgument("public_ips", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// EndpointConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetArgument<TerraformList<AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlock>>("endpoint_configuration");
        set => SetArgument("endpoint_configuration", value);
    }

}

/// <summary>
/// Block type for endpoint_configuration in AzurermBatchPoolNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_configuration";

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    public required TerraformValue<double> BackendPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("backend_port");
        set => SetArgument("backend_port", value);
    }

    /// <summary>
    /// The frontend_port_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPortRange is required")]
    public required TerraformValue<string> FrontendPortRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("frontend_port_range");
        set => SetArgument("frontend_port_range", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// NetworkSecurityGroupRules block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlockNetworkSecurityGroupRulesBlock>? NetworkSecurityGroupRules
    {
        get => GetArgument<TerraformList<AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlockNetworkSecurityGroupRulesBlock>>("network_security_group_rules");
        set => SetArgument("network_security_group_rules", value);
    }

}

/// <summary>
/// Block type for network_security_group_rules in AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNetworkConfigurationBlockEndpointConfigurationBlockNetworkSecurityGroupRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_security_group_rules";

    /// <summary>
    /// The access attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Access is required")]
    public required TerraformValue<string> Access
    {
        get => GetRequiredArgument<TerraformValue<string>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The source_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceAddressPrefix is required")]
    public required TerraformValue<string> SourceAddressPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_address_prefix");
        set => SetArgument("source_address_prefix", value);
    }

    /// <summary>
    /// The source_port_ranges attribute.
    /// </summary>
    public TerraformList<string> SourcePortRanges
    {
        get => GetArgument<TerraformList<string>>("source_port_ranges") ?? CreateReference("source_port_ranges");
        set => SetArgument("source_port_ranges", value);
    }

}


/// <summary>
/// Block type for node_placement in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolNodePlacementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_placement";

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

}


/// <summary>
/// Block type for security_profile in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolSecurityProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_profile";

    /// <summary>
    /// The host_encryption_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? HostEncryptionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("host_encryption_enabled");
        set => SetArgument("host_encryption_enabled", value);
    }

    /// <summary>
    /// The secure_boot_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecureBootEnabled
    {
        get => GetArgument<TerraformValue<bool>>("secure_boot_enabled");
        set => SetArgument("secure_boot_enabled", value);
    }

    /// <summary>
    /// The security_type attribute.
    /// </summary>
    public TerraformValue<string>? SecurityType
    {
        get => GetArgument<TerraformValue<string>>("security_type");
        set => SetArgument("security_type", value);
    }

    /// <summary>
    /// The vtpm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VtpmEnabled
    {
        get => GetArgument<TerraformValue<bool>>("vtpm_enabled");
        set => SetArgument("vtpm_enabled", value);
    }

}


/// <summary>
/// Block type for start_task in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_task";

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CommandLine is required")]
    public required TerraformValue<string> CommandLine
    {
        get => GetRequiredArgument<TerraformValue<string>>("command_line");
        set => SetArgument("command_line", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public TerraformMap<string>? CommonEnvironmentProperties
    {
        get => GetArgument<TerraformMap<string>>("common_environment_properties");
        set => SetArgument("common_environment_properties", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformValue<double>? TaskRetryMaximum
    {
        get => GetArgument<TerraformValue<double>>("task_retry_maximum");
        set => SetArgument("task_retry_maximum", value);
    }

    /// <summary>
    /// The wait_for_success attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForSuccess
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_success");
        set => SetArgument("wait_for_success", value);
    }

    /// <summary>
    /// Container block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolStartTaskBlockContainerBlock>? Container
    {
        get => GetArgument<TerraformList<AzurermBatchPoolStartTaskBlockContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// ResourceFile block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolStartTaskBlockResourceFileBlock>? ResourceFile
    {
        get => GetArgument<TerraformList<AzurermBatchPoolStartTaskBlockResourceFileBlock>>("resource_file");
        set => SetArgument("resource_file", value);
    }

    /// <summary>
    /// UserIdentity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UserIdentity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserIdentity block(s) allowed")]
    public required TerraformList<AzurermBatchPoolStartTaskBlockUserIdentityBlock> UserIdentity
    {
        get => GetRequiredArgument<TerraformList<AzurermBatchPoolStartTaskBlockUserIdentityBlock>>("user_identity");
        set => SetArgument("user_identity", value);
    }

}

/// <summary>
/// Block type for container in AzurermBatchPoolStartTaskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlockContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => GetRequiredArgument<TerraformValue<string>>("image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The run_options attribute.
    /// </summary>
    public TerraformValue<string>? RunOptions
    {
        get => GetArgument<TerraformValue<string>>("run_options");
        set => SetArgument("run_options", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string>? WorkingDirectory
    {
        get => GetArgument<TerraformValue<string>>("working_directory");
        set => SetArgument("working_directory", value);
    }

    /// <summary>
    /// Registry block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolStartTaskBlockContainerBlockRegistryBlock>? Registry
    {
        get => GetArgument<TerraformList<AzurermBatchPoolStartTaskBlockContainerBlockRegistryBlock>>("registry");
        set => SetArgument("registry", value);
    }

}

/// <summary>
/// Block type for registry in AzurermBatchPoolStartTaskBlockContainerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlockContainerBlockRegistryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "registry";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The registry_server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryServer is required")]
    public required TerraformValue<string> RegistryServer
    {
        get => GetRequiredArgument<TerraformValue<string>>("registry_server");
        set => SetArgument("registry_server", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string>? UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

}

/// <summary>
/// Block type for resource_file in AzurermBatchPoolStartTaskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlockResourceFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_file";

    /// <summary>
    /// The auto_storage_container_name attribute.
    /// </summary>
    public TerraformValue<string>? AutoStorageContainerName
    {
        get => GetArgument<TerraformValue<string>>("auto_storage_container_name");
        set => SetArgument("auto_storage_container_name", value);
    }

    /// <summary>
    /// The blob_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BlobPrefix
    {
        get => GetArgument<TerraformValue<string>>("blob_prefix");
        set => SetArgument("blob_prefix", value);
    }

    /// <summary>
    /// The file_mode attribute.
    /// </summary>
    public TerraformValue<string>? FileMode
    {
        get => GetArgument<TerraformValue<string>>("file_mode");
        set => SetArgument("file_mode", value);
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformValue<string>? FilePath
    {
        get => GetArgument<TerraformValue<string>>("file_path");
        set => SetArgument("file_path", value);
    }

    /// <summary>
    /// The http_url attribute.
    /// </summary>
    public TerraformValue<string>? HttpUrl
    {
        get => GetArgument<TerraformValue<string>>("http_url");
        set => SetArgument("http_url", value);
    }

    /// <summary>
    /// The storage_container_url attribute.
    /// </summary>
    public TerraformValue<string>? StorageContainerUrl
    {
        get => GetArgument<TerraformValue<string>>("storage_container_url");
        set => SetArgument("storage_container_url", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for user_identity in AzurermBatchPoolStartTaskBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlockUserIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_identity";

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformValue<string>? UserName
    {
        get => GetArgument<TerraformValue<string>>("user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// AutoUser block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoUser block(s) allowed")]
    public TerraformList<AzurermBatchPoolStartTaskBlockUserIdentityBlockAutoUserBlock>? AutoUser
    {
        get => GetArgument<TerraformList<AzurermBatchPoolStartTaskBlockUserIdentityBlockAutoUserBlock>>("auto_user");
        set => SetArgument("auto_user", value);
    }

}

/// <summary>
/// Block type for auto_user in AzurermBatchPoolStartTaskBlockUserIdentityBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStartTaskBlockUserIdentityBlockAutoUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_user";

    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    public TerraformValue<string>? ElevationLevel
    {
        get => GetArgument<TerraformValue<string>>("elevation_level");
        set => SetArgument("elevation_level", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for storage_image_reference in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolStorageImageReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_image_reference";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformValue<string>? Offer
    {
        get => GetArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformValue<string>? Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for task_scheduling_policy in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolTaskSchedulingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_scheduling_policy";

    /// <summary>
    /// The node_fill_type attribute.
    /// </summary>
    public TerraformValue<string> NodeFillType
    {
        get => GetArgument<TerraformValue<string>>("node_fill_type") ?? CreateReference("node_fill_type");
        set => SetArgument("node_fill_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermBatchPool.
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_accounts in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_accounts";

    /// <summary>
    /// The elevation_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElevationLevel is required")]
    public required TerraformValue<string> ElevationLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("elevation_level");
        set => SetArgument("elevation_level", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// LinuxUserConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolUserAccountsBlockLinuxUserConfigurationBlock>? LinuxUserConfiguration
    {
        get => GetArgument<TerraformList<AzurermBatchPoolUserAccountsBlockLinuxUserConfigurationBlock>>("linux_user_configuration");
        set => SetArgument("linux_user_configuration", value);
    }

    /// <summary>
    /// WindowsUserConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolUserAccountsBlockWindowsUserConfigurationBlock>? WindowsUserConfiguration
    {
        get => GetArgument<TerraformList<AzurermBatchPoolUserAccountsBlockWindowsUserConfigurationBlock>>("windows_user_configuration");
        set => SetArgument("windows_user_configuration", value);
    }

}

/// <summary>
/// Block type for linux_user_configuration in AzurermBatchPoolUserAccountsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlockLinuxUserConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linux_user_configuration";

    /// <summary>
    /// The gid attribute.
    /// </summary>
    public TerraformValue<double>? Gid
    {
        get => GetArgument<TerraformValue<double>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// The ssh_private_key attribute.
    /// </summary>
    public TerraformValue<string>? SshPrivateKey
    {
        get => GetArgument<TerraformValue<string>>("ssh_private_key");
        set => SetArgument("ssh_private_key", value);
    }

    /// <summary>
    /// The uid attribute.
    /// </summary>
    public TerraformValue<double>? Uid
    {
        get => GetArgument<TerraformValue<double>>("uid");
        set => SetArgument("uid", value);
    }

}

/// <summary>
/// Block type for windows_user_configuration in AzurermBatchPoolUserAccountsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolUserAccountsBlockWindowsUserConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_user_configuration";

    /// <summary>
    /// The login_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginMode is required")]
    public required TerraformValue<string> LoginMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("login_mode");
        set => SetArgument("login_mode", value);
    }

}


/// <summary>
/// Block type for windows in AzurermBatchPool.
/// Nesting mode: list
/// </summary>
public class AzurermBatchPoolWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows";

    /// <summary>
    /// The enable_automatic_updates attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutomaticUpdates
    {
        get => GetArgument<TerraformValue<bool>>("enable_automatic_updates");
        set => SetArgument("enable_automatic_updates", value);
    }

}


/// <summary>
/// Represents a azurerm_batch_pool Terraform resource.
/// Manages a azurerm_batch_pool resource.
/// </summary>
public partial class AzurermBatchPool(string name) : TerraformResource("azurerm_batch_pool", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformValue<string>? InterNodeCommunication
    {
        get => GetArgument<TerraformValue<string>>("inter_node_communication");
        set => SetArgument("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformValue<double>? MaxTasksPerNode
    {
        get => GetArgument<TerraformValue<double>>("max_tasks_per_node");
        set => SetArgument("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeAgentSkuId is required")]
    public required TerraformValue<string> NodeAgentSkuId
    {
        get => GetRequiredArgument<TerraformValue<string>>("node_agent_sku_id");
        set => SetArgument("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskPlacement
    {
        get => GetArgument<TerraformValue<string>>("os_disk_placement");
        set => SetArgument("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformValue<bool>? StopPendingResizeOperation
    {
        get => GetArgument<TerraformValue<bool>>("stop_pending_resize_operation");
        set => SetArgument("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformValue<string>? TargetNodeCommunicationMode
    {
        get => GetArgument<TerraformValue<string>>("target_node_communication_mode");
        set => SetArgument("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmSize is required")]
    public required TerraformValue<string> VmSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("vm_size");
        set => SetArgument("vm_size", value);
    }

    /// <summary>
    /// AutoScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScale block(s) allowed")]
    public TerraformList<AzurermBatchPoolAutoScaleBlock>? AutoScale
    {
        get => GetArgument<TerraformList<AzurermBatchPoolAutoScaleBlock>>("auto_scale");
        set => SetArgument("auto_scale", value);
    }

    /// <summary>
    /// Certificate block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermBatchPoolCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// ContainerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerConfiguration block(s) allowed")]
    public TerraformList<AzurermBatchPoolContainerConfigurationBlock>? ContainerConfiguration
    {
        get => GetArgument<TerraformList<AzurermBatchPoolContainerConfigurationBlock>>("container_configuration");
        set => SetArgument("container_configuration", value);
    }

    /// <summary>
    /// DataDisks block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolDataDisksBlock>? DataDisks
    {
        get => GetArgument<TerraformList<AzurermBatchPoolDataDisksBlock>>("data_disks");
        set => SetArgument("data_disks", value);
    }

    /// <summary>
    /// DiskEncryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolDiskEncryptionBlock>? DiskEncryption
    {
        get => GetArgument<TerraformList<AzurermBatchPoolDiskEncryptionBlock>>("disk_encryption");
        set => SetArgument("disk_encryption", value);
    }

    /// <summary>
    /// Extensions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolExtensionsBlock>? Extensions
    {
        get => GetArgument<TerraformList<AzurermBatchPoolExtensionsBlock>>("extensions");
        set => SetArgument("extensions", value);
    }

    /// <summary>
    /// FixedScale block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedScale block(s) allowed")]
    public TerraformList<AzurermBatchPoolFixedScaleBlock>? FixedScale
    {
        get => GetArgument<TerraformList<AzurermBatchPoolFixedScaleBlock>>("fixed_scale");
        set => SetArgument("fixed_scale", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermBatchPoolIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermBatchPoolIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Mount block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolMountBlock>? Mount
    {
        get => GetArgument<TerraformList<AzurermBatchPoolMountBlock>>("mount");
        set => SetArgument("mount", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AzurermBatchPoolNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AzurermBatchPoolNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// NodePlacement block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolNodePlacementBlock>? NodePlacement
    {
        get => GetArgument<TerraformList<AzurermBatchPoolNodePlacementBlock>>("node_placement");
        set => SetArgument("node_placement", value);
    }

    /// <summary>
    /// SecurityProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityProfile block(s) allowed")]
    public TerraformList<AzurermBatchPoolSecurityProfileBlock>? SecurityProfile
    {
        get => GetArgument<TerraformList<AzurermBatchPoolSecurityProfileBlock>>("security_profile");
        set => SetArgument("security_profile", value);
    }

    /// <summary>
    /// StartTask block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTask block(s) allowed")]
    public TerraformList<AzurermBatchPoolStartTaskBlock>? StartTask
    {
        get => GetArgument<TerraformList<AzurermBatchPoolStartTaskBlock>>("start_task");
        set => SetArgument("start_task", value);
    }

    /// <summary>
    /// StorageImageReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageImageReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageImageReference block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageImageReference block(s) allowed")]
    public required TerraformList<AzurermBatchPoolStorageImageReferenceBlock> StorageImageReference
    {
        get => GetRequiredArgument<TerraformList<AzurermBatchPoolStorageImageReferenceBlock>>("storage_image_reference");
        set => SetArgument("storage_image_reference", value);
    }

    /// <summary>
    /// TaskSchedulingPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolTaskSchedulingPolicyBlock>? TaskSchedulingPolicy
    {
        get => GetArgument<TerraformList<AzurermBatchPoolTaskSchedulingPolicyBlock>>("task_scheduling_policy");
        set => SetArgument("task_scheduling_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserAccounts block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolUserAccountsBlock>? UserAccounts
    {
        get => GetArgument<TerraformList<AzurermBatchPoolUserAccountsBlock>>("user_accounts");
        set => SetArgument("user_accounts", value);
    }

    /// <summary>
    /// Windows block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermBatchPoolWindowsBlock>? Windows
    {
        get => GetArgument<TerraformList<AzurermBatchPoolWindowsBlock>>("windows");
        set => SetArgument("windows", value);
    }

}
