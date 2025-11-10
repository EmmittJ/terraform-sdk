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
        set => SetProperty("common_name", value);
    }

    /// <summary>
    /// Two-letter country code. Example, IN for India, US for United States of America.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        set => SetProperty("country_code", value);
    }

    /// <summary>
    /// Email address. Max 255 characters.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        set => SetProperty("email", value);
    }

    /// <summary>
    /// City or town name. Maximum length is 128 characters.
    /// </summary>
    public TerraformProperty<string>? Locality
    {
        set => SetProperty("locality", value);
    }

    /// <summary>
    /// Organization name. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? Org
    {
        set => SetProperty("org", value);
    }

    /// <summary>
    /// Organization team name. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? OrgUnit
    {
        set => SetProperty("org_unit", value);
    }

    /// <summary>
    /// State or district name. Maximum length is 128 characters.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
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
        set => SetProperty("subject_alternative_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("certs_info");
        SetOutput("type");
        SetOutput("alias");
        SetOutput("cert_validity_in_days");
        SetOutput("environment");
        SetOutput("id");
        SetOutput("key_size");
        SetOutput("keystore");
        SetOutput("org_id");
        SetOutput("sig_alg");
    }

    /// <summary>
    /// Alias for the key/certificate pair. Values must match the regular expression [\w\s-.]{1,255}.
    /// This must be provided for all formats except selfsignedcert; self-signed certs may specify the alias in either
    /// this parameter or the JSON body.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
    }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    public TerraformProperty<double> CertValidityInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cert_validity_in_days");
        set => SetProperty("cert_validity_in_days", value);
    }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    public TerraformProperty<string> KeySize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_size");
        set => SetProperty("key_size", value);
    }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformProperty<string> Keystore
    {
        get => GetRequiredOutput<TerraformProperty<string>>("keystore");
        set => SetProperty("keystore", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigAlg is required")]
    public required TerraformProperty<string> SigAlg
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sig_alg");
        set => SetProperty("sig_alg", value);
    }

    /// <summary>
    /// Block for subject.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    public List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock>? Subject
    {
        set => SetProperty("subject", value);
    }

    /// <summary>
    /// Block for subject_alternative_dns_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeDnsNames block(s) allowed")]
    public List<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>? SubjectAlternativeDnsNames
    {
        set => SetProperty("subject_alternative_dns_names", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
