using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subject in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock
{
    /// <summary>
    /// Common name of the organization. Maximum length is 64 characters.
    /// </summary>
    [TerraformPropertyName("common_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CommonName { get; set; }

    /// <summary>
    /// Two-letter country code. Example, IN for India, US for United States of America.
    /// </summary>
    [TerraformPropertyName("country_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CountryCode { get; set; }

    /// <summary>
    /// Email address. Max 255 characters.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// City or town name. Maximum length is 128 characters.
    /// </summary>
    [TerraformPropertyName("locality")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Locality { get; set; }

    /// <summary>
    /// Organization name. Maximum length is 64 characters.
    /// </summary>
    [TerraformPropertyName("org")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Org { get; set; }

    /// <summary>
    /// Organization team name. Maximum length is 64 characters.
    /// </summary>
    [TerraformPropertyName("org_unit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrgUnit { get; set; }

    /// <summary>
    /// State or district name. Maximum length is 128 characters.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? State { get; set; }

}

/// <summary>
/// Block type for subject_alternative_dns_names in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock
{
    /// <summary>
    /// Subject Alternative Name
    /// </summary>
    [TerraformPropertyName("subject_alternative_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubjectAlternativeName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apigee_keystores_aliases_self_signed_cert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeKeystoresAliasesSelfSignedCert : TerraformResource
{
    public GoogleApigeeKeystoresAliasesSelfSignedCert(string name) : base("google_apigee_keystores_aliases_self_signed_cert", name)
    {
    }

    /// <summary>
    /// Alias for the key/certificate pair. Values must match the regular expression [\w\s-.]{1,255}.
    /// This must be provided for all formats except selfsignedcert; self-signed certs may specify the alias in either
    /// this parameter or the JSON body.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    [TerraformPropertyName("alias")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    [TerraformPropertyName("cert_validity_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CertValidityInDays { get; set; }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformPropertyName("environment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    [TerraformPropertyName("key_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeySize { get; set; }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    [TerraformPropertyName("keystore")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Keystore { get; set; }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigAlg is required")]
    [TerraformPropertyName("sig_alg")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SigAlg { get; set; }

    /// <summary>
    /// Block for subject.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    [TerraformPropertyName("subject")]
    public TerraformList<TerraformBlock<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock>>? Subject { get; set; }

    /// <summary>
    /// Block for subject_alternative_dns_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeDnsNames block(s) allowed")]
    [TerraformPropertyName("subject_alternative_dns_names")]
    public TerraformList<TerraformBlock<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>>? SubjectAlternativeDnsNames { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    [TerraformPropertyName("certs_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertsInfo => new TerraformReference(this, "certs_info");

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
