using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for management_cluster in AzurermVmwarePrivateCloud.
/// Nesting mode: list
/// </summary>
public class AzurermVmwarePrivateCloudManagementClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_cluster";

    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public TerraformList<string> Hosts
        => AsReference("hosts");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<double> Id
        => AsReference("id");

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => GetRequiredArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVmwarePrivateCloud.
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vmware_private_cloud Terraform resource.
/// Manages a azurerm_vmware_private_cloud resource.
/// </summary>
public partial class AzurermVmwarePrivateCloud(string name) : TerraformResource("azurerm_vmware_private_cloud", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetConnectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internet_connection_enabled");
        set => SetArgument("internet_connection_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    public required TerraformValue<string> NetworkSubnetCidr
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_subnet_cidr");
        set => SetArgument("network_subnet_cidr", value);
    }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    public TerraformValue<string>? NsxtPassword
    {
        get => GetArgument<TerraformValue<string>>("nsxt_password");
        set => SetArgument("nsxt_password", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => GetRequiredArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
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
    /// The vcenter_password attribute.
    /// </summary>
    public TerraformValue<string>? VcenterPassword
    {
        get => GetArgument<TerraformValue<string>>("vcenter_password");
        set => SetArgument("vcenter_password", value);
    }

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Circuit
        => AsReference("circuit");

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HcxCloudManagerEndpoint
        => AsReference("hcx_cloud_manager_endpoint");

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> ManagementSubnetCidr
        => AsReference("management_subnet_cidr");

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> NsxtCertificateThumbprint
        => AsReference("nsxt_certificate_thumbprint");

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    public TerraformValue<string> NsxtManagerEndpoint
        => AsReference("nsxt_manager_endpoint");

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningSubnetCidr
        => AsReference("provisioning_subnet_cidr");

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> VcenterCertificateThumbprint
        => AsReference("vcenter_certificate_thumbprint");

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    public TerraformValue<string> VcsaEndpoint
        => AsReference("vcsa_endpoint");

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> VmotionSubnetCidr
        => AsReference("vmotion_subnet_cidr");

    /// <summary>
    /// ManagementCluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    public required TerraformList<AzurermVmwarePrivateCloudManagementClusterBlock> ManagementCluster
    {
        get => GetRequiredArgument<TerraformList<AzurermVmwarePrivateCloudManagementClusterBlock>>("management_cluster");
        set => SetArgument("management_cluster", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwarePrivateCloudTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwarePrivateCloudTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
