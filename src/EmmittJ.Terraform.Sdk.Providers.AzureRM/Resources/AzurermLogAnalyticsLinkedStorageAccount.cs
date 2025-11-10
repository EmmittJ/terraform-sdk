using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_linked_storage_account resource.
/// </summary>
public class AzurermLogAnalyticsLinkedStorageAccount : TerraformResource
{
    public AzurermLogAnalyticsLinkedStorageAccount(string name) : base("azurerm_log_analytics_linked_storage_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceType is required")]
    public required TerraformProperty<string> DataSourceType
    {
        get => GetProperty<TerraformProperty<string>>("data_source_type");
        set => this.WithProperty("data_source_type", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountIds is required")]
    public HashSet<TerraformProperty<string>>? StorageAccountIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("storage_account_ids");
        set => this.WithProperty("storage_account_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_resource_id");
        set => this.WithProperty("workspace_resource_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
