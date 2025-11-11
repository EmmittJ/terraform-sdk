using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for idp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock
{
    /// <summary>
    /// Unique identifier for all SAML entities
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpEntityId is required")]
    [TerraformPropertyName("idp_entity_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdpEntityId { get; set; }

    /// <summary>
    /// Indicates if outbounding SAMLRequest should be signed.
    /// </summary>
    [TerraformPropertyName("sign_request")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SignRequest { get; set; }

    /// <summary>
    /// URL to send Authentication request to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SsoUrl is required")]
    [TerraformPropertyName("sso_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SsoUrl { get; set; }

}

/// <summary>
/// Block type for sp_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock
{
    /// <summary>
    /// Callback URI where responses from IDP are handled. Must start with &#39;https://&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUri is required")]
    [TerraformPropertyName("callback_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CallbackUri { get; set; }


    /// <summary>
    /// Unique identifier for all SAML entities.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpEntityId is required")]
    [TerraformPropertyName("sp_entity_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpEntityId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock
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
/// Manages a google_identity_platform_tenant_inbound_saml_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIdentityPlatformTenantInboundSamlConfig : TerraformResource
{
    public GoogleIdentityPlatformTenantInboundSamlConfig(string name) : base("google_identity_platform_tenant_inbound_saml_config", name)
    {
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The name of the tenant where this inbound SAML config resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformPropertyName("tenant")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tenant { get; set; }

    /// <summary>
    /// Block for idp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    [TerraformPropertyName("idp_config")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock>>? IdpConfig { get; set; }

    /// <summary>
    /// Block for sp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpConfig block(s) allowed")]
    [TerraformPropertyName("sp_config")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock>>? SpConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock>? Timeouts { get; set; }

}
