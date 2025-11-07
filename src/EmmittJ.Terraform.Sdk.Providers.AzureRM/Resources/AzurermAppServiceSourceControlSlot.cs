using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_source_control_slot resource.
/// </summary>
public class AzurermAppServiceSourceControlSlot : TerraformResource
{
    public AzurermAppServiceSourceControlSlot(string name) : base("azurerm_app_service_source_control_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("scm_type");
        this.DeclareOutput("uses_github_action");
    }

    /// <summary>
    /// The URL for the repository
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => this.WithProperty("branch", value);
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
    /// The branch name to use for deployments.
    /// </summary>
    public TerraformProperty<string>? RepoUrl
    {
        get => GetProperty<TerraformProperty<string>>("repo_url");
        set => this.WithProperty("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? RollbackEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rollback_enabled");
        set => this.WithProperty("rollback_enabled", value);
    }

    /// <summary>
    /// The ID of the Linux or Windows Web App Slot.
    /// </summary>
    public TerraformProperty<string>? SlotId
    {
        get => GetProperty<TerraformProperty<string>>("slot_id");
        set => this.WithProperty("slot_id", value);
    }

    /// <summary>
    /// Should the Slot use local Git configuration.
    /// </summary>
    public TerraformProperty<bool>? UseLocalGit
    {
        get => GetProperty<TerraformProperty<bool>>("use_local_git");
        set => this.WithProperty("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `true` to disable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`
    /// </summary>
    public TerraformProperty<bool>? UseManualIntegration
    {
        get => GetProperty<TerraformProperty<bool>>("use_manual_integration");
        set => this.WithProperty("use_manual_integration", value);
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? UseMercurial
    {
        get => GetProperty<TerraformProperty<bool>>("use_mercurial");
        set => this.WithProperty("use_mercurial", value);
    }

    /// <summary>
    /// The SCM Type in use. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformExpression ScmType => this["scm_type"];

    /// <summary>
    /// Indicates if the Slot uses a GitHub action for deployment. This value is decoded by the service from the repository information supplied.
    /// </summary>
    public TerraformExpression UsesGithubAction => this["uses_github_action"];

}
