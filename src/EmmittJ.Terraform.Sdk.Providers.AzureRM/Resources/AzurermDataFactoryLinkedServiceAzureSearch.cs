using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_linked_service_azure_search resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceAzureSearch : TerraformResource
{
    public AzurermDataFactoryLinkedServiceAzureSearch(string name) : base("azurerm_data_factory_linked_service_azure_search", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("encrypted_credential");
    }

    /// <summary>
    /// The additional_properties attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? AdditionalProperties
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("additional_properties");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Parameters
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("parameters");
        set => this.WithProperty("parameters", value);
    }

    /// <summary>
    /// The search_service_key attribute.
    /// </summary>
    public TerraformProperty<string>? SearchServiceKey
    {
        get => GetProperty<TerraformProperty<string>>("search_service_key");
        set => this.WithProperty("search_service_key", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => this.WithProperty("url", value);
    }

    /// <summary>
    /// The encrypted_credential attribute.
    /// </summary>
    public TerraformExpression EncryptedCredential => this["encrypted_credential"];

}
