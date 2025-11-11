using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_account_key.
/// </summary>
public class GoogleServiceAccountKeyDataSource : TerraformDataSource
{
    public GoogleServiceAccountKeyDataSource(string name) : base("google_service_account_key", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_key_type attribute.
    /// </summary>
    [TerraformPropertyName("public_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicKeyType { get; set; }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("key_algorithm")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KeyAlgorithm => new TerraformReference(this, "key_algorithm");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicKey => new TerraformReference(this, "public_key");

}
