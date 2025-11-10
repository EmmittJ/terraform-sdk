using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKustoEventhubDataConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformProperty<string>? Compression
    {
        get => GetProperty<TerraformProperty<string>>("compression");
        set => this.WithProperty("compression", value);
    }

    /// <summary>
    /// The consumer_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerGroup is required")]
    public required TerraformProperty<string> ConsumerGroup
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
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
    public List<TerraformProperty<string>>? EventSystemProperties
    {
        get => GetProperty<List<TerraformProperty<string>>>("event_system_properties");
        set => this.WithProperty("event_system_properties", value);
    }

    /// <summary>
    /// The eventhub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubId is required")]
    public required TerraformProperty<string> EventhubId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_id");
        set => this.WithProperty("eventhub_id", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        get => GetProperty<TerraformProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformProperty<string>? TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKustoEventhubDataConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKustoEventhubDataConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
