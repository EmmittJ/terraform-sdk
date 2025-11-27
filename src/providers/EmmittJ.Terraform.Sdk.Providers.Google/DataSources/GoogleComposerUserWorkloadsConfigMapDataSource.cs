using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_composer_user_workloads_config_map Terraform data source.
/// Retrieves information about a google_composer_user_workloads_config_map.
/// </summary>
public partial class GoogleComposerUserWorkloadsConfigMapDataSource(string name) : TerraformDataSource("google_composer_user_workloads_config_map", name)
{
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
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The location or Compute Engine region for the environment.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The &amp;quot;data&amp;quot; field of Kubernetes ConfigMap, organized in key-value pairs.
    /// For details see: https://kubernetes.io/docs/concepts/configuration/configmap/
    /// </summary>
    public TerraformMap<string> Data
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "data").ResolveNodes(ctx));
    }

}
