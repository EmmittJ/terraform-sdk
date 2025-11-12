using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_actions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleClouddeployCustomTargetTypeCustomActionsBlock() : TerraformBlock("custom_actions")
{
    /// <summary>
    /// The Skaffold custom action responsible for deploy operations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeployAction is required")]
    [TerraformProperty("deploy_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeployAction { get; set; }

    /// <summary>
    /// The Skaffold custom action responsible for render operations. If not provided then Cloud Deploy will perform the render operations via &#39;skaffold render&#39;.
    /// </summary>
    [TerraformProperty("render_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RenderAction { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleClouddeployCustomTargetTypeTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_clouddeploy_custom_target_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleClouddeployCustomTargetType : TerraformResource
{
    public GoogleClouddeployCustomTargetType(string name) : base("google_clouddeploy_custom_target_type", name)
    {
    }

    /// <summary>
    /// User annotations. These attributes can only be set and used by the user, and not by Cloud Deploy. See https://google.aip.dev/128#annotations for more details such as format and size limitations.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// Description of the &#39;CustomTargetType&#39;. Max length is 255 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Labels are attributes that can be set and used by both the user and by Cloud Deploy. Labels must meet the following constraints: * Keys and values can contain only lowercase letters, numeric characters, underscores, and dashes. * All characters must use UTF-8 encoding, and international characters are allowed. * Keys must start with a lowercase letter or international character. * Each resource is limited to a maximum of 64 labels. Both keys and values are additionally constrained to be &amp;lt;= 128 bytes.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the source.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of the &#39;CustomTargetType&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for custom_actions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomActions block(s) allowed")]
    [TerraformProperty("custom_actions")]
    public TerraformList<GoogleClouddeployCustomTargetTypeCustomActionsBlock> CustomActions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleClouddeployCustomTargetTypeTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Time at which the &#39;CustomTargetType&#39; was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Resource id of the &#39;CustomTargetType&#39;.
    /// </summary>
    [TerraformProperty("custom_target_type_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomTargetTypeId { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The weak etag of the &#39;CustomTargetType&#39; resource. This checksum is computed by the server based on the value of other fields, and may be sent on update and delete requests to ensure the client has an up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Unique identifier of the &#39;CustomTargetType&#39;.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Time at which the &#39;CustomTargetType&#39; was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
