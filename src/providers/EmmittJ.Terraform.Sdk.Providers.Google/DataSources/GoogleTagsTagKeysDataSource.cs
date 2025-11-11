using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_keys.
/// </summary>
public partial class GoogleTagsTagKeysDataSource : TerraformDataSource
{
    public GoogleTagsTagKeysDataSource(string name) : base("google_tags_tag_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The keys attribute.
    /// </summary>
    [TerraformProperty("keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Keys { get; }

}
