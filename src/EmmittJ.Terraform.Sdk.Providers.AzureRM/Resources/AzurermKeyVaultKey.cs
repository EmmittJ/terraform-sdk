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
    public TerraformProperty<string>? Curve
    {
        get => GetProperty<TerraformProperty<string>>("curve");
        set => this.WithProperty("curve", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformProperty<string>? ExpirationDate
    {
        get => GetProperty<TerraformProperty<string>>("expiration_date");
        set => this.WithProperty("expiration_date", value);
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
    /// The key_opts attribute.
    /// </summary>
    public TerraformProperty<List<string>>? KeyOpts
    {
        get => GetProperty<TerraformProperty<List<string>>>("key_opts");
        set => this.WithProperty("key_opts", value);
    }

    /// <summary>
    /// The key_size attribute.
    /// </summary>
    public TerraformProperty<double>? KeySize
    {
        get => GetProperty<TerraformProperty<double>>("key_size");
        set => this.WithProperty("key_size", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformProperty<string>? KeyType
    {
        get => GetProperty<TerraformProperty<string>>("key_type");
        set => this.WithProperty("key_type", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The not_before_date attribute.
    /// </summary>
    public TerraformProperty<string>? NotBeforeDate
    {
        get => GetProperty<TerraformProperty<string>>("not_before_date");
        set => this.WithProperty("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
