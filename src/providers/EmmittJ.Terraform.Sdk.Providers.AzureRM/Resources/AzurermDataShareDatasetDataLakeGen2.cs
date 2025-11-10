using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_data_share_dataset_data_lake_gen2 resource.
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2 : TerraformResource
{
    public AzurermDataShareDatasetDataLakeGen2(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("display_name");
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformProperty<string>? FilePath
    {
        get => GetProperty<TerraformProperty<string>>("file_path");
        set => this.WithProperty("file_path", value);
    }

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemName is required")]
    public required TerraformProperty<string> FileSystemName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("file_system_name");
        set => this.WithProperty("file_system_name", value);
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformProperty<string>? FolderPath
    {
        get => GetProperty<TerraformProperty<string>>("folder_path");
        set => this.WithProperty("folder_path", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    public required TerraformProperty<string> ShareId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("share_id");
        set => this.WithProperty("share_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataShareDatasetDataLakeGen2TimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataShareDatasetDataLakeGen2TimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

}
