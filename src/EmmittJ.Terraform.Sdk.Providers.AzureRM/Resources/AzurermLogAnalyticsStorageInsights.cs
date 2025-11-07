using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The blob_container_names attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? BlobContainerNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("blob_container_names");
        set => this.WithProperty("blob_container_names", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_key");
        set => this.WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The table_names attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? TableNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("table_names");
        set => this.WithProperty("table_names", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

}
