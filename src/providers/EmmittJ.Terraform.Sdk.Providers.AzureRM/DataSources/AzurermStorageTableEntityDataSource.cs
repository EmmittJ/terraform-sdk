using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableEntityDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_storage_table_entity.
/// </summary>
public class AzurermStorageTableEntityDataSource : TerraformDataSource
{
    public AzurermStorageTableEntityDataSource(string name) : base("azurerm_storage_table_entity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("entity");
        SetOutput("id");
        SetOutput("partition_key");
        SetOutput("row_key");
        SetOutput("storage_table_id");
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
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformProperty<string> PartitionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key");
        set => SetProperty("partition_key", value);
    }

    /// <summary>
    /// The row_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RowKey is required")]
    public required TerraformProperty<string> RowKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("row_key");
        set => SetProperty("row_key", value);
    }

    /// <summary>
    /// The storage_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageTableId is required")]
    public required TerraformProperty<string> StorageTableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_table_id");
        set => SetProperty("storage_table_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageTableEntityDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The entity attribute.
    /// </summary>
    public TerraformExpression Entity => this["entity"];

}
