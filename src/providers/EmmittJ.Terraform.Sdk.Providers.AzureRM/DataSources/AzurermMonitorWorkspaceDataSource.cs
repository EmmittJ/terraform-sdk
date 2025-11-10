using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorWorkspaceDataSourceTimeoutsBlock : TerraformBlock
{
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
        this.WithOutput("default_data_collection_endpoint_id");
        this.WithOutput("default_data_collection_rule_id");
        this.WithOutput("location");
        this.WithOutput("public_network_access_enabled");
        this.WithOutput("query_endpoint");
        this.WithOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorWorkspaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorWorkspaceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
