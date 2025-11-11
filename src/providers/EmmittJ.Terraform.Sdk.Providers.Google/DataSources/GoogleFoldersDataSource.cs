using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folders.
/// </summary>
public partial class GoogleFoldersDataSource : TerraformDataSource
{
    public GoogleFoldersDataSource(string name) : base("google_folders", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformProperty("parent_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    [TerraformProperty("folders")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Folders { get; }

}
