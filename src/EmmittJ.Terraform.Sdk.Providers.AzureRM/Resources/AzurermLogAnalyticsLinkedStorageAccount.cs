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
    public string? DataSourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_type")?.Value;
        set => this.WithProperty("data_source_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_account_ids attribute.
    /// </summary>
    public HashSet<string>? StorageAccountIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("storage_account_ids")?.Value;
        set => this.WithProperty("storage_account_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public string? WorkspaceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_resource_id")?.Value;
        set => this.WithProperty("workspace_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
