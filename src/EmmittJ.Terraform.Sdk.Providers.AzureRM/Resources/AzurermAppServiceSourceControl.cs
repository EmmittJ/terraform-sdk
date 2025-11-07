using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_source_control resource.
/// </summary>
public class AzurermAppServiceSourceControl : TerraformResource
{
    public AzurermAppServiceSourceControl(string name) : base("azurerm_app_service_source_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("scm_type");
        this.DeclareOutput("uses_github_action");
    }

    /// <summary>
    /// The ID of the Windows or Linux Web App.
    /// </summary>
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The branch name to use for deployments.
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
    /// The URL for the repository.
    /// </summary>
    public TerraformProperty<string>? RepoUrl
    {
        get => GetProperty<TerraformProperty<string>>("repo_url");
        set => this.WithProperty("repo_url", value);
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    public TerraformProperty<bool>? RollbackEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rollback_enabled");
        set => this.WithProperty("rollback_enabled", value);
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    public TerraformProperty<bool>? UseLocalGit
    {
        get => GetProperty<TerraformProperty<bool>>("use_local_git");
        set => this.WithProperty("use_local_git", value);
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
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
