using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_data_share_dataset_data_lake_gen2.
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2DataSource : TerraformDataSource
{
    public AzurermDataShareDatasetDataLakeGen2DataSource(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("display_name");
        SetOutput("file_path");
        SetOutput("file_system_name");
        SetOutput("folder_path");
        SetOutput("storage_account_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("share_id");
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
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    public required TerraformProperty<string> ShareId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("share_id");
        set => SetProperty("share_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformExpression FilePath => this["file_path"];

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    public TerraformExpression FileSystemName => this["file_system_name"];

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformExpression FolderPath => this["folder_path"];

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformExpression StorageAccountId => this["storage_account_id"];

}
