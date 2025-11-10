using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a google_spanner_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerInstance : TerraformResource
{
    public GoogleSpannerInstance(string name) : base("google_spanner_instance", name)
    {
    }

    /// <summary>
    /// The name of the instance&#39;s configuration (similar but not
    /// quite the same as a region) which defines the geographic placement and
    /// replication of your databases in this instance. It determines where your data
    /// is stored. Values are typically of the form &#39;regional-europe-west1&#39; , &#39;us-central&#39; etc.
    /// In order to obtain a valid list please consult the
    /// [Configuration section of the docs](https://cloud.google.com/spanner/docs/instances).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Config is required")]
    [TerraformPropertyName("config")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Config { get; set; }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that &#39;AUTOMATIC&#39; is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("default_backup_schedule_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultBackupScheduleType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_backup_schedule_type");

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points. Possible values: [&amp;quot;EDITION_UNSPECIFIED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Edition { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition");

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field &#39;edition&#39; should not be configured. Possible values: [&amp;quot;PROVISIONED&amp;quot;, &amp;quot;FREE_INSTANCE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_type");

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
    /// A unique identifier for the instance, which cannot be changed after
    /// the instance is created. The name must be between 6 and 30 characters
    /// in length.
    /// If not provided, a random string starting with &#39;tf-&#39; will be selected.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The number of nodes allocated to this instance. Exactly one of either num_nodes, processing_units or
    /// autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    [TerraformPropertyName("num_nodes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> NumNodes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "num_nodes");

    /// <summary>
    /// The number of processing units allocated to this instance. Exactly one of either num_nodes,
    /// processing_units or autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    [TerraformPropertyName("processing_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> ProcessingUnits { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "processing_units");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for autoscaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    [TerraformPropertyName("autoscaling_config")]
    public TerraformList<TerraformBlock<GoogleSpannerInstanceAutoscalingConfigBlock>>? AutoscalingConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleSpannerInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Instance status: &#39;CREATING&#39; or &#39;READY&#39;.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
