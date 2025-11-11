using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_testable_permissions.
/// </summary>
public class GoogleIamTestablePermissionsDataSource : TerraformDataSource
{
    public GoogleIamTestablePermissionsDataSource(string name) : base("google_iam_testable_permissions", name)
    {
    }

    /// <summary>
    /// The custom_support_level attribute.
    /// </summary>
    [TerraformPropertyName("custom_support_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomSupportLevel { get; set; }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullResourceName is required")]
    [TerraformPropertyName("full_resource_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FullResourceName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The stages attribute.
    /// </summary>
    [TerraformPropertyName("stages")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Stages { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [TerraformPropertyName("permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Permissions => new TerraformReference(this, "permissions");

}
