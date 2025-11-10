using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_eventhub_namespace.
/// </summary>
public class AzurermEventhubNamespaceDataSource : TerraformDataSource
{
    public AzurermEventhubNamespaceDataSource(string name) : base("azurerm_eventhub_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_inflate_enabled");
        SetOutput("capacity");
        SetOutput("dedicated_cluster_id");
        SetOutput("default_primary_connection_string");
        SetOutput("default_primary_connection_string_alias");
        SetOutput("default_primary_key");
        SetOutput("default_secondary_connection_string");
        SetOutput("default_secondary_connection_string_alias");
        SetOutput("default_secondary_key");
        SetOutput("kafka_enabled");
        SetOutput("location");
        SetOutput("maximum_throughput_units");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventhubNamespaceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The auto_inflate_enabled attribute.
    /// </summary>
    public TerraformExpression AutoInflateEnabled => this["auto_inflate_enabled"];

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformExpression Capacity => this["capacity"];

    /// <summary>
    /// The dedicated_cluster_id attribute.
    /// </summary>
    public TerraformExpression DedicatedClusterId => this["dedicated_cluster_id"];

    /// <summary>
    /// The default_primary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionString => this["default_primary_connection_string"];

    /// <summary>
    /// The default_primary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryConnectionStringAlias => this["default_primary_connection_string_alias"];

    /// <summary>
    /// The default_primary_key attribute.
    /// </summary>
    public TerraformExpression DefaultPrimaryKey => this["default_primary_key"];

    /// <summary>
    /// The default_secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionString => this["default_secondary_connection_string"];

    /// <summary>
    /// The default_secondary_connection_string_alias attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryConnectionStringAlias => this["default_secondary_connection_string_alias"];

    /// <summary>
    /// The default_secondary_key attribute.
    /// </summary>
    public TerraformExpression DefaultSecondaryKey => this["default_secondary_key"];

    /// <summary>
    /// The kafka_enabled attribute.
    /// </summary>
    public TerraformExpression KafkaEnabled => this["kafka_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maximum_throughput_units attribute.
    /// </summary>
    public TerraformExpression MaximumThroughputUnits => this["maximum_throughput_units"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
