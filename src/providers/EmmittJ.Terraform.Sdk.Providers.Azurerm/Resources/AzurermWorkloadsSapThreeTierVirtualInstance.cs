using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermWorkloadsSapThreeTierVirtualInstance.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock : TerraformBlock
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
/// Block type for three_tier_configuration in AzurermWorkloadsSapThreeTierVirtualInstance.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "three_tier_configuration";

    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    public required TerraformValue<string> AppResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_resource_group_name");
        set => SetArgument("app_resource_group_name", value);
    }

    /// <summary>
    /// The high_availability_type attribute.
    /// </summary>
    public TerraformValue<string>? HighAvailabilityType
    {
        get => GetArgument<TerraformValue<string>>("high_availability_type");
        set => SetArgument("high_availability_type", value);
    }

    /// <summary>
    /// The secondary_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecondaryIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("secondary_ip_enabled");
        set => SetArgument("secondary_ip_enabled", value);
    }

    /// <summary>
    /// ApplicationServerConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationServerConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationServerConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationServerConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlock> ApplicationServerConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlock>>("application_server_configuration");
        set => SetArgument("application_server_configuration", value);
    }

    /// <summary>
    /// CentralServerConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CentralServerConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CentralServerConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CentralServerConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlock> CentralServerConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlock>>("central_server_configuration");
        set => SetArgument("central_server_configuration", value);
    }

    /// <summary>
    /// DatabaseServerConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseServerConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatabaseServerConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseServerConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlock> DatabaseServerConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlock>>("database_server_configuration");
        set => SetArgument("database_server_configuration", value);
    }

    /// <summary>
    /// ResourceNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceNames block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock>? ResourceNames
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock>>("resource_names");
        set => SetArgument("resource_names", value);
    }

    /// <summary>
    /// TransportCreateAndMount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransportCreateAndMount block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockTransportCreateAndMountBlock>? TransportCreateAndMount
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockTransportCreateAndMountBlock>>("transport_create_and_mount");
        set => SetArgument("transport_create_and_mount", value);
    }

}

/// <summary>
/// Block type for application_server_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_server_configuration";

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// VirtualMachineConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualMachineConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlock> VirtualMachineConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlock>>("virtual_machine_configuration");
        set => SetArgument("virtual_machine_configuration", value);
    }

}

/// <summary>
/// Block type for virtual_machine_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_configuration";

    /// <summary>
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    public required TerraformValue<string> VirtualMachineSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_machine_size");
        set => SetArgument("virtual_machine_size", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Image block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock> Image
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock> OsProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

}

/// <summary>
/// Block type for image in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => GetRequiredArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for os_profile in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockApplicationServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The ssh_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPrivateKey is required")]
    public required TerraformValue<string> SshPrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_private_key");
        set => SetArgument("ssh_private_key", value);
    }

    /// <summary>
    /// The ssh_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKey is required")]
    public required TerraformValue<string> SshPublicKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_public_key");
        set => SetArgument("ssh_public_key", value);
    }

}

/// <summary>
/// Block type for central_server_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "central_server_configuration";

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// VirtualMachineConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualMachineConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlock> VirtualMachineConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlock>>("virtual_machine_configuration");
        set => SetArgument("virtual_machine_configuration", value);
    }

}

/// <summary>
/// Block type for virtual_machine_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_configuration";

    /// <summary>
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    public required TerraformValue<string> VirtualMachineSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_machine_size");
        set => SetArgument("virtual_machine_size", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Image block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock> Image
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock> OsProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

}

/// <summary>
/// Block type for image in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => GetRequiredArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for os_profile in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockCentralServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The ssh_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPrivateKey is required")]
    public required TerraformValue<string> SshPrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_private_key");
        set => SetArgument("ssh_private_key", value);
    }

    /// <summary>
    /// The ssh_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKey is required")]
    public required TerraformValue<string> SshPublicKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_public_key");
        set => SetArgument("ssh_public_key", value);
    }

}

/// <summary>
/// Block type for database_server_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_server_configuration";

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseType
    {
        get => GetArgument<TerraformValue<string>>("database_type");
        set => SetArgument("database_type", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// DiskVolumeConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockDiskVolumeConfigurationBlock>? DiskVolumeConfiguration
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockDiskVolumeConfigurationBlock>>("disk_volume_configuration");
        set => SetArgument("disk_volume_configuration", value);
    }

    /// <summary>
    /// VirtualMachineConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualMachineConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlock> VirtualMachineConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlock>>("virtual_machine_configuration");
        set => SetArgument("virtual_machine_configuration", value);
    }

}

