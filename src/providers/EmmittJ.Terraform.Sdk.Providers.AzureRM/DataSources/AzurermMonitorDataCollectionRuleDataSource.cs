using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_monitor_data_collection_rule.
/// </summary>
public class AzurermMonitorDataCollectionRuleDataSource : TerraformDataSource
{
    public AzurermMonitorDataCollectionRuleDataSource(string name) : base("azurerm_monitor_data_collection_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("data_collection_endpoint_id");
        this.WithOutput("data_flow");
        this.WithOutput("data_sources");
        this.WithOutput("description");
        this.WithOutput("destinations");
        this.WithOutput("identity");
        this.WithOutput("immutable_id");
        this.WithOutput("kind");
        this.WithOutput("location");
        this.WithOutput("stream_declaration");
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
    public AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorDataCollectionRuleDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformExpression DataCollectionEndpointId => this["data_collection_endpoint_id"];

    /// <summary>
    /// The data_flow attribute.
    /// </summary>
    public TerraformExpression DataFlow => this["data_flow"];

    /// <summary>
    /// The data_sources attribute.
    /// </summary>
    public TerraformExpression DataSources => this["data_sources"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformExpression Destinations => this["destinations"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The immutable_id attribute.
    /// </summary>
    public TerraformExpression ImmutableId => this["immutable_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The stream_declaration attribute.
    /// </summary>
    public TerraformExpression StreamDeclaration => this["stream_declaration"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
