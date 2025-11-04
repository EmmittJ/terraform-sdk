using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_dataset_http resource.
/// </summary>
public class AzurermDataFactoryDatasetHttp : TerraformResource
{
    public AzurermDataFactoryDatasetHttp(string name) : base("azurerm_data_factory_dataset_http", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_properties")?.Value;
        set => this.WithProperty("additional_properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    public List<string>? Annotations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("annotations")?.Value;
        set => this.WithProperty("annotations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public string? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id")?.Value;
        set => this.WithProperty("data_factory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    public string? Folder
    {
        get => GetProperty<TerraformLiteralProperty<string>>("folder")?.Value;
        set => this.WithProperty("folder", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The linked_service_name attribute.
    /// </summary>
    public string? LinkedServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_service_name")?.Value;
        set => this.WithProperty("linked_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, string>? Parameters
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("parameters")?.Value;
        set => this.WithProperty("parameters", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The relative_url attribute.
    /// </summary>
    public string? RelativeUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relative_url")?.Value;
        set => this.WithProperty("relative_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_body attribute.
    /// </summary>
    public string? RequestBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_body")?.Value;
        set => this.WithProperty("request_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The request_method attribute.
    /// </summary>
    public string? RequestMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_method")?.Value;
        set => this.WithProperty("request_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
