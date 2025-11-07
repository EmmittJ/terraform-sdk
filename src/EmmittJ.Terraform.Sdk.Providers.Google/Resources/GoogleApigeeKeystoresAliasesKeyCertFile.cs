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
    public TerraformLiteralProperty<string>? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// Cert content.
    /// </summary>
    public TerraformLiteralProperty<string>? Cert
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cert");
        set => this.WithProperty("cert", value);
    }

    /// <summary>
    /// Environment associated with the alias.
    /// </summary>
    public TerraformLiteralProperty<string>? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Private Key content, omit if uploading to truststore.
    /// </summary>
    public TerraformLiteralProperty<string>? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// Keystore Name.
    /// </summary>
    public TerraformLiteralProperty<string>? Keystore
    {
        get => GetProperty<TerraformLiteralProperty<string>>("keystore");
        set => this.WithProperty("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
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
