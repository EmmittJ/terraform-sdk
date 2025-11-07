using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_logic_app_integration_account_map resource.
/// </summary>
public class AzurermLogicAppIntegrationAccountMap : TerraformResource
{
    public AzurermLogicAppIntegrationAccountMap(string name) : base("azurerm_logic_app_integration_account_map", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content");
        set => this.WithProperty("content", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IntegrationAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("integration_account_name");
        set => this.WithProperty("integration_account_name", value);
    }

    /// <summary>
    /// The map_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MapType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("map_type");
        set => this.WithProperty("map_type", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
