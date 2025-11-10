using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_access_context_manager_access_policy.
/// </summary>
public class GoogleAccessContextManagerAccessPolicyDataSource : TerraformDataSource
{
    public GoogleAccessContextManagerAccessPolicyDataSource(string name) : base("google_access_context_manager_access_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [TerraformPropertyName("scopes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Title => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "title");

}
