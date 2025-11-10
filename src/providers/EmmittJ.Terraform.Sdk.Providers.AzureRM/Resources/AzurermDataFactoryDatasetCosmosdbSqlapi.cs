using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for schema_column in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryDatasetCosmosdbSqlapiSchemaColumnBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryDatasetCosmosdbSqlapiTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_dataset_cosmosdb_sqlapi resource.
/// </summary>
public class AzurermDataFactoryDatasetCosmosdbSqlapi : TerraformResource
{
    public AzurermDataFactoryDatasetCosmosdbSqlapi(string name) : base("azurerm_data_factory_dataset_cosmosdb_sqlapi", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("collection_name");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("folder");
        SetOutput("id");
        SetOutput("linked_service_name");
        SetOutput("name");
        SetOutput("parameters");
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
    /// The collection_name attribute.
    /// </summary>
    public TerraformProperty<string> CollectionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("collection_name");
        set => SetProperty("collection_name", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string> Folder
    {
        get => GetRequiredOutput<TerraformProperty<string>>("folder");
        set => SetProperty("folder", value);
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
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    public required TerraformProperty<string> LinkedServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linked_service_name");
        set => SetProperty("linked_service_name", value);
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
    /// Block for schema_column.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermDataFactoryDatasetCosmosdbSqlapiSchemaColumnBlock>? SchemaColumn
    {
        set => SetProperty("schema_column", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryDatasetCosmosdbSqlapiTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
