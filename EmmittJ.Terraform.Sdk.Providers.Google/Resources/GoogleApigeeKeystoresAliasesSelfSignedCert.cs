using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_keystores_aliases_self_signed_cert resource.
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCert : TerraformResource
{
    public GoogleApigeeKeystoresAliasesSelfSignedCert(string name) : base("google_apigee_keystores_aliases_self_signed_cert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certs_info");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// Alias for the key/certificate pair. Values must match the regular expression [\w\s-.]{1,255}.
    /// This must be provided for all formats except selfsignedcert; self-signed certs may specify the alias in either
    /// this parameter or the JSON body.
    /// </summary>
    public string? Alias
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alias")?.Value;
        set => this.WithProperty("alias", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    public double? CertValidityInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cert_validity_in_days")?.Value;
        set => this.WithProperty("cert_validity_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    public string? KeySize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_size")?.Value;
        set => this.WithProperty("key_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    public string? Keystore
    {
        get => GetProperty<TerraformLiteralProperty<string>>("keystore")?.Value;
        set => this.WithProperty("keystore", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    public string? SigAlg
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sig_alg")?.Value;
        set => this.WithProperty("sig_alg", value == null ? null : new TerraformLiteralProperty<string>(value));
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
