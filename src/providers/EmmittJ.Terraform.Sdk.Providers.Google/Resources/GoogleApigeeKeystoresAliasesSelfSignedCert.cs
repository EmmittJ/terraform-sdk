using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for subject in GoogleApigeeKeystoresAliasesSelfSignedCert.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject";

    /// <summary>
    /// Common name of the organization. Maximum length is 64 characters.
    /// </summary>
    public TerraformValue<string>? CommonName
    {
        get => GetArgument<TerraformValue<string>>("common_name");
        set => SetArgument("common_name", value);
    }

    /// <summary>
    /// Two-letter country code. Example, IN for India, US for United States of America.
    /// </summary>
    public TerraformValue<string>? CountryCode
    {
        get => GetArgument<TerraformValue<string>>("country_code");
        set => SetArgument("country_code", value);
    }

    /// <summary>
    /// Email address. Max 255 characters.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// City or town name. Maximum length is 128 characters.
    /// </summary>
    public TerraformValue<string>? Locality
    {
        get => GetArgument<TerraformValue<string>>("locality");
        set => SetArgument("locality", value);
    }

    /// <summary>
    /// Organization name. Maximum length is 64 characters.
    /// </summary>
    public TerraformValue<string>? Org
    {
        get => GetArgument<TerraformValue<string>>("org");
        set => SetArgument("org", value);
    }

    /// <summary>
    /// Organization team name. Maximum length is 64 characters.
    /// </summary>
    public TerraformValue<string>? OrgUnit
    {
        get => GetArgument<TerraformValue<string>>("org_unit");
        set => SetArgument("org_unit", value);
    }

    /// <summary>
    /// State or district name. Maximum length is 128 characters.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

}


/// <summary>
/// Block type for subject_alternative_dns_names in GoogleApigeeKeystoresAliasesSelfSignedCert.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subject_alternative_dns_names";

    /// <summary>
    /// Subject Alternative Name
    /// </summary>
    public TerraformValue<string>? SubjectAlternativeName
    {
        get => GetArgument<TerraformValue<string>>("subject_alternative_name");
        set => SetArgument("subject_alternative_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeKeystoresAliasesSelfSignedCert.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apigee_keystores_aliases_self_signed_cert Terraform resource.
/// Manages a google_apigee_keystores_aliases_self_signed_cert resource.
/// </summary>
public partial class GoogleApigeeKeystoresAliasesSelfSignedCert(string name) : TerraformResource("google_apigee_keystores_aliases_self_signed_cert", name)
{
    /// <summary>
    /// Alias for the key/certificate pair. Values must match the regular expression [\w\s-.]{1,255}.
    /// This must be provided for all formats except selfsignedcert; self-signed certs may specify the alias in either
    /// this parameter or the JSON body.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Alias is required")]
    public required TerraformValue<string> Alias
    {
        get => GetRequiredArgument<TerraformValue<string>>("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// Validity duration of certificate, in days. Accepts positive non-zero value. Defaults to 365.
    /// </summary>
    public TerraformValue<double>? CertValidityInDays
    {
        get => GetArgument<TerraformValue<double>>("cert_validity_in_days");
        set => SetArgument("cert_validity_in_days", value);
    }

    /// <summary>
    /// The Apigee environment name
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetRequiredArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Key size. Default and maximum value is 2048 bits.
    /// </summary>
    public TerraformValue<string>? KeySize
    {
        get => GetArgument<TerraformValue<string>>("key_size");
        set => SetArgument("key_size", value);
    }

    /// <summary>
    /// The Apigee keystore name associated in an Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keystore is required")]
    public required TerraformValue<string> Keystore
    {
        get => GetRequiredArgument<TerraformValue<string>>("keystore");
        set => SetArgument("keystore", value);
    }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee environment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Signature algorithm to generate private key. Valid values are SHA512withRSA, SHA384withRSA, and SHA256withRSA
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigAlg is required")]
    public required TerraformValue<string> SigAlg
    {
        get => GetRequiredArgument<TerraformValue<string>>("sig_alg");
        set => SetArgument("sig_alg", value);
    }

    /// <summary>
    /// Chain of certificates under this alias.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertsInfo
        => AsReference("certs_info");

    /// <summary>
    /// Optional.Type of Alias
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Subject block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subject is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Subject block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Subject block(s) allowed")]
    public required TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock> Subject
    {
        get => GetRequiredArgument<TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectBlock>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// SubjectAlternativeDnsNames block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SubjectAlternativeDnsNames block(s) allowed")]
    public TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>? SubjectAlternativeDnsNames
    {
        get => GetArgument<TerraformList<GoogleApigeeKeystoresAliasesSelfSignedCertSubjectAlternativeDnsNamesBlock>>("subject_alternative_dns_names");
        set => SetArgument("subject_alternative_dns_names", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeKeystoresAliasesSelfSignedCertTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
