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
        set => SetProperty("idp_entity_id", value);
    }

    /// <summary>
    /// Indicates if outbounding SAMLRequest should be signed.
    /// </summary>
    public TerraformProperty<bool>? SignRequest
    {
        set => SetProperty("sign_request", value);
    }

    /// <summary>
    /// URL to send Authentication request to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SsoUrl is required")]
    public required TerraformProperty<string> SsoUrl
    {
        set => SetProperty("sso_url", value);
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
        set => SetProperty("callback_uri", value);
    }

    /// <summary>
    /// The IDP&#39;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// </summary>
    public List<TerraformProperty<object>>? SpCertificates
    {
        set => SetProperty("sp_certificates", value);
    }

    /// <summary>
    /// Unique identifier for all SAML entities.
    /// </summary>
    public TerraformProperty<string>? SpEntityId
    {
        set => SetProperty("sp_entity_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for idp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    public List<GoogleIdentityPlatformInboundSamlConfigIdpConfigBlock>? IdpConfig
    {
        set => SetProperty("idp_config", value);
    }

    /// <summary>
    /// Block for sp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpConfig block(s) allowed")]
    public List<GoogleIdentityPlatformInboundSamlConfigSpConfigBlock>? SpConfig
    {
        set => SetProperty("sp_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformInboundSamlConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
