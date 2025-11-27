using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for replicas in GoogleSpannerInstanceConfig.
/// Nesting mode: set
/// </summary>
public class GoogleSpannerInstanceConfigReplicasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replicas";

    /// <summary>
    /// If true, this location is designated as the default leader location where
    /// leader replicas are placed.
    /// </summary>
    public TerraformValue<bool>? DefaultLeaderLocation
    {
        get => new TerraformReference<bool>(this, "default_leader_location");
        set => SetArgument("default_leader_location", value);
    }

    /// <summary>
    /// The location of the serving resources, e.g. &amp;quot;us-central1&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Indicates the type of replica.  See the [replica types
    /// documentation](https://cloud.google.com/spanner/docs/replication#replica_types)
    /// for more details. Possible values: [&amp;quot;READ_WRITE&amp;quot;, &amp;quot;READ_ONLY&amp;quot;, &amp;quot;WITNESS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleSpannerInstanceConfig.
/// Nesting mode: single
/// </summary>
public class GoogleSpannerInstanceConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_spanner_instance_config Terraform resource.
/// Manages a google_spanner_instance_config resource.
/// </summary>
public partial class GoogleSpannerInstanceConfig(string name) : TerraformResource("google_spanner_instance_config", name)
{
    /// <summary>
    /// Base configuration name, e.g. nam3, based on which this configuration is created.
    /// Only set for user managed configurations.
    /// baseConfig must refer to a configuration of type GOOGLE_MANAGED in the same project as this configuration.
    /// </summary>
    public TerraformValue<string> BaseConfig
    {
        get => new TerraformReference<string>(this, "base_config");
        set => SetArgument("base_config", value);
    }

    /// <summary>
    /// The name of this instance configuration as it appears in UIs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// A unique identifier for the instance configuration. Values are of the
    /// form projects/&amp;lt;project&amp;gt;/instanceConfigs/[a-z][-a-z0-9]*
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Output only. Whether this instance config is a Google or User Managed Configuration.
    /// </summary>
    public TerraformValue<string> ConfigType
    {
        get => new TerraformReference<string>(this, "config_type");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Replicas block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replicas is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replicas block(s) required")]
    public required TerraformSet<GoogleSpannerInstanceConfigReplicasBlock> Replicas
    {
        get => GetRequiredArgument<TerraformSet<GoogleSpannerInstanceConfigReplicasBlock>>("replicas");
        set => SetArgument("replicas", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSpannerInstanceConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSpannerInstanceConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
