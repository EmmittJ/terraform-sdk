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
    public TerraformLiteralProperty<string>? Api
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api");
        set => this.WithProperty("api", value);
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    public TerraformLiteralProperty<string>? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    public TerraformLiteralProperty<bool>? Override
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override");
        set => this.WithProperty("override", value);
    }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    public TerraformLiteralProperty<double>? Revision
    {
        get => GetProperty<TerraformLiteralProperty<double>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    public TerraformLiteralProperty<bool>? SequencedRollout
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sequenced_rollout");
        set => this.WithProperty("sequenced_rollout", value);
    }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account");
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
