using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter.
/// </summary>
public partial class GoogleParameterManagerParameterDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterDataSource(string name) : base("google_parameter_manager_parameter", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterId is required")]
    [TerraformProperty("parameter_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ParameterId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The time at which the Parameter was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The format type of the parameter resource. Default value: &amp;quot;UNFORMATTED&amp;quot; Possible values: [&amp;quot;UNFORMATTED&amp;quot;, &amp;quot;YAML&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformProperty("format")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Format { get; }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey used to encrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}&#39;
    /// </summary>
    [TerraformProperty("kms_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKey { get; }

    /// <summary>
    /// The labels assigned to this Parameter.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// 
    /// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// 
    /// No more than 64 labels can be assigned to a given resource.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The resource name of the Parameter. Format:
    /// &#39;projects/{{project}}/locations/global/parameters/{{parameter_id}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Policy member strings of a Google Cloud resource.
    /// </summary>
    [TerraformProperty("policy_member")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PolicyMember { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time at which the Parameter was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
