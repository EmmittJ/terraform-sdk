using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBatchPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    [TerraformPropertyName("auto_scale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoScale => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auto_scale");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Certificate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate");

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    [TerraformPropertyName("container_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ContainerConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "container_configuration");

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    [TerraformPropertyName("data_disks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataDisks => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_disks");

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    [TerraformPropertyName("disk_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DiskEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "disk_encryption");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    [TerraformPropertyName("extensions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Extensions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "extensions");

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    [TerraformPropertyName("fixed_scale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FixedScale => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "fixed_scale");

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    [TerraformPropertyName("inter_node_communication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InterNodeCommunication => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "inter_node_communication");

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformPropertyName("license_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_type");

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    [TerraformPropertyName("max_tasks_per_node")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxTasksPerNode => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_tasks_per_node");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The mount attribute.
    /// </summary>
    [TerraformPropertyName("mount")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Mount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "mount");

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    [TerraformPropertyName("network_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_configuration");

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    [TerraformPropertyName("node_agent_sku_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NodeAgentSkuId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "node_agent_sku_id");

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    [TerraformPropertyName("node_placement")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodePlacement => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_placement");

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    [TerraformPropertyName("os_disk_placement")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsDiskPlacement => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_disk_placement");

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    [TerraformPropertyName("start_task")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StartTask => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "start_task");

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    [TerraformPropertyName("storage_image_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageImageReference => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_image_reference");

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    [TerraformPropertyName("task_scheduling_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TaskSchedulingPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "task_scheduling_policy");

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    [TerraformPropertyName("user_accounts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserAccounts => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_accounts");

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    [TerraformPropertyName("vm_size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmSize => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vm_size");

    /// <summary>
    /// The windows attribute.
    /// </summary>
    [TerraformPropertyName("windows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Windows => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "windows");

}
