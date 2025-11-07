using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_organization_intelligence_config.
/// </summary>
public class GoogleStorageControlOrganizationIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlOrganizationIntelligenceConfigDataSource(string name) : base("google_storage_control_organization_intelligence_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("edition_config");
        this.DeclareOutput("effective_intelligence_config");
        this.DeclareOutput("filter");
        this.DeclareOutput("trial_config");
        this.DeclareOutput("update_time");
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
    /// Identifier of the GCP Organization. For GCP org, this field should be organization number.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, DISABLED, TRIAL and STANDARD.
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
