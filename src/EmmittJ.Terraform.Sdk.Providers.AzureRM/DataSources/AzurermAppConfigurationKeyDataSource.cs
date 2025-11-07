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
    public TerraformProperty<string>? ConfigurationStoreId
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
