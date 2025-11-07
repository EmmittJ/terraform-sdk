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
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// Cert content.
    /// </summary>
    public TerraformProperty<string>? Cert
    {
        get => GetProperty<TerraformProperty<string>>("cert");
        set => this.WithProperty("cert", value);
    }

    /// <summary>
    /// Environment associated with the alias.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Private Key content, omit if uploading to truststore.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// Keystore Name.
    /// </summary>
    public TerraformProperty<string>? Keystore
    {
        get => GetProperty<TerraformProperty<string>>("keystore");
        set => this.WithProperty("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
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
