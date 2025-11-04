using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_key.
/// </summary>
public class AzurermKeyVaultKeyDataSource : TerraformDataSource
{
    public AzurermKeyVaultKeyDataSource(string name) : base("azurerm_key_vault_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("curve");
        this.DeclareOutput("e");
        this.DeclareOutput("key_opts");
        this.DeclareOutput("key_size");
        this.DeclareOutput("key_type");
        this.DeclareOutput("n");
        this.DeclareOutput("public_key_openssh");
        this.DeclareOutput("public_key_pem");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_versionless_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("version");
        this.DeclareOutput("versionless_id");
        this.DeclareOutput("x");
        this.DeclareOutput("y");
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
    /// The key_vault_id attribute.
    /// </summary>
    public string? KeyVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_id")?.Value;
        set => this.WithProperty("key_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public TerraformExpression Curve => this["curve"];

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformExpression E => this["e"];

    /// <summary>
    /// The key_opts attribute.
    /// </summary>
    public TerraformExpression KeyOpts => this["key_opts"];

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformExpression KeySize => this["key_size"];

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformExpression KeyType => this["key_type"];

    /// <summary>
    /// The n attribute.
    /// </summary>
    public TerraformExpression N => this["n"];

    /// <summary>
    /// The public_key_openssh attribute.
    /// </summary>
    public TerraformExpression PublicKeyOpenssh => this["public_key_openssh"];

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformExpression PublicKeyPem => this["public_key_pem"];

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformExpression ResourceVersionlessId => this["resource_versionless_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformExpression VersionlessId => this["versionless_id"];

    /// <summary>
    /// The x attribute.
    /// </summary>
    public TerraformExpression X => this["x"];

    /// <summary>
    /// The y attribute.
    /// </summary>
    public TerraformExpression Y => this["y"];

}
