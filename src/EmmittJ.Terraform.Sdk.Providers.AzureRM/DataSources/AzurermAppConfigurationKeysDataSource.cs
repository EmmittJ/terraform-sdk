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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("items");
    }

    /// <summary>
    /// The configuration_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationStoreId is required")]
    public required TerraformProperty<string> ConfigurationStoreId
    {
        get => GetProperty<TerraformProperty<string>>("configuration_store_id");
        set => this.WithProperty("configuration_store_id", value);
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
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppConfigurationKeysDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppConfigurationKeysDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
