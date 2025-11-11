using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_secret.
/// </summary>
public partial class GoogleSecretManagerSecretDataSource : TerraformDataSource
{
    public GoogleSecretManagerSecretDataSource(string name) : base("google_secret_manager_secret", name)
    {
    }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    [TerraformProperty("secret_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecretId { get; set; }

    /// <summary>
    /// Custom metadata about the secret.
    /// 
    /// Annotations are distinct from various forms of labels. Annotations exist to allow
    /// client tools to store their own state information without requiring a database.
    /// 
    /// Annotation keys must be between 1 and 63 characters long, have a UTF-8 encoding of
    /// maximum 128 bytes, begin and end with an alphanumeric character ([a-z0-9A-Z]), and
    /// may have dashes (-), underscores (_), dots (.), and alphanumerics in between these
    /// symbols.
    /// 
    /// The total size of annotation keys and values must be less than 16KiB.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Annotations { get; }

    /// <summary>
    /// The time at which the Secret was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the secret. Defaults to false.
    /// When the field is set to true in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the secret will fail.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

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
    /// Timestamp in UTC when the Secret is scheduled to expire. This is always provided on output, regardless of what was sent on input.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// Only one of &#39;expire_time&#39; or &#39;ttl&#39; can be provided.
    /// </summary>
    [TerraformProperty("expire_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpireTime { get; }

    /// <summary>
    /// The labels assigned to this Secret.
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
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The resource name of the Secret. Format:
    /// &#39;projects/{{project}}/secrets/{{secret_id}}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The replication policy of the secret data attached to the Secret. It cannot be changed
    /// after the Secret has been created.
    /// </summary>
    [TerraformProperty("replication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Replication { get; }

    /// <summary>
    /// The rotation time and period for a Secret. At &#39;next_rotation_time&#39;, Secret Manager will send a Pub/Sub notification to the topics configured on the Secret. &#39;topics&#39; must be set to configure rotation.
    /// </summary>
    [TerraformProperty("rotation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Rotation { get; }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// A list of up to 10 Pub/Sub topics to which messages are published when control plane operations are called on the secret or its versions.
    /// </summary>
    [TerraformProperty("topics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Topics { get; }

    /// <summary>
    /// The TTL for the Secret.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// Only one of &#39;ttl&#39; or &#39;expire_time&#39; can be provided.
    /// </summary>
    [TerraformProperty("ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ttl { get; }

    /// <summary>
    /// Mapping from version alias to version name.
    /// 
    /// A version alias is a string with a maximum length of 63 characters and can contain
    /// uppercase and lowercase letters, numerals, and the hyphen (-) and underscore (&#39;_&#39;)
    /// characters. An alias string must start with a letter and cannot be the string
    /// &#39;latest&#39; or &#39;NEW&#39;. No more than 50 aliases can be assigned to a given secret.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("version_aliases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> VersionAliases { get; }

    /// <summary>
    /// Secret Version TTL after destruction request.
    /// This is a part of the delayed delete feature on Secret Version.
    /// For secret with versionDestroyTtl&amp;gt;0, version destruction doesn&#39;t happen immediately
    /// on calling destroy instead the version goes to a disabled state and
    /// the actual destruction happens after this TTL expires.
    /// </summary>
    [TerraformProperty("version_destroy_ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionDestroyTtl { get; }

}
