using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeEnvironmentApiRevisionDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_apigee_environment_api_revision_deployment Terraform resource.
/// Manages a google_apigee_environment_api_revision_deployment resource.
/// </summary>
public partial class GoogleApigeeEnvironmentApiRevisionDeployment(string name) : TerraformResource("google_apigee_environment_api_revision_deployment", name)
{
    /// <summary>
    /// Apigee API proxy name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Api is required")]
    public required TerraformValue<string> Api
    {
        get => GetArgument<TerraformValue<string>>("api");
        set => SetArgument("api", value);
    }

    /// <summary>
    /// Apigee environment name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Apigee organization ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// If true, replaces other deployed revisions of this proxy in the environment.
    /// </summary>
    public TerraformValue<bool>? OverrideAttribute
    {
        get => GetArgument<TerraformValue<bool>>("override");
        set => SetArgument("override", value);
    }

    /// <summary>
    /// API proxy revision number to deploy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<double> Revision
    {
        get => GetArgument<TerraformValue<double>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// If true, enables sequenced rollout for safe traffic switching.
    /// </summary>
    public TerraformValue<bool>? SequencedRollout
    {
        get => GetArgument<TerraformValue<bool>>("sequenced_rollout");
        set => SetArgument("sequenced_rollout", value);
    }

    /// <summary>
    /// Optional service account the deployed proxy runs as.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Basepaths associated with the deployed proxy.
    /// </summary>
    public TerraformList<string> Basepaths
        => AsReference("basepaths");

    /// <summary>
    /// RFC3339 timestamp when deployment started.
    /// </summary>
    public TerraformValue<string> DeployStartTime
        => AsReference("deploy_start_time");

    /// <summary>
    /// Deployment state reported by Apigee.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeEnvironmentApiRevisionDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
