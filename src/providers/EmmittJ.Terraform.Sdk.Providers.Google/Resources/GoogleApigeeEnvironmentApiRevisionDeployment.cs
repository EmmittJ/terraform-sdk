using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock : TerraformBlock
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

}

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
        this.WithOutput("basepaths");
        this.WithOutput("deploy_start_time");
        this.WithOutput("state");
    }

    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Api is required")]
    public required TerraformProperty<string> Api
    {
        get => GetRequiredProperty<TerraformProperty<string>>("api");
        set => this.WithProperty("api", value);
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("environment");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("org_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<double> Revision
    {
        get => GetRequiredProperty<TerraformProperty<double>>("revision");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
