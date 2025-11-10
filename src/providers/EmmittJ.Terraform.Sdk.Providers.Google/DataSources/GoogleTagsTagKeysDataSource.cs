using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_keys.
/// </summary>
public class GoogleTagsTagKeysDataSource : TerraformDataSource
{
    public GoogleTagsTagKeysDataSource(string name) : base("google_tags_tag_keys", name)
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
    /// The keys attribute.
    /// </summary>
    [TerraformPropertyName("keys")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Keys => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "keys");

}
