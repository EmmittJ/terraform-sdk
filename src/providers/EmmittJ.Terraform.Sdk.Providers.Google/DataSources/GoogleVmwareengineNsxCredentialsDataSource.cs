using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_nsx_credentials.
/// </summary>
public class GoogleVmwareengineNsxCredentialsDataSource : TerraformDataSource
{
    public GoogleVmwareengineNsxCredentialsDataSource(string name) : base("google_vmwareengine_nsx_credentials", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The resource name of the private cloud which contains NSX.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Initial password.
    /// </summary>
    [TerraformPropertyName("password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Password => new TerraformReference(this, "password");

    /// <summary>
    /// Initial username.
    /// </summary>
    [TerraformPropertyName("username")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Username => new TerraformReference(this, "username");

}
