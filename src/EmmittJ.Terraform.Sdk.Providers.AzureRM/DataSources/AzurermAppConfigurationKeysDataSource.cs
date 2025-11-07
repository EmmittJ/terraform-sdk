using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? ConfigurationStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_store_id");
        set => this.WithProperty("configuration_store_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Label
    {
        get => GetProperty<TerraformLiteralProperty<string>>("label");
        set => this.WithProperty("label", value);
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
