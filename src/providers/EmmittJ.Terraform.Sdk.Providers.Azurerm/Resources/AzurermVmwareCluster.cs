using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVmwareCluster.
/// Nesting mode: single
/// </summary>
public class AzurermVmwareClusterTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vmware_cluster Terraform resource.
/// Manages a azurerm_vmware_cluster resource.
/// </summary>
public partial class AzurermVmwareCluster(string name) : TerraformResource("azurerm_vmware_cluster", name)
{
    /// <summary>
    /// The cluster_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterNodeCount is required")]
    public required TerraformValue<double> ClusterNodeCount
    {
        get => GetArgument<TerraformValue<double>>("cluster_node_count");
        set => SetArgument("cluster_node_count", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The vmware_cloud_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareCloudId is required")]
    public required TerraformValue<string> VmwareCloudId
    {
        get => GetArgument<TerraformValue<string>>("vmware_cloud_id");
        set => SetArgument("vmware_cloud_id", value);
    }

    /// <summary>
    /// The cluster_number attribute.
    /// </summary>
    public TerraformValue<double> ClusterNumber
        => AsReference("cluster_number");

    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public TerraformList<string> Hosts
        => AsReference("hosts");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVmwareClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVmwareClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
