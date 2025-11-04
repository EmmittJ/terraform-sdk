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
    public string? ConfigurationStoreId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_store_id")?.Value;
        set => this.WithProperty("configuration_store_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key attribute.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public string? Label
    {
        get => GetProperty<TerraformLiteralProperty<string>>("label")?.Value;
        set => this.WithProperty("label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}
