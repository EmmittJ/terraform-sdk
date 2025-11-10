using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchPoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_batch_pool.
/// </summary>
public class AzurermBatchPoolDataSource : TerraformDataSource
{
    public AzurermBatchPoolDataSource(string name) : base("azurerm_batch_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_scale");
        SetOutput("certificate");
        SetOutput("container_configuration");
        SetOutput("data_disks");
        SetOutput("disk_encryption");
        SetOutput("display_name");
        SetOutput("extensions");
        SetOutput("fixed_scale");
        SetOutput("inter_node_communication");
        SetOutput("license_type");
        SetOutput("max_tasks_per_node");
        SetOutput("metadata");
        SetOutput("mount");
        SetOutput("network_configuration");
        SetOutput("node_agent_sku_id");
        SetOutput("node_placement");
        SetOutput("os_disk_placement");
        SetOutput("start_task");
        SetOutput("storage_image_reference");
        SetOutput("task_scheduling_policy");
        SetOutput("user_accounts");
        SetOutput("vm_size");
        SetOutput("windows");
        SetOutput("account_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_name");
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchPoolDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The auto_scale attribute.
    /// </summary>
    public TerraformExpression AutoScale => this["auto_scale"];

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The container_configuration attribute.
    /// </summary>
    public TerraformExpression ContainerConfiguration => this["container_configuration"];

    /// <summary>
    /// The data_disks attribute.
    /// </summary>
    public TerraformExpression DataDisks => this["data_disks"];

    /// <summary>
    /// The disk_encryption attribute.
    /// </summary>
    public TerraformExpression DiskEncryption => this["disk_encryption"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The extensions attribute.
    /// </summary>
    public TerraformExpression Extensions => this["extensions"];

    /// <summary>
    /// The fixed_scale attribute.
    /// </summary>
    public TerraformExpression FixedScale => this["fixed_scale"];

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformExpression InterNodeCommunication => this["inter_node_communication"];

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformExpression LicenseType => this["license_type"];

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformExpression MaxTasksPerNode => this["max_tasks_per_node"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The mount attribute.
    /// </summary>
    public TerraformExpression Mount => this["mount"];

    /// <summary>
    /// The network_configuration attribute.
    /// </summary>
    public TerraformExpression NetworkConfiguration => this["network_configuration"];

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformExpression NodeAgentSkuId => this["node_agent_sku_id"];

    /// <summary>
    /// The node_placement attribute.
    /// </summary>
    public TerraformExpression NodePlacement => this["node_placement"];

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformExpression OsDiskPlacement => this["os_disk_placement"];

    /// <summary>
    /// The start_task attribute.
    /// </summary>
    public TerraformExpression StartTask => this["start_task"];

    /// <summary>
    /// The storage_image_reference attribute.
    /// </summary>
    public TerraformExpression StorageImageReference => this["storage_image_reference"];

    /// <summary>
    /// The task_scheduling_policy attribute.
    /// </summary>
    public TerraformExpression TaskSchedulingPolicy => this["task_scheduling_policy"];

    /// <summary>
    /// The user_accounts attribute.
    /// </summary>
    public TerraformExpression UserAccounts => this["user_accounts"];

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformExpression VmSize => this["vm_size"];

    /// <summary>
    /// The windows attribute.
    /// </summary>
    public TerraformExpression Windows => this["windows"];

}