/// <summary>
/// Block type for disk_volume_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockDiskVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_volume_configuration";

    /// <summary>
    /// The number_of_disks attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfDisks is required")]
    public required TerraformValue<double> NumberOfDisks
    {
        get => GetRequiredArgument<TerraformValue<double>>("number_of_disks");
        set => SetArgument("number_of_disks", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    public required TerraformValue<double> SizeInGb
    {
        get => GetRequiredArgument<TerraformValue<double>>("size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}

/// <summary>
/// Block type for virtual_machine_configuration in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_configuration";

    /// <summary>
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    public required TerraformValue<string> VirtualMachineSize
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_machine_size");
        set => SetArgument("virtual_machine_size", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Image block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock> Image
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock> OsProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

}

/// <summary>
/// Block type for image in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image";

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => GetRequiredArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for os_profile in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockDatabaseServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_profile";

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminUsername is required")]
    public required TerraformValue<string> AdminUsername
    {
        get => GetRequiredArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The ssh_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPrivateKey is required")]
    public required TerraformValue<string> SshPrivateKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_private_key");
        set => SetArgument("ssh_private_key", value);
    }

    /// <summary>
    /// The ssh_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKey is required")]
    public required TerraformValue<string> SshPublicKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("ssh_public_key");
        set => SetArgument("ssh_public_key", value);
    }

}

/// <summary>
/// Block type for resource_names in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_names";

    /// <summary>
    /// ApplicationServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationServer block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlock>? ApplicationServer
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlock>>("application_server");
        set => SetArgument("application_server", value);
    }

    /// <summary>
    /// CentralServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CentralServer block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlock>? CentralServer
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlock>>("central_server");
        set => SetArgument("central_server", value);
    }

    /// <summary>
    /// DatabaseServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseServer block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlock>? DatabaseServer
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlock>>("database_server");
        set => SetArgument("database_server", value);
    }

    /// <summary>
    /// SharedStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SharedStorage block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockSharedStorageBlock>? SharedStorage
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockSharedStorageBlock>>("shared_storage");
        set => SetArgument("shared_storage", value);
    }

}

