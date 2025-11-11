using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_nsx_credentials.
/// </summary>
public partial class GoogleVmwareengineNsxCredentialsDataSource : TerraformDataSource
{
    public GoogleVmwareengineNsxCredentialsDataSource(string name) : base("google_vmwareengine_nsx_credentials", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name of the private cloud which contains NSX.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-west1-a/privateClouds/my-cloud
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Initial password.
    /// </summary>
    [TerraformProperty("password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Password { get; }

    /// <summary>
    /// Initial username.
    /// </summary>
    [TerraformProperty("username")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Username { get; }

}
