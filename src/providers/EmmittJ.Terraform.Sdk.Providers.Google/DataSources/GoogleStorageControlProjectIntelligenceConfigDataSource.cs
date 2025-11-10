using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_project_intelligence_config.
/// </summary>
public class GoogleStorageControlProjectIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlProjectIntelligenceConfigDataSource(string name) : base("google_storage_control_project_intelligence_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("edition_config");
        this.WithOutput("effective_intelligence_config");
        this.WithOutput("filter");
        this.WithOutput("trial_config");
        this.WithOutput("update_time");
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
    /// Identifier of the GCP project. For GCP project, this field can be project name or project number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    public TerraformExpression EditionConfig => this["edition_config"];

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformExpression EffectiveIntelligenceConfig => this["effective_intelligence_config"];

    /// <summary>
    /// Filter over location and bucket using include or exclude semantics. Resources that match the include or exclude filter are exclusively included or excluded from the Storage Intelligence plan.
    /// </summary>
    public TerraformExpression Filter => this["filter"];

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformExpression TrialConfig => this["trial_config"];

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
