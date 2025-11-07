using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_eventhub_data_connection resource.
/// </summary>
public class AzurermKustoEventhubDataConnection : TerraformResource
{
    public AzurermKustoEventhubDataConnection(string name) : base("azurerm_kusto_eventhub_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Compression
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConsumerGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_group");
        set => this.WithProperty("consumer_group", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseRoutingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_routing_type");
        set => this.WithProperty("database_routing_type", value);
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? EventSystemProperties
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("event_system_properties");
        set => this.WithProperty("event_system_properties", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventhubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_id");
        set => this.WithProperty("eventhub_id", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MappingRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mapping_rule_name");
        set => this.WithProperty("mapping_rule_name", value);
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
    /// The table_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
