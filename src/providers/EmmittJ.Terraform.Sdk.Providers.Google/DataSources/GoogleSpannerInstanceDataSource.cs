using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_spanner_instance.
/// </summary>
public class GoogleSpannerInstanceDataSource : TerraformDataSource
{
    public GoogleSpannerInstanceDataSource(string name) : base("google_spanner_instance", name)
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
    [TerraformPropertyName("config")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Config { get; set; }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A unique identifier for the instance, which cannot be changed after
    /// the instance is created. The name must be between 6 and 30 characters
    /// in length.
    /// If not provided, a random string starting with &#39;tf-&#39; will be selected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The autoscaling configuration. Autoscaling is enabled if this field is set.
    /// Exactly one of either num_nodes, processing_units or autoscaling_config must be
    /// present in terraform except when instance_type = FREE_INSTANCE.
    /// When autoscaling is enabled, num_nodes and processing_units are treated as,
    /// OUTPUT_ONLY fields and reflect the current compute capacity allocated to
    /// the instance.
    /// </summary>
    [TerraformPropertyName("autoscaling_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoscalingConfig => new TerraformReference(this, "autoscaling_config");

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that &#39;AUTOMATIC&#39; is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("default_backup_schedule_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultBackupScheduleType => new TerraformReference(this, "default_backup_schedule_type");

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points. Possible values: [&amp;quot;EDITION_UNSPECIFIED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("edition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Edition => new TerraformReference(this, "edition");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ForceDestroy => new TerraformReference(this, "force_destroy");

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field &#39;edition&#39; should not be configured. Possible values: [&amp;quot;PROVISIONED&amp;quot;, &amp;quot;FREE_INSTANCE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceType => new TerraformReference(this, "instance_type");

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The number of nodes allocated to this instance. Exactly one of either num_nodes, processing_units or
    /// autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    [TerraformPropertyName("num_nodes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> NumNodes => new TerraformReference(this, "num_nodes");

    /// <summary>
    /// The number of processing units allocated to this instance. Exactly one of either num_nodes,
    /// processing_units or autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    [TerraformPropertyName("processing_units")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProcessingUnits => new TerraformReference(this, "processing_units");

    /// <summary>
    /// Instance status: &#39;CREATING&#39; or &#39;READY&#39;.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
