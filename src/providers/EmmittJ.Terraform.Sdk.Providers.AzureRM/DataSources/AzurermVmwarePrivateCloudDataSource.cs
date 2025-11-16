using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Circuit
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "circuit").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HcxCloudManagerEndpoint
    {
        get => new TerraformReference<string>(this, "hcx_cloud_manager_endpoint");
    }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InternetConnectionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_connection_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagementCluster
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "management_cluster").ResolveNodes(ctx));
    }

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> ManagementSubnetCidr
    {
        get => new TerraformReference<string>(this, "management_subnet_cidr");
    }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> NetworkSubnetCidr
    {
        get => new TerraformReference<string>(this, "network_subnet_cidr");
    }

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> NsxtCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "nsxt_certificate_thumbprint");
    }

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    public TerraformValue<string> NsxtManagerEndpoint
    {
        get => new TerraformReference<string>(this, "nsxt_manager_endpoint");
    }

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningSubnetCidr
    {
        get => new TerraformReference<string>(this, "provisioning_subnet_cidr");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> VcenterCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "vcenter_certificate_thumbprint");
    }

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    public TerraformValue<string> VcsaEndpoint
    {
        get => new TerraformReference<string>(this, "vcsa_endpoint");
    }

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    public TerraformValue<string> VmotionSubnetCidr
    {
        get => new TerraformReference<string>(this, "vmotion_subnet_cidr");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwarePrivateCloudDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwarePrivateCloudDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