/// <summary>
/// Block type for application_server in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_server";

    /// <summary>
    /// The availability_set_name attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilitySetName
    {
        get => GetArgument<TerraformValue<string>>("availability_set_name");
        set => SetArgument("availability_set_name", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}

/// <summary>
/// Block type for virtual_machine in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => GetArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The network_interface_names attribute.
    /// </summary>
    public TerraformList<string>? NetworkInterfaceNames
    {
        get => GetArgument<TerraformList<string>>("network_interface_names");
        set => SetArgument("network_interface_names", value);
    }

    /// <summary>
    /// The os_disk_name attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskName
    {
        get => GetArgument<TerraformValue<string>>("os_disk_name");
        set => SetArgument("os_disk_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualMachineName
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_name");
        set => SetArgument("virtual_machine_name", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlockDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlockDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

}

/// <summary>
/// Block type for data_disk in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockApplicationServerBlockVirtualMachineBlockDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Names is required")]
    public TerraformList<string>? Names
    {
        get => GetArgument<TerraformList<string>>("names");
        set => SetArgument("names", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}

/// <summary>
/// Block type for central_server in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "central_server";

    /// <summary>
    /// The availability_set_name attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilitySetName
    {
        get => GetArgument<TerraformValue<string>>("availability_set_name");
        set => SetArgument("availability_set_name", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}

/// <summary>
/// Block type for load_balancer in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// The backend_pool_names attribute.
    /// </summary>
    public TerraformList<string>? BackendPoolNames
    {
        get => GetArgument<TerraformList<string>>("backend_pool_names");
        set => SetArgument("backend_pool_names", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_names attribute.
    /// </summary>
    public TerraformList<string>? FrontendIpConfigurationNames
    {
        get => GetArgument<TerraformList<string>>("frontend_ip_configuration_names");
        set => SetArgument("frontend_ip_configuration_names", value);
    }

    /// <summary>
    /// The health_probe_names attribute.
    /// </summary>
    public TerraformList<string>? HealthProbeNames
    {
        get => GetArgument<TerraformList<string>>("health_probe_names");
        set => SetArgument("health_probe_names", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for virtual_machine in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => GetArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The network_interface_names attribute.
    /// </summary>
    public TerraformList<string>? NetworkInterfaceNames
    {
        get => GetArgument<TerraformList<string>>("network_interface_names");
        set => SetArgument("network_interface_names", value);
    }

    /// <summary>
    /// The os_disk_name attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskName
    {
        get => GetArgument<TerraformValue<string>>("os_disk_name");
        set => SetArgument("os_disk_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualMachineName
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_name");
        set => SetArgument("virtual_machine_name", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlockDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlockDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

}

/// <summary>
/// Block type for data_disk in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockCentralServerBlockVirtualMachineBlockDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Names is required")]
    public TerraformList<string>? Names
    {
        get => GetArgument<TerraformList<string>>("names");
        set => SetArgument("names", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}

/// <summary>
/// Block type for database_server in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_server";

    /// <summary>
    /// The availability_set_name attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilitySetName
    {
        get => GetArgument<TerraformValue<string>>("availability_set_name");
        set => SetArgument("availability_set_name", value);
    }

    /// <summary>
    /// LoadBalancer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancer block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockLoadBalancerBlock>? LoadBalancer
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockLoadBalancerBlock>>("load_balancer");
        set => SetArgument("load_balancer", value);
    }

    /// <summary>
    /// VirtualMachine block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlock>? VirtualMachine
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlock>>("virtual_machine");
        set => SetArgument("virtual_machine", value);
    }

}

/// <summary>
/// Block type for load_balancer in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockLoadBalancerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer";

    /// <summary>
    /// The backend_pool_names attribute.
    /// </summary>
    public TerraformList<string>? BackendPoolNames
    {
        get => GetArgument<TerraformList<string>>("backend_pool_names");
        set => SetArgument("backend_pool_names", value);
    }

    /// <summary>
    /// The frontend_ip_configuration_names attribute.
    /// </summary>
    public TerraformList<string>? FrontendIpConfigurationNames
    {
        get => GetArgument<TerraformList<string>>("frontend_ip_configuration_names");
        set => SetArgument("frontend_ip_configuration_names", value);
    }

    /// <summary>
    /// The health_probe_names attribute.
    /// </summary>
    public TerraformList<string>? HealthProbeNames
    {
        get => GetArgument<TerraformList<string>>("health_probe_names");
        set => SetArgument("health_probe_names", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for virtual_machine in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string>? HostName
    {
        get => GetArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The network_interface_names attribute.
    /// </summary>
    public TerraformList<string>? NetworkInterfaceNames
    {
        get => GetArgument<TerraformList<string>>("network_interface_names");
        set => SetArgument("network_interface_names", value);
    }

    /// <summary>
    /// The os_disk_name attribute.
    /// </summary>
    public TerraformValue<string>? OsDiskName
    {
        get => GetArgument<TerraformValue<string>>("os_disk_name");
        set => SetArgument("os_disk_name", value);
    }

    /// <summary>
    /// The virtual_machine_name attribute.
    /// </summary>
    public TerraformValue<string>? VirtualMachineName
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_name");
        set => SetArgument("virtual_machine_name", value);
    }

    /// <summary>
    /// DataDisk block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlockDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlockDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

}

/// <summary>
/// Block type for data_disk in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockDatabaseServerBlockVirtualMachineBlockDataDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_disk";

    /// <summary>
    /// The names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Names is required")]
    public TerraformList<string>? Names
    {
        get => GetArgument<TerraformList<string>>("names");
        set => SetArgument("names", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}

/// <summary>
/// Block type for shared_storage in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockResourceNamesBlockSharedStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "shared_storage";

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformValue<string>? AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The private_endpoint_name attribute.
    /// </summary>
    public TerraformValue<string>? PrivateEndpointName
    {
        get => GetArgument<TerraformValue<string>>("private_endpoint_name");
        set => SetArgument("private_endpoint_name", value);
    }

}

/// <summary>
/// Block type for transport_create_and_mount in AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlockTransportCreateAndMountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transport_create_and_mount";

    /// <summary>
    /// The resource_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroupId
    {
        get => GetArgument<TerraformValue<string>>("resource_group_id");
        set => SetArgument("resource_group_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWorkloadsSapThreeTierVirtualInstance.
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_workloads_sap_three_tier_virtual_instance Terraform resource.
/// Manages a azurerm_workloads_sap_three_tier_virtual_instance resource.
/// </summary>
public partial class AzurermWorkloadsSapThreeTierVirtualInstance(string name) : TerraformResource("azurerm_workloads_sap_three_tier_virtual_instance", name)
{
    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    public required TerraformValue<string> AppLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_location");
        set => SetArgument("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetRequiredArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourcesNetworkAccessType
    {
        get => GetArgument<TerraformValue<string>>("managed_resources_network_access_type");
        set => SetArgument("managed_resources_network_access_type", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    public required TerraformValue<string> SapFqdn
    {
        get => GetRequiredArgument<TerraformValue<string>>("sap_fqdn");
        set => SetArgument("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformValue<string> SapProduct
    {
        get => GetRequiredArgument<TerraformValue<string>>("sap_product");
        set => SetArgument("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ThreeTierConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreeTierConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ThreeTierConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreeTierConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock> ThreeTierConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock>>("three_tier_configuration");
        set => SetArgument("three_tier_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
