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
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    public string? ConsumerGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_group")?.Value;
        set => this.WithProperty("consumer_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    public string? DataFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_format")?.Value;
        set => this.WithProperty("data_format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public string? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name")?.Value;
        set => this.WithProperty("database_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database_routing_type attribute.
    /// </summary>
    public string? DatabaseRoutingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_routing_type")?.Value;
        set => this.WithProperty("database_routing_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_system_properties attribute.
    /// </summary>
    public HashSet<string>? EventSystemProperties
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("event_system_properties")?.Value;
        set => this.WithProperty("event_system_properties", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The iothub_id attribute.
    /// </summary>
    public string? IothubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_id")?.Value;
        set => this.WithProperty("iothub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public string? MappingRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mapping_rule_name")?.Value;
        set => this.WithProperty("mapping_rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The shared_access_policy_name attribute.
    /// </summary>
    public string? SharedAccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_policy_name")?.Value;
        set => this.WithProperty("shared_access_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
