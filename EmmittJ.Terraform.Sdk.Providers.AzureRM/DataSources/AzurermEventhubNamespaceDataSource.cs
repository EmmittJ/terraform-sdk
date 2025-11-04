using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("auto_inflate_enabled");
        this.DeclareOutput("capacity");
        this.DeclareOutput("dedicated_cluster_id");
        this.DeclareOutput("default_primary_connection_string");
        this.DeclareOutput("default_primary_connection_string_alias");
        this.DeclareOutput("default_primary_key");
        this.DeclareOutput("default_secondary_connection_string");
        this.DeclareOutput("default_secondary_connection_string_alias");
        this.DeclareOutput("default_secondary_key");
        this.DeclareOutput("kafka_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("maximum_throughput_units");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
