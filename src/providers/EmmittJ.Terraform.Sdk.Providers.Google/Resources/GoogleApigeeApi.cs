using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeApiTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_api resource.
/// </summary>
public partial class GoogleApigeeApi : TerraformResource
{
    public GoogleApigeeApi(string name) : base("google_apigee_api", name)
    {
    }

    /// <summary>
    /// Path to the config zip bundle
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigBundle is required")]
    [TerraformProperty("config_bundle")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ConfigBundle { get; set; }

    /// <summary>
    /// A hash of local config bundle in string, user needs to use a Terraform Hash function of their choice. A change in hash will trigger an update.
    /// </summary>
    [TerraformProperty("detect_md5hash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DetectMd5hash { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the API proxy. This field only accepts the following characters: A-Za-z0-9._-.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization name associated with the Apigee instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApigeeApiTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The id of the most recently created revision for this API proxy.
    /// </summary>
    [TerraformProperty("latest_revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRevisionId { get; }

    /// <summary>
    /// Base 64 MD5 hash of the uploaded config bundle.
    /// </summary>
    [TerraformProperty("md5hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Md5hash { get; }

    /// <summary>
    /// Metadata describing the API proxy.
    /// </summary>
    [TerraformProperty("meta_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MetaData { get; }

    /// <summary>
    /// A list of revisions of this API proxy.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Revision { get; }

}
