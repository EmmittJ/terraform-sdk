using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for access_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsAccessTokenBlock : ITerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformPropertyName("essential")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

}

/// <summary>
/// Block type for id_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsIdTokenBlock : ITerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformPropertyName("essential")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

}

/// <summary>
/// Block type for saml2_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsSaml2TokenBlock : ITerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    [TerraformPropertyName("additional_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AdditionalProperties { get; set; }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    [TerraformPropertyName("essential")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Essential { get; set; }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationOptionalClaimsTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_optional_claims resource.
/// </summary>
public class AzureadApplicationOptionalClaims : TerraformResource
{
    public AzureadApplicationOptionalClaims(string name) : base("azuread_application_optional_claims", name)
    {
    }

    /// <summary>
    /// The resource ID of the application to which these optional claims belong
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for access_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("access_token")]
    public TerraformList<TerraformBlock<AzureadApplicationOptionalClaimsAccessTokenBlock>>? AccessToken { get; set; } = new();

    /// <summary>
    /// Block for id_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("id_token")]
    public TerraformList<TerraformBlock<AzureadApplicationOptionalClaimsIdTokenBlock>>? IdToken { get; set; } = new();

    /// <summary>
    /// Block for saml2_token.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("saml2_token")]
    public TerraformList<TerraformBlock<AzureadApplicationOptionalClaimsSaml2TokenBlock>>? Saml2Token { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationOptionalClaimsTimeoutsBlock>? Timeouts { get; set; } = new();

}
