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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_vmware_private_cloud.
/// </summary>
public class AzurermVmwarePrivateCloudDataSource : TerraformDataSource
{
    public AzurermVmwarePrivateCloudDataSource(string name) : base("azurerm_vmware_private_cloud", name)
    {
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVmwarePrivateCloudDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The circuit attribute.
    /// </summary>
    [TerraformArgument("circuit")]
    public TerraformList<object> Circuit
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "circuit").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hcx_cloud_manager_endpoint attribute.
    /// </summary>
    [TerraformArgument("hcx_cloud_manager_endpoint")]
    public TerraformValue<string> HcxCloudManagerEndpoint
    {
        get => new TerraformReference<string>(this, "hcx_cloud_manager_endpoint");
    }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_connection_enabled")]
    public TerraformValue<bool> InternetConnectionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_connection_enabled");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The management_cluster attribute.
    /// </summary>
    [TerraformArgument("management_cluster")]
    public TerraformList<object> ManagementCluster
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "management_cluster").ResolveNodes(ctx));
    }

    /// <summary>
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("management_subnet_cidr")]
    public TerraformValue<string> ManagementSubnetCidr
    {
        get => new TerraformReference<string>(this, "management_subnet_cidr");
    }

    /// <summary>
    /// The network_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("network_subnet_cidr")]
    public TerraformValue<string> NetworkSubnetCidr
    {
        get => new TerraformReference<string>(this, "network_subnet_cidr");
    }

    /// <summary>
    /// The nsxt_certificate_thumbprint attribute.
    /// </summary>
    [TerraformArgument("nsxt_certificate_thumbprint")]
    public TerraformValue<string> NsxtCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "nsxt_certificate_thumbprint");
    }

    /// <summary>
    /// The nsxt_manager_endpoint attribute.
    /// </summary>
    [TerraformArgument("nsxt_manager_endpoint")]
    public TerraformValue<string> NsxtManagerEndpoint
    {
        get => new TerraformReference<string>(this, "nsxt_manager_endpoint");
    }

    /// <summary>
    /// The provisioning_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("provisioning_subnet_cidr")]
    public TerraformValue<string> ProvisioningSubnetCidr
    {
        get => new TerraformReference<string>(this, "provisioning_subnet_cidr");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vcenter_certificate_thumbprint attribute.
    /// </summary>
    [TerraformArgument("vcenter_certificate_thumbprint")]
    public TerraformValue<string> VcenterCertificateThumbprint
    {
        get => new TerraformReference<string>(this, "vcenter_certificate_thumbprint");
    }

    /// <summary>
    /// The vcsa_endpoint attribute.
    /// </summary>
    [TerraformArgument("vcsa_endpoint")]
    public TerraformValue<string> VcsaEndpoint
    {
        get => new TerraformReference<string>(this, "vcsa_endpoint");
    }

    /// <summary>
    /// The vmotion_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("vmotion_subnet_cidr")]
    public TerraformValue<string> VmotionSubnetCidr
    {
        get => new TerraformReference<string>(this, "vmotion_subnet_cidr");
    }

}
