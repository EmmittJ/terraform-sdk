using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBatchPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    [TerraformPropertyName("auto_scale")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoScale => new TerraformReference(this, "auto_scale");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Certificate => new TerraformReference(this, "certificate");

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    [TerraformPropertyName("container_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ContainerConfiguration => new TerraformReference(this, "container_configuration");

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    [TerraformPropertyName("data_disks")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataDisks => new TerraformReference(this, "data_disks");

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DiskEncryption => new TerraformReference(this, "disk_encryption");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    [TerraformPropertyName("extensions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Extensions => new TerraformReference(this, "extensions");

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    [TerraformPropertyName("fixed_scale")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FixedScale => new TerraformReference(this, "fixed_scale");

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformPropertyName("inter_node_communication")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InterNodeCommunication => new TerraformReference(this, "inter_node_communication");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseType => new TerraformReference(this, "license_type");

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformPropertyName("max_tasks_per_node")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxTasksPerNode => new TerraformReference(this, "max_tasks_per_node");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The mount attribute.
    /// </summary>
    [TerraformPropertyName("mount")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Mount => new TerraformReference(this, "mount");

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    [TerraformPropertyName("network_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkConfiguration => new TerraformReference(this, "network_configuration");

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [TerraformPropertyName("node_agent_sku_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NodeAgentSkuId => new TerraformReference(this, "node_agent_sku_id");

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    [TerraformPropertyName("node_placement")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NodePlacement => new TerraformReference(this, "node_placement");

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_placement")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsDiskPlacement => new TerraformReference(this, "os_disk_placement");

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    [TerraformPropertyName("start_task")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StartTask => new TerraformReference(this, "start_task");

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    [TerraformPropertyName("storage_image_reference")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageImageReference => new TerraformReference(this, "storage_image_reference");

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    [TerraformPropertyName("task_scheduling_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TaskSchedulingPolicy => new TerraformReference(this, "task_scheduling_policy");

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    [TerraformPropertyName("user_accounts")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserAccounts => new TerraformReference(this, "user_accounts");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmSize => new TerraformReference(this, "vm_size");

    /// <summary>
    /// The windows attribute.
    /// </summary>
    [TerraformPropertyName("windows")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Windows => new TerraformReference(this, "windows");

}
