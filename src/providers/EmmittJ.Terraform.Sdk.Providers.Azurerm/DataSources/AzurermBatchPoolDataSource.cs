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
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoScale
        => AsReference("auto_scale");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificate
        => AsReference("certificate");

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContainerConfiguration
        => AsReference("container_configuration");

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataDisks
        => AsReference("data_disks");

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DiskEncryption
        => AsReference("disk_encryption");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Extensions
        => AsReference("extensions");

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FixedScale
        => AsReference("fixed_scale");

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformValue<string> InterNodeCommunication
        => AsReference("inter_node_communication");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
        => AsReference("license_type");

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformValue<double> MaxTasksPerNode
        => AsReference("max_tasks_per_node");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
        => AsReference("metadata");

    /// <summary>
    /// The mount attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Mount
        => AsReference("mount");

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfiguration
        => AsReference("network_configuration");

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformValue<string> NodeAgentSkuId
        => AsReference("node_agent_sku_id");

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodePlacement
        => AsReference("node_placement");

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformValue<string> OsDiskPlacement
        => AsReference("os_disk_placement");

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StartTask
        => AsReference("start_task");

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageImageReference
        => AsReference("storage_image_reference");

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TaskSchedulingPolicy
        => AsReference("task_scheduling_policy");

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserAccounts
        => AsReference("user_accounts");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformValue<string> VmSize
        => AsReference("vm_size");

    /// <summary>
    /// The windows attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Windows
        => AsReference("windows");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBatchPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBatchPoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
