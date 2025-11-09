using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_dataset_snowflake resource.
/// </summary>
public class AzurermDataFactoryDatasetSnowflake : TerraformResource
{
    public AzurermDataFactoryDatasetSnowflake(string name) : base("azurerm_data_factory_dataset_snowflake", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformMapProperty<string>? AdditionalProperties
    {
        get => GetProperty<TerraformMapProperty<string>>("additional_properties");
        set => this.WithProperty("additional_properties", value);
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Annotations
    {
        get => GetProperty<TerraformProperty<List<string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
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
    /// The folder attribute.
    /// </summary>
    public TerraformProperty<string>? Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// The linked_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? LinkedServiceName
    {
        get => GetProperty<TerraformProperty<string>>("linked_service_name");
        set => this.WithProperty("linked_service_name", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMapProperty<string>? Parameters
    {
        get => GetProperty<TerraformMapProperty<string>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformProperty<string>? SchemaName
    {
        get => GetProperty<TerraformProperty<string>>("schema_name");
        set => this.WithProperty("schema_name", value);
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
