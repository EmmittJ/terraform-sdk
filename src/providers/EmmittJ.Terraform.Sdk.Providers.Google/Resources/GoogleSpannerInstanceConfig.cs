using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for replicas in .
/// Nesting mode: set
/// </summary>
public class GoogleSpannerInstanceConfigReplicasBlock : ITerraformBlock
{
    /// <summary>
    /// If true, this location is designated as the default leader location where
    /// leader replicas are placed.
    /// </summary>
    [TerraformPropertyName("default_leader_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultLeaderLocation { get; set; }

    /// <summary>
    /// The location of the serving resources, e.g. &amp;quot;us-central1&amp;quot;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Indicates the type of replica.  See the [replica types
    /// documentation](https://cloud.google.com/spanner/docs/replication#replica_types)
    /// for more details. Possible values: [&amp;quot;READ_WRITE&amp;quot;, &amp;quot;READ_ONLY&amp;quot;, &amp;quot;WITNESS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceConfigTimeoutsBlock : ITerraformBlock
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
/// Manages a google_spanner_instance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerInstanceConfig : TerraformResource
{
    public GoogleSpannerInstanceConfig(string name) : base("google_spanner_instance_config", name)
    {
    }

    /// <summary>
    /// Base configuration name, e.g. nam3, based on which this configuration is created.
    /// Only set for user managed configurations.
    /// baseConfig must refer to a configuration of type GOOGLE_MANAGED in the same project as this configuration.
    /// </summary>
    [TerraformPropertyName("base_config")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BaseConfig { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "base_config");

    /// <summary>
    /// The name of this instance configuration as it appears in UIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// A unique identifier for the instance configuration. Values are of the
    /// form projects/&amp;lt;project&amp;gt;/instanceConfigs/[a-z][-a-z0-9]*
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for replicas.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replicas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replicas block(s) required")]
    [TerraformPropertyName("replicas")]
    public TerraformSet<TerraformBlock<GoogleSpannerInstanceConfigReplicasBlock>>? Replicas { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSpannerInstanceConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Whether this instance config is a Google or User Managed Configuration.
    /// </summary>
    [TerraformPropertyName("config_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_type");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
