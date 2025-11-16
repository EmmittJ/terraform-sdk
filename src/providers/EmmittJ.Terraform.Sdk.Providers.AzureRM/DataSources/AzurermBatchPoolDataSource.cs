using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_batch_pool Terraform data source.
/// Retrieves information about a azurerm_batch_pool.
/// </summary>
public partial class AzurermBatchPoolDataSource(string name) : TerraformDataSource("azurerm_batch_pool", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

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
    /// The auto_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScale
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auto_scale").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificate
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContainerConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "container_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataDisks
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "data_disks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskEncryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "disk_encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Extensions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "extensions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FixedScale
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "fixed_scale").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformValue<string> InterNodeCommunication
    {
        get => new TerraformReference<string>(this, "inter_node_communication");
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformValue<double> MaxTasksPerNode
    {
        get => new TerraformReference<double>(this, "max_tasks_per_node");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mount attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Mount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mount").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformValue<string> NodeAgentSkuId
    {
        get => new TerraformReference<string>(this, "node_agent_sku_id");
    }

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePlacement
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_placement").ResolveNodes(ctx));
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformValue<string> OsDiskPlacement
    {
        get => new TerraformReference<string>(this, "os_disk_placement");
    }

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StartTask
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "start_task").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageImageReference
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "storage_image_reference").ResolveNodes(ctx));
    }

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TaskSchedulingPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "task_scheduling_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserAccounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
    }

    /// <summary>
    /// The windows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Windows
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "windows").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
