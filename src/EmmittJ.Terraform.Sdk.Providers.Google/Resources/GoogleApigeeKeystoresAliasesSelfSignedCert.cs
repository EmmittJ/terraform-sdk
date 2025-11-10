using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subject in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock : TerraformBlock
{
    /// <summary>
    /// Common name of the organization. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? CommonName
    {
        get => GetProperty<TerraformProperty<string>>("common_name");
        set => WithProperty("common_name", value);
    }

    /// <summary>
    /// Two-letter country code. Example, IN for India, US for United States of America.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => WithProperty("country_code", value);
    }

    /// <summary>
    /// Email address. Max 255 characters.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// City or town name. Maximum length is 128 characters.
    /// </summary>
    public TerraformProperty<string>? Locality
    {
        get => GetProperty<TerraformProperty<string>>("locality");
        set => WithProperty("locality", value);
    }

    /// <summary>
    /// Organization name. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? Org
    {
        get => GetProperty<TerraformProperty<string>>("org");
        set => WithProperty("org", value);
    }

    /// <summary>
    /// Organization team name. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? OrgUnit
    {
        get => GetProperty<TerraformProperty<string>>("org_unit");
        set => WithProperty("org_unit", value);
    }

    /// <summary>
    /// State or district name. Maximum length is 128 characters.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

}

/// <summary>
/// Block type for subject_alternative_dns_names in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock : TerraformBlock
{
    /// <summary>
    /// Subject Alternative Name
    /// </summary>
    public TerraformProperty<string>? SubjectAlternativeName
    {
        get => GetProperty<TerraformProperty<string>>("subject_alternative_name");
        set => WithProperty("subject_alternative_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apigee_keystores_aliases_self_signed_cert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformProperty<string> Alias
    {
        get => GetRequiredProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    public TerraformProperty<double>? CertValidityInDays
    {
        get => GetProperty<TerraformProperty<double>>("cert_validity_in_days");
        set => this.WithProperty("cert_validity_in_days", value);
    }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    public TerraformProperty<string>? KeySize
    {
        get => GetProperty<TerraformProperty<string>>("key_size");
        set => this.WithProperty("key_size", value);
    }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformProperty<string> Keystore
    {
        get => GetRequiredProperty<TerraformProperty<string>>("keystore");
        set => this.WithProperty("keystore", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigAlg is required")]
    public required TerraformProperty<string> SigAlg
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sig_alg");
        set => this.WithProperty("sig_alg", value);
    }

    /// <summary>
    /// Block for subject.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    public List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock>? Subject
    {
        get => GetProperty<List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock>>("subject");
        set => this.WithProperty("subject", value);
    }

    /// <summary>
    /// Block for subject_alternative_dns_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeDnsNames block(s) allowed")]
    public List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>? SubjectAlternativeDnsNames
    {
        get => GetProperty<List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>>("subject_alternative_dns_names");
        set => this.WithProperty("subject_alternative_dns_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
