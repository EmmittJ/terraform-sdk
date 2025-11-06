using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_control_folder_intelligence_config.
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigDataSource : TerraformDataSource
{
    public GoogleStorageControlFolderIntelligenceConfigDataSource(string name) : base("google_storage_control_folder_intelligence_config", name)
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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Identifier of the GCP Folder. For GCP Folder, this field can be folder number.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
