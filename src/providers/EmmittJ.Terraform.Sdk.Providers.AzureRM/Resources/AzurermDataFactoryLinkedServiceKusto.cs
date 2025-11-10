using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceKustoTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_linked_service_kusto resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceKusto : TerraformResource
{
    public AzurermDataFactoryLinkedServiceKusto(string name) : base("azurerm_data_factory_linked_service_kusto", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("additional_properties");
        SetOutput("annotations");
        SetOutput("data_factory_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("integration_runtime_name");
        SetOutput("kusto_database_name");
        SetOutput("kusto_endpoint");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("service_principal_id");
        SetOutput("service_principal_key");
        SetOutput("tenant");
        SetOutput("use_managed_identity");
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
    /// The kusto_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoDatabaseName is required")]
    public required TerraformProperty<string> KustoDatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_database_name");
        set => SetProperty("kusto_database_name", value);
    }

    /// <summary>
    /// The kusto_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KustoEndpoint is required")]
    public required TerraformProperty<string> KustoEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kusto_endpoint");
        set => SetProperty("kusto_endpoint", value);
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
    /// The service_principal_id attribute.
    /// </summary>
    public TerraformProperty<string> ServicePrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_id");
        set => SetProperty("service_principal_id", value);
    }

    /// <summary>
    /// The service_principal_key attribute.
    /// </summary>
    public TerraformProperty<string> ServicePrincipalKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_key");
        set => SetProperty("service_principal_key", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformProperty<string> Tenant
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant");
        set => SetProperty("tenant", value);
    }

    /// <summary>
    /// The use_managed_identity attribute.
    /// </summary>
    public TerraformProperty<bool> UseManagedIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_managed_identity");
        set => SetProperty("use_managed_identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryLinkedServiceKustoTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
