using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiTimeoutsBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_api resource.
/// </summary>
public class GoogleApigeeApi : TerraformResource
{
    public GoogleApigeeApi(string name) : base("google_apigee_api", name)
    {
    }

    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigBundle is required")]
    [TerraformPropertyName("config_bundle")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConfigBundle { get; set; }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    [TerraformPropertyName("detect_md5hash")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DetectMd5hash { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the API proxy. This field only accepts the following characters: A-Za-z0-9._-.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeApiTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The id of the most recently created revision for this API proxy.
    /// </summary>
    [TerraformPropertyName("latest_revision_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestRevisionId => new TerraformReference(this, "latest_revision_id");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    [TerraformPropertyName("md5hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Md5hash => new TerraformReference(this, "md5hash");

    /// <summary>
    /// Metadata describing the API proxy.
    /// </summary>
    [TerraformPropertyName("meta_data")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MetaData => new TerraformReference(this, "meta_data");

    /// <summary>
    /// A list of revisions of this API proxy.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Revision => new TerraformReference(this, "revision");

}
