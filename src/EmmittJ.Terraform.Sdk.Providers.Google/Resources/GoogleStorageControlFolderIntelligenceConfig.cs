using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for filter in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigFilterBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_storage_control_folder_intelligence_config resource.
/// </summary>
public class GoogleStorageControlFolderIntelligenceConfig : TerraformResource
{
    public GoogleStorageControlFolderIntelligenceConfig(string name) : base("google_storage_control_folder_intelligence_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_intelligence_config");
        this.DeclareOutput("trial_config");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Edition configuration of the Storage Intelligence resource. Valid values are INHERIT, TRIAL, DISABLED and STANDARD.
    /// </summary>
    public TerraformProperty<string>? EditionConfig
    {
        get => GetProperty<TerraformProperty<string>>("edition_config");
        set => this.WithProperty("edition_config", value);
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
    /// Identifier of the GCP Folder. For GCP Folder, this field can be folder number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public List<GoogleStorageControlFolderIntelligenceConfigFilterBlock>? Filter
    {
        get => GetProperty<List<GoogleStorageControlFolderIntelligenceConfigFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageControlFolderIntelligenceConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The Intelligence config that is effective for the resource.
    /// </summary>
    public TerraformExpression EffectiveIntelligenceConfig => this["effective_intelligence_config"];

    /// <summary>
    /// The trial configuration of the Storage Intelligence resource.
    /// </summary>
    public TerraformExpression TrialConfig => this["trial_config"];

    /// <summary>
    /// The time at which the Storage Intelligence Config resource is last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
