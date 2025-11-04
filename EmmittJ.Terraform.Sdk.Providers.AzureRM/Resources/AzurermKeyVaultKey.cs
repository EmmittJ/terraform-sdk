using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_key resource.
/// </summary>
public class AzurermKeyVaultKey : TerraformResource
{
    public AzurermKeyVaultKey(string name) : base("azurerm_key_vault_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("e");
        this.DeclareOutput("n");
        this.DeclareOutput("public_key_openssh");
        this.DeclareOutput("public_key_pem");
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_versionless_id");
        this.DeclareOutput("version");
        this.DeclareOutput("versionless_id");
        this.DeclareOutput("x");
        this.DeclareOutput("y");
    }

    /// <summary>
    /// The curve attribute.
    /// </summary>
    public string? Curve
    {
        get => GetProperty<TerraformLiteralProperty<string>>("curve")?.Value;
        set => this.WithProperty("curve", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public string? ExpirationDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_date")?.Value;
        set => this.WithProperty("expiration_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_opts attribute.
    /// </summary>
    public List<string>? KeyOpts
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("key_opts")?.Value;
        set => this.WithProperty("key_opts", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public double? KeySize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("key_size")?.Value;
        set => this.WithProperty("key_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public string? KeyType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_type")?.Value;
        set => this.WithProperty("key_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The not_before_date attribute.
    /// </summary>
    public string? NotBeforeDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("not_before_date")?.Value;
        set => this.WithProperty("not_before_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The e attribute.
    /// </summary>
    public TerraformExpression E => this["e"];

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
