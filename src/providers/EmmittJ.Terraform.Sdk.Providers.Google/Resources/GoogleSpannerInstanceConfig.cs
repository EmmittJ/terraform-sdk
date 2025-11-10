using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for replicas in .
/// Nesting mode: set
/// </summary>
public class GoogleSpannerInstanceConfigReplicasBlock : TerraformBlock
{
    /// <summary>
    /// If true, this location is designated as the default leader location where
    /// leader replicas are placed.
    /// </summary>
    public TerraformProperty<bool>? DefaultLeaderLocation
    {
        set => SetProperty("default_leader_location", value);
    }

    /// <summary>
    /// The location of the serving resources, e.g. &amp;quot;us-central1&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Indicates the type of replica.  See the [replica types
    /// documentation](https://cloud.google.com/spanner/docs/replication#replica_types)
    /// for more details. Possible values: [&amp;quot;READ_WRITE&amp;quot;, &amp;quot;READ_ONLY&amp;quot;, &amp;quot;WITNESS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_spanner_instance_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleSpannerInstanceConfig : TerraformResource
{
    public GoogleSpannerInstanceConfig(string name) : base("google_spanner_instance_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("config_type");
        SetOutput("effective_labels");
        SetOutput("terraform_labels");
        SetOutput("base_config");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// Base configuration name, e.g. nam3, based on which this configuration is created.
    /// Only set for user managed configurations.
    /// baseConfig must refer to a configuration of type GOOGLE_MANAGED in the same project as this configuration.
    /// </summary>
    public TerraformProperty<string> BaseConfig
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_config");
        set => SetProperty("base_config", value);
    }

    /// <summary>
    /// The name of this instance configuration as it appears in UIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// A unique identifier for the instance configuration. Values are of the
    /// form projects/&amp;lt;project&amp;gt;/instanceConfigs/[a-z][-a-z0-9]*
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for replicas.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replicas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replicas block(s) required")]
    public HashSet<GoogleSpannerInstanceConfigReplicasBlock>? Replicas
    {
        set => SetProperty("replicas", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSpannerInstanceConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Whether this instance config is a Google or User Managed Configuration.
    /// </summary>
    public TerraformExpression ConfigType => this["config_type"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
