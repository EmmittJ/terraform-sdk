using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for autoscaling_config in .
/// Nesting mode: list
/// </summary>
public class GoogleSpannerInstanceAutoscalingConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_spanner_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerInstance : TerraformResource
{
    public GoogleSpannerInstance(string name) : base("google_spanner_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
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
    public required TerraformProperty<string> Config
    {
        get => GetRequiredProperty<TerraformProperty<string>>("config");
        set => this.WithProperty("config", value);
    }

    /// <summary>
    /// Controls the default backup behavior for new databases within the instance.
    /// Note that &#39;AUTOMATIC&#39; is not permitted for free instances, as backups and backup schedules are not allowed for free instances.
    /// if unset or NONE, no default backup schedule will be created for new databases within the instance. Possible values: [&amp;quot;NONE&amp;quot;, &amp;quot;AUTOMATIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DefaultBackupScheduleType
    {
        get => GetProperty<TerraformProperty<string>>("default_backup_schedule_type");
        set => this.WithProperty("default_backup_schedule_type", value);
    }

    /// <summary>
    /// The descriptive name for this instance as it appears in UIs. Must be
    /// unique per project and between 4 and 30 characters in length.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The edition selected for this instance. Different editions provide different capabilities at different price points. Possible values: [&amp;quot;EDITION_UNSPECIFIED&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;ENTERPRISE_PLUS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Edition
    {
        get => GetProperty<TerraformProperty<string>>("edition");
        set => this.WithProperty("edition", value);
    }

    /// <summary>
    /// When deleting a spanner instance, this boolean option will delete all backups of this instance.
    /// This must be set to true if you created a backup manually in the console.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The type of this instance. The type can be used to distinguish product variants, that can affect aspects like:
    /// usage restrictions, quotas and billing. Currently this is used to distinguish FREE_INSTANCE vs PROVISIONED instances.
    /// When configured as FREE_INSTANCE, the field &#39;edition&#39; should not be configured. Possible values: [&amp;quot;PROVISIONED&amp;quot;, &amp;quot;FREE_INSTANCE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// A unique identifier for the instance, which cannot be changed after
    /// the instance is created. The name must be between 6 and 30 characters
    /// in length.
    /// If not provided, a random string starting with &#39;tf-&#39; will be selected.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The number of nodes allocated to this instance. Exactly one of either num_nodes, processing_units or
    /// autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    public TerraformProperty<double>? NumNodes
    {
        get => GetProperty<TerraformProperty<double>>("num_nodes");
        set => this.WithProperty("num_nodes", value);
    }

    /// <summary>
    /// The number of processing units allocated to this instance. Exactly one of either num_nodes,
    /// processing_units or autoscaling_config must be present in terraform except when instance_type = FREE_INSTANCE.
    /// </summary>
    public TerraformProperty<double>? ProcessingUnits
    {
        get => GetProperty<TerraformProperty<double>>("processing_units");
        set => this.WithProperty("processing_units", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for autoscaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public List<GoogleSpannerInstanceAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetProperty<List<GoogleSpannerInstanceAutoscalingConfigBlock>>("autoscaling_config");
        set => this.WithProperty("autoscaling_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSpannerInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSpannerInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Instance status: &#39;CREATING&#39; or &#39;READY&#39;.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
