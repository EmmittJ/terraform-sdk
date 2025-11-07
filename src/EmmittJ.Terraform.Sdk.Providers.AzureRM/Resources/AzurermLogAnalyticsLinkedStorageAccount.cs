using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? DataSourceType
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? StorageAccountIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("storage_account_ids");
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

}
