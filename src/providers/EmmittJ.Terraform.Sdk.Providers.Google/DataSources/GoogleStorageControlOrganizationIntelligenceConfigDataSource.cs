using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_control_organization_intelligence_config Terraform data source.
/// Retrieves information about a google_storage_control_organization_intelligence_config.
/// </summary>
public partial class GoogleStorageControlOrganizationIntelligenceConfigDataSource(string name) : TerraformDataSource("google_storage_control_organization_intelligence_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
    /// </summary>
    public TerraformValue<string> EditionConfig
        => CreateReference("edition_config");

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveIntelligenceConfig
        => CreateReference("effective_intelligence_config");

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    public TerraformList<TerraformMap<object>> Filter
        => CreateReference("filter");

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialConfig
        => CreateReference("trial_config");

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

}
