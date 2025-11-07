using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_environment_api_revision_deployment resource.
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeployment : TerraformResource
{
    public GoogleApigeeEnvironmentApiRevisionDeployment(string name) : base("google_apigee_environment_api_revision_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("basepaths");
        this.DeclareOutput("deploy_start_time");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    public TerraformProperty<string>? Api
    {
        get => GetProperty<TerraformProperty<string>>("api");
        set => this.WithProperty("api", value);
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    public TerraformProperty<string>? Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// Apigee organization ID.
    /// </summary>
    public TerraformProperty<string>? OrgId
    {
        get => GetProperty<TerraformProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    public TerraformProperty<bool>? Override
    {
        get => GetProperty<TerraformProperty<bool>>("override");
        set => this.WithProperty("override", value);
    }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    public TerraformProperty<double>? Revision
    {
        get => GetProperty<TerraformProperty<double>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    public TerraformProperty<bool>? SequencedRollout
    {
        get => GetProperty<TerraformProperty<bool>>("sequenced_rollout");
        set => this.WithProperty("sequenced_rollout", value);
    }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Basepaths associated with the deployed proxy.
    /// </summary>
    public TerraformExpression Basepaths => this["basepaths"];

    /// <summary>
    /// RFC3339 timestamp when deployment started.
    /// </summary>
    public TerraformExpression DeployStartTime => this["deploy_start_time"];

    /// <summary>
    /// Deployment state reported by Apigee.
    /// </summary>
    public TerraformExpression State => this["state"];

}
