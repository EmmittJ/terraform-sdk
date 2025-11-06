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
    public string? AutoDeleteOnIdle
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_delete_on_idle")?.Value;
        set => this.WithProperty("auto_delete_on_idle", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public bool? BatchedOperationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("batched_operations_enabled")?.Value;
        set => this.WithProperty("batched_operations_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public string? DefaultMessageTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_message_ttl")?.Value;
        set => this.WithProperty("default_message_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public string? DuplicateDetectionHistoryTimeWindow
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duplicate_detection_history_time_window")?.Value;
        set => this.WithProperty("duplicate_detection_history_time_window", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public bool? ExpressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_enabled")?.Value;
        set => this.WithProperty("express_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The max_message_size_in_kilobytes attribute.
    /// </summary>
    public double? MaxMessageSizeInKilobytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_message_size_in_kilobytes")?.Value;
        set => this.WithProperty("max_message_size_in_kilobytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public double? MaxSizeInMegabytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size_in_megabytes")?.Value;
        set => this.WithProperty("max_size_in_megabytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The namespace_id attribute.
    /// </summary>
    public string? NamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_id")?.Value;
        set => this.WithProperty("namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public bool? PartitioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("partitioning_enabled")?.Value;
        set => this.WithProperty("partitioning_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public bool? RequiresDuplicateDetection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("requires_duplicate_detection")?.Value;
        set => this.WithProperty("requires_duplicate_detection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    public bool? SupportOrdering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("support_ordering")?.Value;
        set => this.WithProperty("support_ordering", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
