using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsOutputTable.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputTableTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_stream_analytics_output_table Terraform resource.
/// Manages a azurerm_stream_analytics_output_table resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputTable(string name) : TerraformResource("azurerm_stream_analytics_output_table", name)
{
    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchSize is required")]
    public required TerraformValue<double> BatchSize
    {
        get => new TerraformReference<double>(this, "batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The columns_to_remove attribute.
    /// </summary>
    public TerraformList<string>? ColumnsToRemove
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "columns_to_remove").ResolveNodes(ctx));
        set => SetArgument("columns_to_remove", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformValue<string> PartitionKey
    {
        get => new TerraformReference<string>(this, "partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    public required TerraformValue<string> RowKey
    {
        get => new TerraformReference<string>(this, "row_key");
        set => SetArgument("row_key", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformValue<string> StorageAccountKey
    {
        get => new TerraformReference<string>(this, "storage_account_key");
        set => SetArgument("storage_account_key", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => new TerraformReference<string>(this, "stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsOutputTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsOutputTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
