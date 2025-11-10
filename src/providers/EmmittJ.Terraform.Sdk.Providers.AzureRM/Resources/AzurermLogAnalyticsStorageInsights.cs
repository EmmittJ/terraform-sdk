using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsStorageInsightsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_log_analytics_storage_insights resource.
/// </summary>
public class AzurermLogAnalyticsStorageInsights : TerraformResource
{
    public AzurermLogAnalyticsStorageInsights(string name) : base("azurerm_log_analytics_storage_insights", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("blob_container_names");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("storage_account_id");
        SetOutput("storage_account_key");
        SetOutput("table_names");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The blob_container_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> BlobContainerNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("blob_container_names");
        set => SetProperty("blob_container_names", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountKey is required")]
    public required TerraformProperty<string> StorageAccountKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_key");
        set => SetProperty("storage_account_key", value);
    }

    /// <summary>
    /// The table_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> TableNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("table_names");
        set => SetProperty("table_names", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermLogAnalyticsStorageInsightsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
