using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_binary_authorization_attestor_iam_policy resource.
/// </summary>
public partial class GoogleBinaryAuthorizationAttestorIamPolicy : TerraformResource
{
    public GoogleBinaryAuthorizationAttestorIamPolicy(string name) : base("google_binary_authorization_attestor_iam_policy", name)
    {
    }

    /// <summary>
    /// The attestor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attestor is required")]
    [TerraformProperty("attestor")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Attestor { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    [TerraformProperty("policy_data")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PolicyData { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

}
