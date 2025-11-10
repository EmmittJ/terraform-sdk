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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("auto_scale");
        this.DeclareOutput("certificate");
        this.DeclareOutput("container_configuration");
        this.DeclareOutput("data_disks");
        this.DeclareOutput("disk_encryption");
        this.DeclareOutput("display_name");
        this.DeclareOutput("extensions");
        this.DeclareOutput("fixed_scale");
        this.DeclareOutput("inter_node_communication");
        this.DeclareOutput("license_type");
        this.DeclareOutput("max_tasks_per_node");
        this.DeclareOutput("metadata");
        this.DeclareOutput("mount");
        this.DeclareOutput("network_configuration");
        this.DeclareOutput("node_agent_sku_id");
        this.DeclareOutput("node_placement");
        this.DeclareOutput("os_disk_placement");
        this.DeclareOutput("start_task");
        this.DeclareOutput("storage_image_reference");
        this.DeclareOutput("task_scheduling_policy");
        this.DeclareOutput("user_accounts");
        this.DeclareOutput("vm_size");
        this.DeclareOutput("windows");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchPoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBatchPoolDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
