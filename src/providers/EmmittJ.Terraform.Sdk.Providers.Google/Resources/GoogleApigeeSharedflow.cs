using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSharedflowTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_sharedflow resource.
/// </summary>
public class GoogleApigeeSharedflow : TerraformResource
{
    public GoogleApigeeSharedflow(string name) : base("google_apigee_sharedflow", name)
    {
    }

    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigBundle is required")]
    [TerraformPropertyName("config_bundle")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConfigBundle { get; set; }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    [TerraformPropertyName("detect_md5hash")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DetectMd5hash { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the shared flow.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> OrgId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeSharedflowTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The id of the most recently created revision for this shared flow.
    /// </summary>
    [TerraformPropertyName("latest_revision_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRevisionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_revision_id");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    [TerraformPropertyName("md5hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Md5hash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "md5hash");

    /// <summary>
    /// Metadata describing the shared flow.
    /// </summary>
    [TerraformPropertyName("meta_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MetaData => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "meta_data");

    /// <summary>
    /// A list of revisions of this shared flow.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Revision => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "revision");

}
