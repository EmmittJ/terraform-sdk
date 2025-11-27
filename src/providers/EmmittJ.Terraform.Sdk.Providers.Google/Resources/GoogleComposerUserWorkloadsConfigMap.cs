using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComposerUserWorkloadsConfigMap.
/// Nesting mode: single
/// </summary>
public class GoogleComposerUserWorkloadsConfigMapTimeoutsBlock : TerraformBlock
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
/// Represents a google_composer_user_workloads_config_map Terraform resource.
/// Manages a google_composer_user_workloads_config_map resource.
/// </summary>
public partial class GoogleComposerUserWorkloadsConfigMap(string name) : TerraformResource("google_composer_user_workloads_config_map", name)
{
    /// <summary>
    /// The &amp;quot;data&amp;quot; field of Kubernetes ConfigMap, organized in key-value pairs.
    /// For details see: https://kubernetes.io/docs/concepts/configuration/configmap/
    /// </summary>
    public TerraformMap<string>? Data
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "data").ResolveNodes(ctx));
        set => SetArgument("data", value);
    }

    /// <summary>
    /// Environment where the Kubernetes ConfigMap will be stored and used.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
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
    /// Name of the Kubernetes ConfigMap.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The location or Compute Engine region for the environment.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComposerUserWorkloadsConfigMapTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComposerUserWorkloadsConfigMapTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
