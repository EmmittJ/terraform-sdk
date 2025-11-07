using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_topic resource.
/// </summary>
public class AzurermServicebusTopic : TerraformResource
{
    public AzurermServicebusTopic(string name) : base("azurerm_servicebus_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformProperty<string>? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformProperty<string>>("auto_delete_on_idle");
        set => this.WithProperty("auto_delete_on_idle", value);
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("batched_operations_enabled");
        set => this.WithProperty("batched_operations_enabled", value);
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultMessageTtl
    {
        get => GetProperty<TerraformProperty<string>>("default_message_ttl");
        set => this.WithProperty("default_message_ttl", value);
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformProperty<string>? DuplicateDetectionHistoryTimeWindow
    {
        get => GetProperty<TerraformProperty<string>>("duplicate_detection_history_time_window");
        set => this.WithProperty("duplicate_detection_history_time_window", value);
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExpressEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("express_enabled");
        set => this.WithProperty("express_enabled", value);
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
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxMessageSizeInKilobytes
    {
        get => GetProperty<TerraformProperty<double>>("max_message_size_in_kilobytes");
        set => this.WithProperty("max_message_size_in_kilobytes", value);
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxSizeInMegabytes
    {
        get => GetProperty<TerraformProperty<double>>("max_size_in_megabytes");
        set => this.WithProperty("max_size_in_megabytes", value);
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
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("namespace_id");
        set => this.WithProperty("namespace_id", value);
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PartitioningEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("partitioning_enabled");
        set => this.WithProperty("partitioning_enabled", value);
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformProperty<bool>? RequiresDuplicateDetection
    {
        get => GetProperty<TerraformProperty<bool>>("requires_duplicate_detection");
        set => this.WithProperty("requires_duplicate_detection", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    public TerraformProperty<bool>? SupportOrdering
    {
        get => GetProperty<TerraformProperty<bool>>("support_ordering");
        set => this.WithProperty("support_ordering", value);
    }

}
