using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_key_handles.
/// </summary>
public partial class GoogleKmsKeyHandlesDataSource : TerraformDataSource
{
    public GoogleKmsKeyHandlesDataSource(string name) : base("google_kms_key_handles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// 
    /// 					The resource_type_selector argument is used to add a filter query parameter that limits which key handles are retrieved by the data source: ?filter=resource_type_selector=&amp;quot;{{resource_type_selector}}&amp;quot;.
    /// 					Example values:
    /// 					* resource_type_selector=&amp;quot;{SERVICE}.googleapis.com/{TYPE}&amp;quot;.
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyHandles/list)
    /// 				
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    [TerraformProperty("resource_type_selector")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceTypeSelector { get; set; }

    /// <summary>
    /// A list of all the retrieved key handles
    /// </summary>
    [TerraformProperty("key_handles")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> KeyHandles { get; }

}
