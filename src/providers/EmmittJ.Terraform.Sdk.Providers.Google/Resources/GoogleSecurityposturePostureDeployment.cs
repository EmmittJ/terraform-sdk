using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSecurityposturePostureDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleSecurityposturePostureDeploymentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_securityposture_posture_deployment Terraform resource.
/// Manages a google_securityposture_posture_deployment resource.
/// </summary>
public partial class GoogleSecurityposturePostureDeployment(string name) : TerraformResource("google_securityposture_posture_deployment", name)
{
    /// <summary>
    /// Description of the posture deployment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the resource, eg. global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parent of the resource, an organization. Format should be &#39;organizations/{organization_id}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// ID of the posture deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureDeploymentId is required")]
    public required TerraformValue<string> PostureDeploymentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("posture_deployment_id");
        set => SetArgument("posture_deployment_id", value);
    }

    /// <summary>
    /// Relative name of the posture which needs to be deployed. It should be in the format:
    ///   organizations/{organization_id}/locations/{location}/postures/{posture_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureId is required")]
    public required TerraformValue<string> PostureId
    {
        get => GetRequiredArgument<TerraformValue<string>>("posture_id");
        set => SetArgument("posture_id", value);
    }

    /// <summary>
    /// Revision_id the posture which needs to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PostureRevisionId is required")]
    public required TerraformValue<string> PostureRevisionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("posture_revision_id");
        set => SetArgument("posture_revision_id", value);
    }

    /// <summary>
    /// The resource on which the posture should be deployed. This can be in one of the following formats:
    /// projects/{project_number},
    /// folders/{folder_number},
    /// organizations/{organization_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResource is required")]
    public required TerraformValue<string> TargetResource
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_resource");
        set => SetArgument("target_resource", value);
    }

    /// <summary>
    /// Time the posture deployment was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture to be deployed.
    /// </summary>
    public TerraformValue<string> DesiredPostureId
        => AsReference("desired_posture_id");

    /// <summary>
    /// This is an output only optional field which will be filled in case when
    /// PostureDeployment state is UPDATE_FAILED or CREATE_FAILED or DELETE_FAILED.
    /// It denotes the desired posture revision_id to be deployed.
    /// </summary>
    public TerraformValue<string> DesiredPostureRevisionId
        => AsReference("desired_posture_revision_id");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// This is a output only optional field which will be filled in case where
    /// PostureDeployment enters a failure state like UPDATE_FAILED or
    /// CREATE_FAILED or DELETE_FAILED. It will have the failure message for posture deployment&#39;s
    /// CREATE/UPDATE/DELETE methods.
    /// </summary>
    public TerraformValue<string> FailureMessage
        => AsReference("failure_message");

    /// <summary>
    /// Name of the posture deployment instance.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// If set, there are currently changes in flight to the posture deployment.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// State of the posture deployment. A posture deployment can be in the following terminal states:
    /// ACTIVE, CREATE_FAILED, UPDATE_FAILED, DELETE_FAILED.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Time the posture deployment was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSecurityposturePostureDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSecurityposturePostureDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
