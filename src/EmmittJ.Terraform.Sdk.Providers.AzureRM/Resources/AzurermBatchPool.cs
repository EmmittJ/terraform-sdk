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
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inter_node_communication attribute.
    /// </summary>
    public string? InterNodeCommunication
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inter_node_communication")?.Value;
        set => this.WithProperty("inter_node_communication", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public string? LicenseType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_type")?.Value;
        set => this.WithProperty("license_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_tasks_per_node attribute.
    /// </summary>
    public double? MaxTasksPerNode
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_tasks_per_node")?.Value;
        set => this.WithProperty("max_tasks_per_node", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The node_agent_sku_id attribute.
    /// </summary>
    public string? NodeAgentSkuId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("node_agent_sku_id")?.Value;
        set => this.WithProperty("node_agent_sku_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The os_disk_placement attribute.
    /// </summary>
    public string? OsDiskPlacement
    {
        get => GetProperty<TerraformLiteralProperty<string>>("os_disk_placement")?.Value;
        set => this.WithProperty("os_disk_placement", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stop_pending_resize_operation attribute.
    /// </summary>
    public bool? StopPendingResizeOperation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stop_pending_resize_operation")?.Value;
        set => this.WithProperty("stop_pending_resize_operation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The target_node_communication_mode attribute.
    /// </summary>
    public string? TargetNodeCommunicationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_node_communication_mode")?.Value;
        set => this.WithProperty("target_node_communication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vm_size attribute.
    /// </summary>
    public string? VmSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vm_size")?.Value;
        set => this.WithProperty("vm_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
