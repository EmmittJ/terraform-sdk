using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_monitor_workspace.
/// </summary>
public class AzurermMonitorWorkspaceDataSource : TerraformDataSource
{
    public AzurermMonitorWorkspaceDataSource(string name) : base("azurerm_monitor_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("default_data_collection_endpoint_id");
        this.DeclareOutput("default_data_collection_rule_id");
        this.DeclareOutput("location");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("query_endpoint");
        this.DeclareOutput("tags");
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
    /// The default_data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformExpression DefaultDataCollectionEndpointId => this["default_data_collection_endpoint_id"];

    /// <summary>
    /// The default_data_collection_rule_id attribute.
    /// </summary>
    public TerraformExpression DefaultDataCollectionRuleId => this["default_data_collection_rule_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The query_endpoint attribute.
    /// </summary>
    public TerraformExpression QueryEndpoint => this["query_endpoint"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
