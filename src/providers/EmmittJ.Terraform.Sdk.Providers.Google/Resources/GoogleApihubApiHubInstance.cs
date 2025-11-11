using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubApiHubInstanceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. The Customer Managed Encryption Key (CMEK) used for data encryption.
    /// The CMEK name should follow the format of
    /// &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;,
    /// where the location must match the instance location.
    /// If the CMEK is not provided, a GMEK will be created for the instance.
    /// </summary>
    [TerraformProperty("cmek_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CmekKeyName { get; set; }

    /// <summary>
    /// Optional. If true, the search will be disabled for the instance. The default value
    /// is false.
    /// </summary>
    [TerraformProperty("disable_search")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableSearch { get; set; }

    /// <summary>
    /// Optional. Encryption type for the region. If the encryption type is CMEK, the
    /// cmek_key_name must be provided. If no encryption type is provided,
    /// GMEK will be used.
    /// Possible values:
    /// ENCRYPTION_TYPE_UNSPECIFIED
    /// GMEK
    /// CMEK
    /// </summary>
    [TerraformProperty("encryption_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EncryptionType { get; set; }

    /// <summary>
    /// Optional. The name of the Vertex AI location where the data store is stored.
    /// </summary>
    [TerraformProperty("vertex_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VertexLocation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApihubApiHubInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_apihub_api_hub_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApihubApiHubInstance : TerraformResource
{
    public GoogleApihubApiHubInstance(string name) : base("google_apihub_api_hub_instance", name)
    {
    }

    /// <summary>
    /// Optional. Identifier to assign to the Api Hub instance. Must be unique within
    /// scope of the parent resource. If the field is not provided,
    /// system generated id will be used.
    /// 
    /// This value should be 4-40 characters, and valid characters
    /// are &#39;/a-z[0-9]-_/&#39;.
    /// </summary>
    [TerraformProperty("api_hub_instance_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiHubInstanceId { get; set; }

    /// <summary>
    /// Optional. Description of the ApiHub instance.
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
    /// Optional. Instance labels to represent user-provided metadata.
    /// Refer to cloud documentation on labels for more details.
    /// https://cloud.google.com/compute/docs/labeling-resources
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformProperty("config")]
    public partial TerraformList<TerraformBlock<GoogleApihubApiHubInstanceConfigBlock>>? Config { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApihubApiHubInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Creation timestamp.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Identifier. Format:
    /// &#39;projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}&#39;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The current state of the ApiHub instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// INACTIVE
    /// CREATING
    /// ACTIVE
    /// UPDATING
    /// DELETING
    /// FAILED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Extra information about ApiHub instance state. Currently the message
    /// would be populated when state is &#39;FAILED&#39;.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Output only. Last update timestamp.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
