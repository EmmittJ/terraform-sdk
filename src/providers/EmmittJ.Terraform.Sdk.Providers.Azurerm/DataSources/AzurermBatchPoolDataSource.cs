using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBatchPoolDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScale
        => CreateReference("auto_scale");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificate
        => CreateReference("certificate");

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContainerConfiguration
        => CreateReference("container_configuration");

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataDisks
        => CreateReference("data_disks");

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskEncryption
        => CreateReference("disk_encryption");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Extensions
        => CreateReference("extensions");

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FixedScale
        => CreateReference("fixed_scale");

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformValue<string> InterNodeCommunication
        => CreateReference("inter_node_communication");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
        => CreateReference("license_type");

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformValue<double> MaxTasksPerNode
        => CreateReference("max_tasks_per_node");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// The mount attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Mount
        => CreateReference("mount");

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfiguration
        => CreateReference("network_configuration");

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformValue<string> NodeAgentSkuId
        => CreateReference("node_agent_sku_id");

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePlacement
        => CreateReference("node_placement");

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformValue<string> OsDiskPlacement
        => CreateReference("os_disk_placement");

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StartTask
        => CreateReference("start_task");

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageImageReference
        => CreateReference("storage_image_reference");

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TaskSchedulingPolicy
        => CreateReference("task_scheduling_policy");

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserAccounts
        => CreateReference("user_accounts");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
        => CreateReference("vm_size");

    /// <summary>
    /// The windows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Windows
        => CreateReference("windows");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
