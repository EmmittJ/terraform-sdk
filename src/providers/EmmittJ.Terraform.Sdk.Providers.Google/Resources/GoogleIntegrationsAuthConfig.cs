using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigClientCertificateBlock
{
    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptedPrivateKey is required")]
    [TerraformPropertyName("encrypted_private_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EncryptedPrivateKey { get; set; }

    /// <summary>
    /// &#39;passphrase&#39; should be left unset if private key is not encrypted.
    /// Note that &#39;passphrase&#39; is not the password for web server, but an extra layer of security to protected private key.
    /// </summary>
    [TerraformPropertyName("passphrase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Passphrase { get; set; }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    [TerraformPropertyName("ssl_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SslCertificate { get; set; }

}

/// <summary>
/// Block type for decrypted_credential in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlock
{
    /// <summary>
    /// Credential type associated with auth configs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialType is required")]
    [TerraformPropertyName("credential_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CredentialType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsAuthConfigTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_integrations_auth_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIntegrationsAuthConfig : TerraformResource
{
    public GoogleIntegrationsAuthConfig(string name) : base("google_integrations_auth_config", name)
    {
    }

    /// <summary>
    /// A description of the auth config.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of the auth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// User can define the time to receive notification after which the auth config becomes invalid. Support up to 30 days. Support granularity in hours.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("expiry_notification_duration")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ExpiryNotificationDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// User provided expiry time to override. For the example of Salesforce, username/password credentials can be valid for 6 months depending on the instance settings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("override_valid_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OverrideValidTime { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The visibility of the auth config. Possible values: [&amp;quot;PRIVATE&amp;quot;, &amp;quot;CLIENT_VISIBLE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Visibility { get; set; }

    /// <summary>
    /// Block for client_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    [TerraformPropertyName("client_certificate")]
    public TerraformList<TerraformBlock<GoogleIntegrationsAuthConfigClientCertificateBlock>>? ClientCertificate { get; set; }

    /// <summary>
    /// Block for decrypted_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptedCredential block(s) allowed")]
    [TerraformPropertyName("decrypted_credential")]
    public TerraformList<TerraformBlock<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>>? DecryptedCredential { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIntegrationsAuthConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Certificate id for client certificate.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateId => new TerraformReference(this, "certificate_id");

    /// <summary>
    /// The timestamp when the auth config is created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The creator&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    [TerraformPropertyName("creator_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatorEmail => new TerraformReference(this, "creator_email");

    /// <summary>
    /// Credential type of the encrypted credential.
    /// </summary>
    [TerraformPropertyName("credential_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CredentialType => new TerraformReference(this, "credential_type");

    /// <summary>
    /// Auth credential encrypted by Cloud KMS. Can be decrypted as Credential with proper KMS key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("encrypted_credential")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptedCredential => new TerraformReference(this, "encrypted_credential");

    /// <summary>
    /// The last modifier&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    [TerraformPropertyName("last_modifier_email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifierEmail => new TerraformReference(this, "last_modifier_email");

    /// <summary>
    /// Resource name of the auth config.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The reason / details of the current status.
    /// </summary>
    [TerraformPropertyName("reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Reason => new TerraformReference(this, "reason");

    /// <summary>
    /// The status of the auth config.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The timestamp when the auth config is modified.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// The time until the auth config is valid. Empty or max value is considered the auth config won&#39;t expire.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("valid_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ValidTime => new TerraformReference(this, "valid_time");

}
