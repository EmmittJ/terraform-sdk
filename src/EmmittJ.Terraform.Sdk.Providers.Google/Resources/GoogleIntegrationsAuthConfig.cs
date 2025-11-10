using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptedPrivateKey is required")]
    public required TerraformProperty<string> EncryptedPrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("encrypted_private_key");
        set => WithProperty("encrypted_private_key", value);
    }

    /// <summary>
    /// &#39;passphrase&#39; should be left unset if private key is not encrypted.
    /// Note that &#39;passphrase&#39; is not the password for web server, but an extra layer of security to protected private key.
    /// </summary>
    public TerraformProperty<string>? Passphrase
    {
        get => GetProperty<TerraformProperty<string>>("passphrase");
        set => WithProperty("passphrase", value);
    }

    /// <summary>
    /// The ssl certificate encoded in PEM format. This string must include the begin header and end footer lines.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SslCertificate is required")]
    public required TerraformProperty<string> SslCertificate
    {
        get => GetProperty<TerraformProperty<string>>("ssl_certificate");
        set => WithProperty("ssl_certificate", value);
    }

}

/// <summary>
/// Block type for decrypted_credential in .
/// Nesting mode: list
/// </summary>
public class GoogleIntegrationsAuthConfigDecryptedCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Credential type associated with auth configs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialType is required")]
    public required TerraformProperty<string> CredentialType
    {
        get => GetProperty<TerraformProperty<string>>("credential_type");
        set => WithProperty("credential_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIntegrationsAuthConfigTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_integrations_auth_config resource.
/// </summary>
public class GoogleIntegrationsAuthConfig : TerraformResource
{
    public GoogleIntegrationsAuthConfig(string name) : base("google_integrations_auth_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_id");
        this.DeclareOutput("create_time");
        this.DeclareOutput("creator_email");
        this.DeclareOutput("credential_type");
        this.DeclareOutput("encrypted_credential");
        this.DeclareOutput("last_modifier_email");
        this.DeclareOutput("name");
        this.DeclareOutput("reason");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
        this.DeclareOutput("valid_time");
    }

    /// <summary>
    /// A description of the auth config.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name of the auth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// User can define the time to receive notification after which the auth config becomes invalid. Support up to 30 days. Support granularity in hours.
    /// 
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public List<TerraformProperty<string>>? ExpiryNotificationDuration
    {
        get => GetProperty<List<TerraformProperty<string>>>("expiry_notification_duration");
        set => this.WithProperty("expiry_notification_duration", value);
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
    /// Location in which client needs to be provisioned.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// User provided expiry time to override. For the example of Salesforce, username/password credentials can be valid for 6 months depending on the instance settings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? OverrideValidTime
    {
        get => GetProperty<TerraformProperty<string>>("override_valid_time");
        set => this.WithProperty("override_valid_time", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The visibility of the auth config. Possible values: [&amp;quot;PRIVATE&amp;quot;, &amp;quot;CLIENT_VISIBLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Visibility
    {
        get => GetProperty<TerraformProperty<string>>("visibility");
        set => this.WithProperty("visibility", value);
    }

    /// <summary>
    /// Block for client_certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    public List<GoogleIntegrationsAuthConfigClientCertificateBlock>? ClientCertificate
    {
        get => GetProperty<List<GoogleIntegrationsAuthConfigClientCertificateBlock>>("client_certificate");
        set => this.WithProperty("client_certificate", value);
    }

    /// <summary>
    /// Block for decrypted_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DecryptedCredential block(s) allowed")]
    public List<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>? DecryptedCredential
    {
        get => GetProperty<List<GoogleIntegrationsAuthConfigDecryptedCredentialBlock>>("decrypted_credential");
        set => this.WithProperty("decrypted_credential", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIntegrationsAuthConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIntegrationsAuthConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Certificate id for client certificate.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

    /// <summary>
    /// The timestamp when the auth config is created.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The creator&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    public TerraformExpression CreatorEmail => this["creator_email"];

    /// <summary>
    /// Credential type of the encrypted credential.
    /// </summary>
    public TerraformExpression CredentialType => this["credential_type"];

    /// <summary>
    /// Auth credential encrypted by Cloud KMS. Can be decrypted as Credential with proper KMS key.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformExpression EncryptedCredential => this["encrypted_credential"];

    /// <summary>
    /// The last modifier&#39;s email address. Generated based on the End User Credentials/LOAS role of the user making the call.
    /// </summary>
    public TerraformExpression LastModifierEmail => this["last_modifier_email"];

    /// <summary>
    /// Resource name of the auth config.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The reason / details of the current status.
    /// </summary>
    public TerraformExpression Reason => this["reason"];

    /// <summary>
    /// The status of the auth config.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The timestamp when the auth config is modified.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// The time until the auth config is valid. Empty or max value is considered the auth config won&#39;t expire.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression ValidTime => this["valid_time"];

}
