using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_key_handles.
/// </summary>
public class GoogleKmsKeyHandlesDataSource : TerraformDataSource
{
    public GoogleKmsKeyHandlesDataSource(string name) : base("google_kms_key_handles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// 
    /// 					The resource_type_selector argument is used to add a filter query parameter that limits which key handles are retrieved by the data source: ?filter=resource_type_selector=&amp;quot;{{resource_type_selector}}&amp;quot;.
    /// 					Example values:
    /// 					* resource_type_selector=&amp;quot;{SERVICE}.googleapis.com/{TYPE}&amp;quot;.
    /// 					[See the documentation about using filters](https://cloud.google.com/kms/docs/reference/rest/v1/projects.locations.keyHandles/list)
    /// 				
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeSelector is required")]
    [TerraformPropertyName("resource_type_selector")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceTypeSelector { get; set; }

    /// <summary>
    /// A list of all the retrieved key handles
    /// </summary>
    [TerraformPropertyName("key_handles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> KeyHandles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "key_handles");

}
