using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIdentityPlatformDefaultSupportedIdpConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_identity_platform_default_supported_idp_config resource.
/// </summary>
public partial class GoogleIdentityPlatformDefaultSupportedIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformDefaultSupportedIdpConfig(string name) : base("google_identity_platform_default_supported_idp_config", name)
    {
    }

    /// <summary>
    /// OAuth client ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// OAuth client secret
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

    /// <summary>
    /// If this IDP allows the user to sign in
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
    /// ID of the IDP. Possible values include:
    /// 
    /// * &#39;apple.com&#39;
    /// 
    /// * &#39;facebook.com&#39;
    /// 
    /// * &#39;gc.apple.com&#39;
    /// 
    /// * &#39;github.com&#39;
    /// 
    /// * &#39;google.com&#39;
    /// 
    /// * &#39;linkedin.com&#39;
    /// 
    /// * &#39;microsoft.com&#39;
    /// 
    /// * &#39;playgames.google.com&#39;
    /// 
    /// * &#39;twitter.com&#39;
    /// 
    /// * &#39;yahoo.com&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpId is required")]
    [TerraformProperty("idp_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdpId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIdentityPlatformDefaultSupportedIdpConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the DefaultSupportedIdpConfig resource
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
