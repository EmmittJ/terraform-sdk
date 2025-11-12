using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for response_type in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformOauthIdpConfigResponseTypeBlock() : TerraformBlock("response_type")
{
    /// <summary>
    /// If true, authorization code is returned from IdP&#39;s authorization endpoint.
    /// </summary>
    [TerraformProperty("code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Code { get; set; }

    /// <summary>
    /// If true, ID token is returned from IdP&#39;s authorization endpoint.
    /// </summary>
    [TerraformProperty("id_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IdToken { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIdentityPlatformOauthIdpConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_identity_platform_oauth_idp_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIdentityPlatformOauthIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformOauthIdpConfig(string name) : base("google_identity_platform_oauth_idp_config", name)
    {
    }

    /// <summary>
    /// The client id of an OAuth client.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client secret of the OAuth client, to enable OIDC code flow.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

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
    /// For OIDC Idps, the issuer identifier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformProperty("issuer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Issuer { get; set; }

    /// <summary>
    /// The name of the OauthIdpConfig. Must start with &#39;oidc.&#39;.
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
    /// Block for response_type.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResponseType block(s) allowed")]
    [TerraformProperty("response_type")]
    public TerraformList<GoogleIdentityPlatformOauthIdpConfigResponseTypeBlock> ResponseType { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIdentityPlatformOauthIdpConfigTimeoutsBlock Timeouts { get; set; } = new();

}
