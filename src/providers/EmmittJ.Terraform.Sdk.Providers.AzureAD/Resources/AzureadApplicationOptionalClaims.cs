using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for access_token in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationOptionalClaimsAccessTokenBlock() : TerraformBlock("access_token")
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformProperty("essential")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for id_token in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationOptionalClaimsIdTokenBlock() : TerraformBlock("id_token")
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformProperty("essential")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for saml2_token in .
/// Nesting mode: list
/// </summary>
public partial class AzureadApplicationOptionalClaimsSaml2TokenBlock() : TerraformBlock("saml2_token")
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformProperty("additional_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformProperty("essential")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationOptionalClaimsTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_optional_claims resource.
/// </summary>
public partial class AzureadApplicationOptionalClaims : TerraformResource
{
    public AzureadApplicationOptionalClaims(string name) : base("azuread_application_optional_claims", name)
    {
    }

    /// <summary>
    /// The resource ID of the application to which these optional claims belong
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for access_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("access_token")]
    public TerraformList<AzureadApplicationOptionalClaimsAccessTokenBlock> AccessToken { get; set; } = new();

    /// <summary>
    /// Block for id_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("id_token")]
    public TerraformList<AzureadApplicationOptionalClaimsIdTokenBlock> IdToken { get; set; } = new();

    /// <summary>
    /// Block for saml2_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("saml2_token")]
    public TerraformList<AzureadApplicationOptionalClaimsSaml2TokenBlock> Saml2Token { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadApplicationOptionalClaimsTimeoutsBlock Timeouts { get; set; } = new();

}
