using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for idp_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock() : TerraformBlock("idp_config")
{
    /// <summary>
    /// Unique identifier for all SAML entities
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpEntityId is required")]
    [TerraformProperty("idp_entity_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdpEntityId { get; set; }

    /// <summary>
    /// Indicates if outbounding SAMLRequest should be signed.
    /// </summary>
    [TerraformProperty("sign_request")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SignRequest { get; set; }

    /// <summary>
    /// URL to send Authentication request to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SsoUrl is required")]
    [TerraformProperty("sso_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SsoUrl { get; set; }

}

/// <summary>
/// Block type for sp_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock() : TerraformBlock("sp_config")
{
    /// <summary>
    /// Callback URI where responses from IDP are handled. Must start with &#39;https://&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUri is required")]
    [TerraformProperty("callback_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CallbackUri { get; set; }


    /// <summary>
    /// Unique identifier for all SAML entities.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpEntityId is required")]
    [TerraformProperty("sp_entity_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpEntityId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_identity_platform_tenant_inbound_saml_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIdentityPlatformTenantInboundSamlConfig : TerraformResource
{
    public GoogleIdentityPlatformTenantInboundSamlConfig(string name) : base("google_identity_platform_tenant_inbound_saml_config", name)
    {
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the tenant where this inbound SAML config resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformProperty("tenant")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tenant { get; set; }

    /// <summary>
    /// Block for idp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    [TerraformProperty("idp_config")]
    public required TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock> IdpConfig { get; set; } = new();

    /// <summary>
    /// Block for sp_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpConfig block(s) allowed")]
    [TerraformProperty("sp_config")]
    public required TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock> SpConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock Timeouts { get; set; } = new();

}
