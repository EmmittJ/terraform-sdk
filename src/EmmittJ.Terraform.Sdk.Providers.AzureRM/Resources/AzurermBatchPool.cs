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
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InterNodeCommunication
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inter_node_communication");
        set => this.WithProperty("inter_node_communication", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxTasksPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_tasks_per_node");
        set => this.WithProperty("max_tasks_per_node", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NodeAgentSkuId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_agent_sku_id");
        set => this.WithProperty("node_agent_sku_id", value);
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OsDiskPlacement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_disk_placement");
        set => this.WithProperty("os_disk_placement", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StopPendingResizeOperation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stop_pending_resize_operation");
        set => this.WithProperty("stop_pending_resize_operation", value);
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNodeCommunicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_node_communication_mode");
        set => this.WithProperty("target_node_communication_mode", value);
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size");
        set => this.WithProperty("vm_size", value);
    }

}
