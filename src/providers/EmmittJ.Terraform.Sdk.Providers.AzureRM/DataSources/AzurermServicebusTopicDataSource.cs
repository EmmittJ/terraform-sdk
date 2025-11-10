using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusTopicDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("auto_delete_on_idle");
        SetOutput("batched_operations_enabled");
        SetOutput("default_message_ttl");
        SetOutput("duplicate_detection_history_time_window");
        SetOutput("enable_batched_operations");
        SetOutput("enable_express");
        SetOutput("enable_partitioning");
        SetOutput("express_enabled");
        SetOutput("max_size_in_megabytes");
        SetOutput("partitioning_enabled");
        SetOutput("requires_duplicate_detection");
        SetOutput("status");
        SetOutput("support_ordering");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_id");
        SetOutput("namespace_name");
        SetOutput("resource_group_name");
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
    /// The namespace_id attribute.
    /// </summary>
    public TerraformProperty<string> NamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_id");
        set => SetProperty("namespace_id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermServicebusTopicDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
