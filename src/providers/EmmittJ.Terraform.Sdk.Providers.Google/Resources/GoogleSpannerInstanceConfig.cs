using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for replicas in .
/// Nesting mode: set
/// </summary>
public partial class GoogleSpannerInstanceConfigReplicasBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, this location is designated as the default leader location where
    /// leader replicas are placed.
    /// </summary>
    [TerraformProperty("default_leader_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultLeaderLocation { get; set; }

    /// <summary>
    /// The location of the serving resources, e.g. &amp;quot;us-central1&amp;quot;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Indicates the type of replica.  See the [replica types
    /// documentation](https://cloud.google.com/spanner/docs/replication#replica_types)
    /// for more details. Possible values: [&amp;quot;READ_WRITE&amp;quot;, &amp;quot;READ_ONLY&amp;quot;, &amp;quot;WITNESS&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleSpannerInstanceConfigTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_spanner_instance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSpannerInstanceConfig : TerraformResource
{
    public GoogleSpannerInstanceConfig(string name) : base("google_spanner_instance_config", name)
    {
    }

    /// <summary>
    /// Base configuration name, e.g. nam3, based on which this configuration is created.
    /// Only set for user managed configurations.
    /// baseConfig must refer to a configuration of type GOOGLE_MANAGED in the same project as this configuration.
    /// </summary>
    [TerraformProperty("base_config")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BaseConfig { get; set; }

    /// <summary>
    /// The name of this instance configuration as it appears in UIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// A unique identifier for the instance configuration. Values are of the
    /// form projects/&amp;lt;project&amp;gt;/instanceConfigs/[a-z][-a-z0-9]*
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for replicas.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replicas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replicas block(s) required")]
    [TerraformProperty("replicas")]
    public partial TerraformSet<TerraformBlock<GoogleSpannerInstanceConfigReplicasBlock>>? Replicas { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleSpannerInstanceConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Whether this instance config is a Google or User Managed Configuration.
    /// </summary>
    [TerraformProperty("config_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConfigType { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
