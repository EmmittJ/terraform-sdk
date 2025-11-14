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
/// Block type for management_cluster in .
/// Nesting mode: list
/// </summary>
public class AzurermVmwarePrivateCloudManagementClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "management_cluster";



    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformArgument("size")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
/// Manages a azurerm_vmware_private_cloud resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVmwarePrivateCloud : TerraformResource
{
    public AzurermVmwarePrivateCloud(string name) : base("azurerm_vmware_private_cloud", name)
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
    /// The internet_connection_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_connection_enabled")]
    public TerraformValue<bool>? InternetConnectionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_connection_enabled");
        set => SetArgument("internet_connection_enabled", value);
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
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    [TerraformArgument("network_subnet_cidr")]
    public required TerraformValue<string> NetworkSubnetCidr
    {
        get => new TerraformReference<string>(this, "network_subnet_cidr");
        set => SetArgument("network_subnet_cidr", value);
    }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    [TerraformArgument("nsxt_password")]
    public TerraformValue<string>? NsxtPassword
    {
        get => new TerraformReference<string>(this, "nsxt_password");
        set => SetArgument("nsxt_password", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// The vcenter_password attribute.
    /// </summary>
    [TerraformArgument("vcenter_password")]
    public TerraformValue<string>? VcenterPassword
    {
        get => new TerraformReference<string>(this, "vcenter_password");
        set => SetArgument("vcenter_password", value);
    }

    /// <summary>
    /// Block for management_cluster.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ManagementCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementCluster block(s) allowed")]
    [TerraformArgument("management_cluster")]
    public required TerraformList<AzurermVmwarePrivateCloudManagementClusterBlock> ManagementCluster { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVmwarePrivateCloudTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The management_subnet_cidr attribute.
    /// </summary>
    [TerraformArgument("management_subnet_cidr")]
    public TerraformValue<string> ManagementSubnetCidr
    {
        get => new TerraformReference<string>(this, "management_subnet_cidr");
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
