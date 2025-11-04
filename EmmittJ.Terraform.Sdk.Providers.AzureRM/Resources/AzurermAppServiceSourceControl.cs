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
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The branch name to use for deployments.
    /// </summary>
    public string? Branch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch")?.Value;
        set => this.WithProperty("branch", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The URL for the repository.
    /// </summary>
    public string? RepoUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repo_url")?.Value;
        set => this.WithProperty("repo_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Should the Deployment Rollback be enabled? Defaults to `false`.
    /// </summary>
    public bool? RollbackEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rollback_enabled")?.Value;
        set => this.WithProperty("rollback_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Should the App use local Git configuration.
    /// </summary>
    public bool? UseLocalGit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_local_git")?.Value;
        set => this.WithProperty("use_local_git", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Should code be deployed manually. Set to `false` to enable continuous integration, such as webhooks into online repos such as GitHub. Defaults to `false`.
    /// </summary>
    public bool? UseManualIntegration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_manual_integration")?.Value;
        set => this.WithProperty("use_manual_integration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The repository specified is Mercurial. Defaults to `false`.
    /// </summary>
    public bool? UseMercurial
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_mercurial")?.Value;
        set => this.WithProperty("use_mercurial", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
