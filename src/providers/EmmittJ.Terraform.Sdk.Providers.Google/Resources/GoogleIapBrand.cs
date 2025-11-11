using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIapBrandTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_iap_brand resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleIapBrand : TerraformResource
{
    public GoogleIapBrand(string name) : base("google_iap_brand", name)
    {
    }

    /// <summary>
    /// Application name displayed on OAuth consent screen.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationTitle is required")]
    [TerraformPropertyName("application_title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationTitle { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Support email displayed on the OAuth consent screen. Can be either a
    /// user or group email. When a user email is specified, the caller must
    /// be the user with the associated email address. When a group email is
    /// specified, the caller can be either a user or a service account which
    /// is an owner of the specified group in Cloud Identity.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportEmail is required")]
    [TerraformPropertyName("support_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SupportEmail { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIapBrandTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Identifier of the brand, in the format &#39;projects/{project_number}/brands/{brand_id}&#39;
    /// NOTE: The name can also be expressed as &#39;projects/{project_id}/brands/{brand_id}&#39;, e.g. when importing.
    /// NOTE: The brand identification corresponds to the project number as only one
    /// brand can be created per project.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Whether the brand is only intended for usage inside the GSuite organization only.
    /// </summary>
    [TerraformPropertyName("org_internal_only")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> OrgInternalOnly => new TerraformReference(this, "org_internal_only");

}
