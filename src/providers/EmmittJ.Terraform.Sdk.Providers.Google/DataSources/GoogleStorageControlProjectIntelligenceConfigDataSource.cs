using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_control_project_intelligence_config Terraform data source.
/// Retrieves information about a google_storage_control_project_intelligence_config.
/// </summary>
public partial class GoogleStorageControlProjectIntelligenceConfigDataSource(string name) : TerraformDataSource("google_storage_control_project_intelligence_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Identifier of the GCP project. For GCP project, this field can be project name or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    public TerraformValue<string> EditionConfig
    {
        get => new TerraformReference<string>(this, "edition_config");
    }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveIntelligenceConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "effective_intelligence_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    public TerraformList<TerraformMap<object>> Filter
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filter").ResolveNodes(ctx));
    }

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trial_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
