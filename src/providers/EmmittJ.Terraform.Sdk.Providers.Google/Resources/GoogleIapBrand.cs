using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIapBrandTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_iap_brand resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleIapBrand : TerraformResource
{
    public GoogleIapBrand(string name) : base("google_iap_brand", name)
    {
    }

    /// <summary>
    /// Application name displayed on OAuth consent screen.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationTitle is required")]
    [TerraformProperty("application_title")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationTitle { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Support email displayed on the OAuth consent screen. Can be either a
    /// user or group email. When a user email is specified, the caller must
    /// be the user with the associated email address. When a group email is
    /// specified, the caller can be either a user or a service account which
    /// is an owner of the specified group in Cloud Identity.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportEmail is required")]
    [TerraformProperty("support_email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SupportEmail { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleIapBrandTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Identifier of the brand, in the format &#39;projects/{project_number}/brands/{brand_id}&#39;
    /// NOTE: The name can also be expressed as &#39;projects/{project_id}/brands/{brand_id}&#39;, e.g. when importing.
    /// NOTE: The brand identification corresponds to the project number as only one
    /// brand can be created per project.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Whether the brand is only intended for usage inside the GSuite organization only.
    /// </summary>
    [TerraformProperty("org_internal_only")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> OrgInternalOnly { get; }

}
