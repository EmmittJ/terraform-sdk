using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_access_token.
/// </summary>
public class GoogleServiceAccountAccessTokenDataSource : TerraformDataSource
{
    public GoogleServiceAccountAccessTokenDataSource(string name) : base("google_service_account_access_token", name)
    {
    }

    /// <summary>
    /// The delegates attribute.
    /// </summary>
    [TerraformPropertyName("delegates")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Delegates { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lifetime attribute.
    /// </summary>
    [TerraformPropertyName("lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Lifetime { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// The target_service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetServiceAccount is required")]
    [TerraformPropertyName("target_service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetServiceAccount { get; set; }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_token");

}
