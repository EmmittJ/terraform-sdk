using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationsAuthConfigClientCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptedPrivateKey is required")]
    [TerraformProperty("encrypted_private_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EncryptedPrivateKey { get; set; }

    /// <summary>
    /// &#39;passphrase&#39; should be left unset if private key is not encrypted.
    /// Note that &#39;passphrase&#39; is not the password for web server, but an extra layer of security to protected private key.
    /// </summary>
    [TerraformProperty("passphrase")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Passphrase { get; set; }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    [TerraformProperty("ssl_certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SslCertificate { get; set; }

}

/// <summary>
/// Block type for decrypted_credential in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIntegrationsAuthConfigDecryptedCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// Credential type associated with auth configs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialType is required")]
    [TerraformProperty("credential_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CredentialType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIntegrationsAuthConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_integrations_auth_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIntegrationsAuthConfig : TerraformResource
{
    public GoogleIntegrationsAuthConfig(string name) : base("google_integrations_auth_config", name)
    {
    }

    /// <summary>
    /// A description of the auth config.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of the auth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// User can define the time to receive notification after which the auth config becomes invalid. Support up to 30 days. Support granularity in hours.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("expiry_notification_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ExpiryNotificationDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// User provided expiry time to override. For the example of Salesforce, username/password credentials can be valid for 6 months depending on the instance settings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("override_valid_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OverrideValidTime { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The visibility of the auth config. Possible values: [&amp;quot;PRIVATE&amp;quot;, &amp;quot;CLIENT_VISIBLE&amp;quot;]
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Visibility { get; set; }

    /// <summary>
    /// Block for client_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    [TerraformProperty("client_certificate")]
    public TerraformList<TerraformBlock<GoogleIntegrationsAuthConfigClientCertificateBlock>>? ClientCertificate { get; set; }

    /// <summary>
    /// Block for decrypted_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptedCredential block(s) allowed")]
    [TerraformProperty("decrypted_credential")]
    public TerraformList<TerraformBlock<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>>? DecryptedCredential { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleIntegrationsAuthConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Certificate id for client certificate.
    /// </summary>
    [TerraformProperty("certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateId { get; }

    /// <summary>
    /// The timestamp when the auth config is created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The creator&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    [TerraformProperty("creator_email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatorEmail { get; }

    /// <summary>
    /// Credential type of the encrypted credential.
    /// </summary>
    [TerraformProperty("credential_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CredentialType { get; }

    /// <summary>
    /// Auth credential encrypted by Cloud KMS. Can be decrypted as Credential with proper KMS key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformProperty("encrypted_credential")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EncryptedCredential { get; }

    /// <summary>
    /// The last modifier&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    [TerraformProperty("last_modifier_email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifierEmail { get; }

    /// <summary>
    /// Resource name of the auth config.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The reason / details of the current status.
    /// </summary>
    [TerraformProperty("reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Reason { get; }

    /// <summary>
    /// The status of the auth config.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The timestamp when the auth config is modified.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The time until the auth config is valid. Empty or max value is considered the auth config won&#39;t expire.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("valid_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidTime { get; }

}
