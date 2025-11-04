using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// An alias from a key/cert file.
/// </summary>
public class GoogleApigeeKeystoresAliasesKeyCertFile : TerraformResource
{
    public GoogleApigeeKeystoresAliasesKeyCertFile(string name) : base("google_apigee_keystores_aliases_key_cert_file", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certs_info");
        this.DeclareOutput("id");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// Alias Name.
    /// </summary>
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cert content.
    /// </summary>
    public string? Cert
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cert")?.Value;
        set => this.WithProperty("cert", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Environment associated with the alias.
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Private Key content, omit if uploading to truststore.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Keystore Name.
    /// </summary>
    public string? Keystore
    {
        get => GetProperty<TerraformLiteralProperty<string>>("keystore")?.Value;
        set => this.WithProperty("keystore", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Organization ID associated with the alias.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformExpression CertsInfo => this["certs_info"];

    /// <summary>
    /// Project identifier
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Optional. Type of Alias.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
