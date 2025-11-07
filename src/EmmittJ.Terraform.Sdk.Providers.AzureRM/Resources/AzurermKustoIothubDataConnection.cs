using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_iothub_data_connection resource.
/// </summary>
public class AzurermKustoIothubDataConnection : TerraformResource
{
    public AzurermKustoIothubDataConnection(string name) : base("azurerm_kusto_iothub_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    public TerraformProperty<string>? ConsumerGroup
    {
        get => GetProperty<TerraformProperty<string>>("consumer_group");
        set => this.WithProperty("consumer_group", value);
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public TerraformProperty<string>? DataFormat
    {
        get => GetProperty<TerraformProperty<string>>("data_format");
        set => this.WithProperty("data_format", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseRoutingType
    {
        get => GetProperty<TerraformProperty<string>>("database_routing_type");
        set => this.WithProperty("database_routing_type", value);
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EventSystemProperties
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("event_system_properties");
        set => this.WithProperty("event_system_properties", value);
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
    /// The iothub_id attribute.
    /// </summary>
    public TerraformProperty<string>? IothubId
    {
        get => GetProperty<TerraformProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformProperty<string>? MappingRuleName
    {
        get => GetProperty<TerraformProperty<string>>("mapping_rule_name");
        set => this.WithProperty("mapping_rule_name", value);
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
    /// The shared_access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SharedAccessPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("shared_access_policy_name");
        set => this.WithProperty("shared_access_policy_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string>? TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
