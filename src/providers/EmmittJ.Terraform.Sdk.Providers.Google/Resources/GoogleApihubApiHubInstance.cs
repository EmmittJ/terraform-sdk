using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for config in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubApiHubInstanceConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. The Customer Managed Encryption Key (CMEK) used for data encryption.
    /// The CMEK name should follow the format of
    /// &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;,
    /// where the location must match the instance location.
    /// If the CMEK is not provided, a GMEK will be created for the instance.
    /// </summary>
    [TerraformPropertyName("cmek_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CmekKeyName { get; set; }

    /// <summary>
    /// Optional. If true, the search will be disabled for the instance. The default value
    /// is false.
    /// </summary>
    [TerraformPropertyName("disable_search")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableSearch { get; set; }

    /// <summary>
    /// Optional. Encryption type for the region. If the encryption type is CMEK, the
    /// cmek_key_name must be provided. If no encryption type is provided,
    /// GMEK will be used.
    /// Possible values:
    /// ENCRYPTION_TYPE_UNSPECIFIED
    /// GMEK
    /// CMEK
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EncryptionType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "encryption_type");

    /// <summary>
    /// Optional. The name of the Vertex AI location where the data store is stored.
    /// </summary>
    [TerraformPropertyName("vertex_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VertexLocation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubApiHubInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a google_apihub_api_hub_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubApiHubInstance : TerraformResource
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
    [TerraformPropertyName("api_hub_instance_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiHubInstanceId { get; set; }

    /// <summary>
    /// Optional. Description of the ApiHub instance.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Optional. Instance labels to represent user-provided metadata.
    /// Refer to cloud documentation on labels for more details.
    /// https://cloud.google.com/compute/docs/labeling-resources
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Config block(s) allowed")]
    [TerraformPropertyName("config")]
    public TerraformList<TerraformBlock<GoogleApihubApiHubInstanceConfigBlock>>? Config { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApihubApiHubInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Creation timestamp.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Identifier. Format:
    /// &#39;projects/{project}/locations/{location}/apiHubInstances/{apiHubInstance}&#39;.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Output only. Extra information about ApiHub instance state. Currently the message
    /// would be populated when state is &#39;FAILED&#39;.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Output only. Last update timestamp.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
