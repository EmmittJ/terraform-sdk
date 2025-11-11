using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_values.
/// </summary>
public partial class GoogleTagsTagValuesDataSource : TerraformDataSource
{
    public GoogleTagsTagValuesDataSource(string name) : base("google_tags_tag_values", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformProperty("values")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Values { get; }

}
