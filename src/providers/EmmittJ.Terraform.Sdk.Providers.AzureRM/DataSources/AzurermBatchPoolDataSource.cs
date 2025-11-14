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
public class AzurermBatchPoolDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_batch_pool.
/// </summary>
public class AzurermBatchPoolDataSource : TerraformDataSource
{
    public AzurermBatchPoolDataSource(string name) : base("azurerm_batch_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
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
    public AzurermBatchPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    [TerraformArgument("auto_scale")]
    public TerraformList<object> AutoScale
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "auto_scale").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformArgument("certificate")]
    public TerraformList<object> Certificate
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "certificate").ResolveNodes(ctx));
    }

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    [TerraformArgument("container_configuration")]
    public TerraformList<object> ContainerConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "container_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    [TerraformArgument("data_disks")]
    public TerraformList<object> DataDisks
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "data_disks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    [TerraformArgument("disk_encryption")]
    public TerraformList<object> DiskEncryption
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "disk_encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    [TerraformArgument("extensions")]
    public TerraformList<object> Extensions
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "extensions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    [TerraformArgument("fixed_scale")]
    public TerraformList<object> FixedScale
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "fixed_scale").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformArgument("inter_node_communication")]
    public TerraformValue<string> InterNodeCommunication
    {
        get => new TerraformReference<string>(this, "inter_node_communication");
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformArgument("max_tasks_per_node")]
    public TerraformValue<double> MaxTasksPerNode
    {
        get => new TerraformReference<double>(this, "max_tasks_per_node");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mount attribute.
    /// </summary>
    [TerraformArgument("mount")]
    public TerraformList<object> Mount
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "mount").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    [TerraformArgument("network_configuration")]
    public TerraformList<object> NetworkConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [TerraformArgument("node_agent_sku_id")]
    public TerraformValue<string> NodeAgentSkuId
    {
        get => new TerraformReference<string>(this, "node_agent_sku_id");
    }

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    [TerraformArgument("node_placement")]
    public TerraformList<object> NodePlacement
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "node_placement").ResolveNodes(ctx));
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformArgument("os_disk_placement")]
    public TerraformValue<string> OsDiskPlacement
    {
        get => new TerraformReference<string>(this, "os_disk_placement");
    }

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    [TerraformArgument("start_task")]
    public TerraformList<object> StartTask
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "start_task").ResolveNodes(ctx));
    }

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    [TerraformArgument("storage_image_reference")]
    public TerraformList<object> StorageImageReference
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "storage_image_reference").ResolveNodes(ctx));
    }

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    [TerraformArgument("task_scheduling_policy")]
    public TerraformList<object> TaskSchedulingPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "task_scheduling_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    [TerraformArgument("user_accounts")]
    public TerraformList<object> UserAccounts
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "user_accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformArgument("vm_size")]
    public TerraformValue<string> VmSize
    {
        get => new TerraformReference<string>(this, "vm_size");
    }

    /// <summary>
    /// The windows attribute.
    /// </summary>
    [TerraformArgument("windows")]
    public TerraformList<object> Windows
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "windows").ResolveNodes(ctx));
    }

}
