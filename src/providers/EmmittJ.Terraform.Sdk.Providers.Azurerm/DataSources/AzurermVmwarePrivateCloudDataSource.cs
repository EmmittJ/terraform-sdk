using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVmwarePrivateCloudDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVmwarePrivateCloudDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_vmware_private_cloud Terraform data source.
/// Retrieves information about a azurerm_vmware_private_cloud.
/// </summary>
public partial class AzurermVmwarePrivateCloudDataSource(string name) : TerraformDataSource("azurerm_vmware_private_cloud", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InternetConnectionEnabled
        => AsReference("internet_connection_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementCluster
        => AsReference("management_cluster");

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> ManagementSubnetCidr
        => AsReference("management_subnet_cidr");

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> NetworkSubnetCidr
        => AsReference("network_subnet_cidr");

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
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwarePrivateCloudDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwarePrivateCloudDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
