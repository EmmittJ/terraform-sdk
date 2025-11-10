using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceCosmosdbTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_linked_service_cosmosdb resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceCosmosdb : TerraformResource
{
    public AzurermDataFactoryLinkedServiceCosmosdb(string name) : base("azurerm_data_factory_linked_service_cosmosdb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? AccountEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("account_endpoint");
        set => this.WithProperty("account_endpoint", value);
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccountKey
    {
        get => GetProperty<TerraformProperty<string>>("account_key");
        set => this.WithProperty("account_key", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Annotations
    {
        get => GetProperty<List<TerraformProperty<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string>? IntegrationRuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("integration_runtime_name");
        set => this.WithProperty("integration_runtime_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceCosmosdbTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryLinkedServiceCosmosdbTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
