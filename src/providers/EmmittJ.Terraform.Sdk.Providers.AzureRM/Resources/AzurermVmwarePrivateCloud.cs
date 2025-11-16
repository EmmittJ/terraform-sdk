using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    /// The hosts attribute.
    /// </summary>
    public TerraformList<string> Hosts
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "hosts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<double> Id
    {
        get => new TerraformReference<double>(this, "id");
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_connection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetConnectionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_connection_enabled");
        set => SetArgument("internet_connection_enabled", value);
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
    /// The network_subnet_cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSubnetCidr is required")]
    public required TerraformValue<string> NetworkSubnetCidr
    {
        get => new TerraformReference<string>(this, "network_subnet_cidr");
        set => SetArgument("network_subnet_cidr", value);
    }

    /// <summary>
    /// The nsxt_password attribute.
    /// </summary>
    public TerraformValue<string>? NsxtPassword
    {
        get => new TerraformReference<string>(this, "nsxt_password");
        set => SetArgument("nsxt_password", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// The vcenter_password attribute.
    /// </summary>
    public TerraformValue<string>? VcenterPassword
    {
        get => new TerraformReference<string>(this, "vcenter_password");
        set => SetArgument("vcenter_password", value);
    }

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
