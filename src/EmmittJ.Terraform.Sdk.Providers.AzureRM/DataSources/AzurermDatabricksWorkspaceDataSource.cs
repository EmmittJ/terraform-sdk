using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace.
/// </summary>
public class AzurermDatabricksWorkspaceDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspaceDataSource(string name) : base("azurerm_databricks_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_parameters");
        this.DeclareOutput("enhanced_security_compliance");
        this.DeclareOutput("location");
        this.DeclareOutput("managed_disk_identity");
        this.DeclareOutput("sku");
        this.DeclareOutput("storage_account_identity");
        this.DeclareOutput("workspace_id");
        this.DeclareOutput("workspace_url");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    public TerraformExpression CustomParameters => this["custom_parameters"];

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    public TerraformExpression EnhancedSecurityCompliance => this["enhanced_security_compliance"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    public TerraformExpression ManagedDiskIdentity => this["managed_disk_identity"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    public TerraformExpression StorageAccountIdentity => this["storage_account_identity"];

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformExpression WorkspaceId => this["workspace_id"];

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    public TerraformExpression WorkspaceUrl => this["workspace_url"];

}
