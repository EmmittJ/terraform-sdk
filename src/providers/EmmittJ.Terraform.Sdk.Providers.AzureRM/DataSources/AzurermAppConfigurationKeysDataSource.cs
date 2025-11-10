using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppConfigurationKeysDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_app_configuration_keys.
/// </summary>
public class AzurermAppConfigurationKeysDataSource : TerraformDataSource
{
    public AzurermAppConfigurationKeysDataSource(string name) : base("azurerm_app_configuration_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("items");
        SetOutput("configuration_store_id");
        SetOutput("id");
        SetOutput("key");
        SetOutput("label");
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformProperty<string> ConfigurationStoreId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_store_id");
        set => SetProperty("configuration_store_id", value);
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
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string> Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key");
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string> Label
    {
        get => GetRequiredOutput<TerraformProperty<string>>("label");
        set => SetProperty("label", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationKeysDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
