using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermWorkloadsSapSingleNodeVirtualInstance.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceIdentityBlock : TerraformBlock
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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for single_server_configuration in AzurermWorkloadsSapSingleNodeVirtualInstance.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_server_configuration";

    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    public required TerraformValue<string> AppResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("app_resource_group_name");
        set => SetArgument("app_resource_group_name", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformValue<string>? DatabaseType
    {
        get => GetArgument<TerraformValue<string>>("database_type");
        set => SetArgument("database_type", value);
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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// DiskVolumeConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockDiskVolumeConfigurationBlock>? DiskVolumeConfiguration
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockDiskVolumeConfigurationBlock>>("disk_volume_configuration");
        set => SetArgument("disk_volume_configuration", value);
    }

    /// <summary>
    /// VirtualMachineConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VirtualMachineConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlock> VirtualMachineConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlock>>("virtual_machine_configuration");
        set => SetArgument("virtual_machine_configuration", value);
    }

    /// <summary>
    /// VirtualMachineResourceNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualMachineResourceNames block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlock>? VirtualMachineResourceNames
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlock>>("virtual_machine_resource_names");
        set => SetArgument("virtual_machine_resource_names", value);
    }

}

/// <summary>
/// Block type for disk_volume_configuration in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockDiskVolumeConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("number_of_disks");
        set => SetArgument("number_of_disks", value);
    }

    /// <summary>
    /// The size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGb is required")]
    public required TerraformValue<double> SizeInGb
    {
        get => GetArgument<TerraformValue<double>>("size_in_gb");
        set => SetArgument("size_in_gb", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}

/// <summary>
/// Block type for virtual_machine_configuration in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("virtual_machine_size");
        set => SetArgument("virtual_machine_size", value);
    }

    /// <summary>
    /// Image block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Image block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Image block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock> Image
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock>>("image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// OsProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OsProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OsProfile block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock> OsProfile
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock>>("os_profile");
        set => SetArgument("os_profile", value);
    }

}

/// <summary>
/// Block type for image in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockImageBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => GetArgument<TerraformValue<string>>("publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for os_profile in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineConfigurationBlockOsProfileBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The ssh_private_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPrivateKey is required")]
    public required TerraformValue<string> SshPrivateKey
    {
        get => GetArgument<TerraformValue<string>>("ssh_private_key");
        set => SetArgument("ssh_private_key", value);
    }

    /// <summary>
    /// The ssh_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SshPublicKey is required")]
    public required TerraformValue<string> SshPublicKey
    {
        get => GetArgument<TerraformValue<string>>("ssh_public_key");
        set => SetArgument("ssh_public_key", value);
    }

}

/// <summary>
/// Block type for virtual_machine_resource_names in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "virtual_machine_resource_names";

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
    public TerraformSet<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlockDataDiskBlock>? DataDisk
    {
        get => GetArgument<TerraformSet<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlockDataDiskBlock>>("data_disk");
        set => SetArgument("data_disk", value);
    }

}

/// <summary>
/// Block type for data_disk in AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlock.
/// Nesting mode: set
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlockVirtualMachineResourceNamesBlockDataDiskBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWorkloadsSapSingleNodeVirtualInstance.
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_workloads_sap_single_node_virtual_instance Terraform resource.
/// Manages a azurerm_workloads_sap_single_node_virtual_instance resource.
/// </summary>
public partial class AzurermWorkloadsSapSingleNodeVirtualInstance(string name) : TerraformResource("azurerm_workloads_sap_single_node_virtual_instance", name)
{
    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    public required TerraformValue<string> AppLocation
    {
        get => GetArgument<TerraformValue<string>>("app_location");
        set => SetArgument("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    public required TerraformValue<string> SapFqdn
    {
        get => GetArgument<TerraformValue<string>>("sap_fqdn");
        set => SetArgument("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformValue<string> SapProduct
    {
        get => GetArgument<TerraformValue<string>>("sap_product");
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
    public TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// SingleServerConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SingleServerConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SingleServerConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleServerConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock> SingleServerConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock>>("single_server_configuration");
        set => SetArgument("single_server_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWorkloadsSapSingleNodeVirtualInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWorkloadsSapSingleNodeVirtualInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
