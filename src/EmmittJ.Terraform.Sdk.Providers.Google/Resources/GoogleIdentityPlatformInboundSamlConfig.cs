using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for idp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformInboundSamlConfigIdpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Unique identifier for all SAML entities
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpEntityId is required")]
    public required TerraformProperty<string> IdpEntityId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("idp_entity_id");
        set => WithProperty("idp_entity_id", value);
    }

    /// <summary>
    /// Indicates if outbounding SAMLRequest should be signed.
    /// </summary>
    public TerraformProperty<bool>? SignRequest
    {
        get => GetProperty<TerraformProperty<bool>>("sign_request");
        set => WithProperty("sign_request", value);
    }

    /// <summary>
    /// URL to send Authentication request to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SsoUrl is required")]
    public required TerraformProperty<string> SsoUrl
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sso_url");
        set => WithProperty("sso_url", value);
    }

}

/// <summary>
/// Block type for sp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformInboundSamlConfigSpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Callback URI where responses from IDP are handled. Must start with &#39;https://&#39;.
    /// </summary>
    public TerraformProperty<string>? CallbackUri
    {
        get => GetProperty<TerraformProperty<string>>("callback_uri");
        set => WithProperty("callback_uri", value);
    }

    /// <summary>
    /// The IDP&#39;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// </summary>
    public List<TerraformProperty<object>>? SpCertificates
    {
        get => GetProperty<List<TerraformProperty<object>>>("sp_certificates");
        set => WithProperty("sp_certificates", value);
    }

    /// <summary>
    /// Unique identifier for all SAML entities.
    /// </summary>
    public TerraformProperty<string>? SpEntityId
    {
        get => GetProperty<TerraformProperty<string>>("sp_entity_id");
        set => WithProperty("sp_entity_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformInboundSamlConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_identity_platform_inbound_saml_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIdentityPlatformInboundSamlConfig : TerraformResource
{
    public GoogleIdentityPlatformInboundSamlConfig(string name) : base("google_identity_platform_inbound_saml_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for idp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    public List<GoogleIdentityPlatformInboundSamlConfigIdpConfigBlock>? IdpConfig
    {
        get => GetProperty<List<GoogleIdentityPlatformInboundSamlConfigIdpConfigBlock>>("idp_config");
        set => this.WithProperty("idp_config", value);
    }

    /// <summary>
    /// Block for sp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpConfig block(s) allowed")]
    public List<GoogleIdentityPlatformInboundSamlConfigSpConfigBlock>? SpConfig
    {
        get => GetProperty<List<GoogleIdentityPlatformInboundSamlConfigSpConfigBlock>>("sp_config");
        set => this.WithProperty("sp_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformInboundSamlConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIdentityPlatformInboundSamlConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
