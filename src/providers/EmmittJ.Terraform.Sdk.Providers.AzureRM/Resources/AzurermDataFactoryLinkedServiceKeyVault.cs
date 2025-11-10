using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryLinkedServiceKeyVaultTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_data_factory_linked_service_key_vault resource.
/// </summary>
public class AzurermDataFactoryLinkedServiceKeyVault : TerraformResource
{
    public AzurermDataFactoryLinkedServiceKeyVault(string name) : base("azurerm_data_factory_linked_service_key_vault", name)
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
        SetOutput("key_vault_id");
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
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
    public AzurermDataFactoryLinkedServiceKeyVaultTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
