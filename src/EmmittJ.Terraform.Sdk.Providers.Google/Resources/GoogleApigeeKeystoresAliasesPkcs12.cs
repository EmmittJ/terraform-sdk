using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_keystores_aliases_pkcs12 resource.
/// </summary>
public class GoogleApigeeKeystoresAliasesPkcs12 : TerraformResource
{
    public GoogleApigeeKeystoresAliasesPkcs12(string name) : base("google_apigee_keystores_aliases_pkcs12", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certs_info");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// Alias Name
    /// </summary>
    public TerraformLiteralProperty<string>? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// Environment associated with the alias
    /// </summary>
    public TerraformLiteralProperty<string>? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// Cert content
    /// </summary>
    public TerraformLiteralProperty<string>? File
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file");
        set => this.WithProperty("file", value);
    }

    /// <summary>
    /// Hash of the pkcs file
    /// </summary>
    public TerraformLiteralProperty<string>? Filehash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("filehash");
        set => this.WithProperty("filehash", value);
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
    /// Keystore Name
    /// </summary>
    public TerraformLiteralProperty<string>? Keystore
    {
        get => GetProperty<TerraformLiteralProperty<string>>("keystore");
        set => this.WithProperty("keystore", value);
    }

    /// <summary>
    /// Organization ID associated with the alias
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Password for the Private Key if it&#39;s encrypted
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
    /// Optional.Type of Alias
    /// </summary>
    public TerraformExpression Type => this["type"];

}
