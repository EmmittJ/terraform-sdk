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
    public string? Api
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api")?.Value;
        set => this.WithProperty("api", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Apigee organization ID.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    public bool? Override
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("override")?.Value;
        set => this.WithProperty("override", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    public double? Revision
    {
        get => GetProperty<TerraformLiteralProperty<double>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    public bool? SequencedRollout
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("sequenced_rollout")?.Value;
        set => this.WithProperty("sequenced_rollout", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    public string? ServiceAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account")?.Value;
        set => this.WithProperty("service_account", value == null ? null : new TerraformLiteralProperty<string>(value));
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
