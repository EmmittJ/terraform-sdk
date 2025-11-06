using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_servicebus_topic.
/// </summary>
public class AzurermServicebusTopicDataSource : TerraformDataSource
{
    public AzurermServicebusTopicDataSource(string name) : base("azurerm_servicebus_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("auto_delete_on_idle");
        this.DeclareOutput("batched_operations_enabled");
        this.DeclareOutput("default_message_ttl");
        this.DeclareOutput("duplicate_detection_history_time_window");
        this.DeclareOutput("enable_batched_operations");
        this.DeclareOutput("enable_express");
        this.DeclareOutput("enable_partitioning");
        this.DeclareOutput("express_enabled");
        this.DeclareOutput("max_size_in_megabytes");
        this.DeclareOutput("partitioning_enabled");
        this.DeclareOutput("requires_duplicate_detection");
        this.DeclareOutput("status");
        this.DeclareOutput("support_ordering");
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
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_delete_on_idle attribute.
    /// </summary>
    public TerraformExpression AutoDeleteOnIdle => this["auto_delete_on_idle"];

    /// <summary>
    /// The batched_operations_enabled attribute.
    /// </summary>
    public TerraformExpression BatchedOperationsEnabled => this["batched_operations_enabled"];

    /// <summary>
    /// The default_message_ttl attribute.
    /// </summary>
    public TerraformExpression DefaultMessageTtl => this["default_message_ttl"];

    /// <summary>
    /// The duplicate_detection_history_time_window attribute.
    /// </summary>
    public TerraformExpression DuplicateDetectionHistoryTimeWindow => this["duplicate_detection_history_time_window"];

    /// <summary>
    /// The enable_batched_operations attribute.
    /// </summary>
    public TerraformExpression EnableBatchedOperations => this["enable_batched_operations"];

    /// <summary>
    /// The enable_express attribute.
    /// </summary>
    public TerraformExpression EnableExpress => this["enable_express"];

    /// <summary>
    /// The enable_partitioning attribute.
    /// </summary>
    public TerraformExpression EnablePartitioning => this["enable_partitioning"];

    /// <summary>
    /// The express_enabled attribute.
    /// </summary>
    public TerraformExpression ExpressEnabled => this["express_enabled"];

    /// <summary>
    /// The max_size_in_megabytes attribute.
    /// </summary>
    public TerraformExpression MaxSizeInMegabytes => this["max_size_in_megabytes"];

    /// <summary>
    /// The partitioning_enabled attribute.
    /// </summary>
    public TerraformExpression PartitioningEnabled => this["partitioning_enabled"];

    /// <summary>
    /// The requires_duplicate_detection attribute.
    /// </summary>
    public TerraformExpression RequiresDuplicateDetection => this["requires_duplicate_detection"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The support_ordering attribute.
    /// </summary>
    public TerraformExpression SupportOrdering => this["support_ordering"];

}
