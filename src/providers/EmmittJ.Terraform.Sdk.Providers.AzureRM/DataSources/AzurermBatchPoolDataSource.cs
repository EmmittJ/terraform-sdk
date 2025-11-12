using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBatchPoolDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_batch_pool.
/// </summary>
public partial class AzurermBatchPoolDataSource : TerraformDataSource
{
    public AzurermBatchPoolDataSource(string name) : base("azurerm_batch_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermBatchPoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    [TerraformProperty("auto_scale")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AutoScale { get; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Certificate { get; }

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    [TerraformProperty("container_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ContainerConfiguration { get; }

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    [TerraformProperty("data_disks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DataDisks { get; }

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    [TerraformProperty("disk_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DiskEncryption { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    [TerraformProperty("extensions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Extensions { get; }

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    [TerraformProperty("fixed_scale")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FixedScale { get; }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformProperty("inter_node_communication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InterNodeCommunication { get; }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformProperty("license_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseType { get; }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformProperty("max_tasks_per_node")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxTasksPerNode { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The mount attribute.
    /// </summary>
    [TerraformProperty("mount")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Mount { get; }

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    [TerraformProperty("network_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkConfiguration { get; }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [TerraformProperty("node_agent_sku_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NodeAgentSkuId { get; }

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    [TerraformProperty("node_placement")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NodePlacement { get; }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformProperty("os_disk_placement")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsDiskPlacement { get; }

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    [TerraformProperty("start_task")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StartTask { get; }

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    [TerraformProperty("storage_image_reference")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StorageImageReference { get; }

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    [TerraformProperty("task_scheduling_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TaskSchedulingPolicy { get; }

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    [TerraformProperty("user_accounts")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserAccounts { get; }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformProperty("vm_size")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VmSize { get; }

    /// <summary>
    /// The windows attribute.
    /// </summary>
    [TerraformProperty("windows")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Windows { get; }

}
