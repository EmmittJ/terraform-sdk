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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("account_endpoint");
        SetOutput("account_key");
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("connection_string");
        SetOutput("data_factory_id");
        SetOutput("database");
        SetOutput("description");
        SetOutput("id");
        SetOutput("integration_runtime_name");
        SetOutput("name");
        SetOutput("parameters");
    }

    /// <summary>
    /// The account_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> AccountEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_endpoint");
        set => SetProperty("account_endpoint", value);
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformProperty<string> AccountKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_key");
        set => SetProperty("account_key", value);
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_properties");
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformProperty<string> DataFactoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_factory_id");
        set => SetProperty("data_factory_id", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformProperty<string> Database
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database");
        set => SetProperty("database", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The integration_runtime_name attribute.
    /// </summary>
    public TerraformProperty<string> IntegrationRuntimeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("integration_runtime_name");
        set => SetProperty("integration_runtime_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceCosmosdbTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
