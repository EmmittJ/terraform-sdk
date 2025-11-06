using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_app_configuration_key.
/// </summary>
public class AzurermAppConfigurationKeyDataSource : TerraformDataSource
{
    public AzurermAppConfigurationKeyDataSource(string name) : base("azurerm_app_configuration_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("content_type");
        this.DeclareOutput("etag");
        this.DeclareOutput("locked");
        this.DeclareOutput("tags");
        this.DeclareOutput("type");
        this.DeclareOutput("value");
        this.DeclareOutput("vault_key_reference");
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
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The locked attribute.
    /// </summary>
    public TerraformExpression Locked => this["locked"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformExpression Value => this["value"];

    /// <summary>
    /// The vault_key_reference attribute.
    /// </summary>
    public TerraformExpression VaultKeyReference => this["vault_key_reference"];

}
