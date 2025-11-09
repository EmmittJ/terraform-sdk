using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_batch_pool resource.
/// </summary>
public class AzurermBatchPool : TerraformResource
{
    public AzurermBatchPool(string name) : base("azurerm_batch_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformProperty<string>? InterNodeCommunication
    {
        get => GetProperty<TerraformProperty<string>>("inter_node_communication");
        set => this.WithProperty("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformProperty<double>? MaxTasksPerNode
    {
        get => GetProperty<TerraformProperty<double>>("max_tasks_per_node");
        set => this.WithProperty("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformProperty<string>? NodeAgentSkuId
    {
        get => GetProperty<TerraformProperty<string>>("node_agent_sku_id");
        set => this.WithProperty("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformProperty<string>? OsDiskPlacement
    {
        get => GetProperty<TerraformProperty<string>>("os_disk_placement");
        set => this.WithProperty("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformProperty<bool>? StopPendingResizeOperation
    {
        get => GetProperty<TerraformProperty<bool>>("stop_pending_resize_operation");
        set => this.WithProperty("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNodeCommunicationMode
    {
        get => GetProperty<TerraformProperty<string>>("target_node_communication_mode");
        set => this.WithProperty("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformProperty<string>? VmSize
    {
        get => GetProperty<TerraformProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

}
