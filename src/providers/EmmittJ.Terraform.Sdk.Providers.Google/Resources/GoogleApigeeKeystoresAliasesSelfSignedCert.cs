using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subject in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock() : TerraformBlock("subject")
{
    /// <summary>
    /// Common name of the organization. Maximum length is 64 characters.
    /// </summary>
    [TerraformProperty("common_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CommonName { get; set; }

    /// <summary>
    /// Two-letter country code. Example, IN for India, US for United States of America.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CountryCode { get; set; }

    /// <summary>
    /// Email address. Max 255 characters.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// City or town name. Maximum length is 128 characters.
    /// </summary>
    [TerraformProperty("locality")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Locality { get; set; }

    /// <summary>
    /// Organization name. Maximum length is 64 characters.
    /// </summary>
    [TerraformProperty("org")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Org { get; set; }

    /// <summary>
    /// Organization team name. Maximum length is 64 characters.
    /// </summary>
    [TerraformProperty("org_unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrgUnit { get; set; }

    /// <summary>
    /// State or district name. Maximum length is 128 characters.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

}

/// <summary>
/// Block type for subject_alternative_dns_names in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock() : TerraformBlock("subject_alternative_dns_names")
{
    /// <summary>
    /// Subject Alternative Name
    /// </summary>
    [TerraformProperty("subject_alternative_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubjectAlternativeName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apigee_keystores_aliases_self_signed_cert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeKeystoresAliasesSelfSignedCert : TerraformResource
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
    [TerraformProperty("alias")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Alias { get; set; }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    [TerraformProperty("cert_validity_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CertValidityInDays { get; set; }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    [TerraformProperty("environment")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Environment { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    [TerraformProperty("key_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeySize { get; set; }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    [TerraformProperty("keystore")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Keystore { get; set; }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigAlg is required")]
    [TerraformProperty("sig_alg")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SigAlg { get; set; }

    /// <summary>
    /// Block for subject.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    [TerraformProperty("subject")]
    public required TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock> Subject { get; set; } = new();

    /// <summary>
    /// Block for subject_alternative_dns_names.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeDnsNames block(s) allowed")]
    [TerraformProperty("subject_alternative_dns_names")]
    public TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock> SubjectAlternativeDnsNames { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    [TerraformProperty("certs_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertsInfo { get; }

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
