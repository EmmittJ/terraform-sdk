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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("basepaths");
        SetOutput("deploy_start_time");
        SetOutput("state");
        SetOutput("api");
        SetOutput("environment");
        SetOutput("id");
        SetOutput("org_id");
        SetOutput("override");
        SetOutput("revision");
        SetOutput("sequenced_rollout");
        SetOutput("service_account");
    }

    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Api is required")]
    public required TerraformProperty<string> Api
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api");
        set => SetProperty("api", value);
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    public TerraformProperty<bool> Override
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("override");
        set => SetProperty("override", value);
    }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<double> Revision
    {
        get => GetRequiredOutput<TerraformProperty<double>>("revision");
        set => SetProperty("revision", value);
    }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    public TerraformProperty<bool> SequencedRollout
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sequenced_rollout");
        set => SetProperty("sequenced_rollout", value);
    }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
