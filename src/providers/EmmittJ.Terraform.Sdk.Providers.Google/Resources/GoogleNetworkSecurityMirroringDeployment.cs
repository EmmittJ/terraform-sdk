using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityMirroringDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_mirroring_deployment Terraform resource.
/// Manages a google_network_security_mirroring_deployment resource.
/// </summary>
public partial class GoogleNetworkSecurityMirroringDeployment(string name) : TerraformResource("google_network_security_mirroring_deployment", name)
{
    /// <summary>
    /// User-provided description of the deployment.
    /// Used as additional context for the deployment.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The regional forwarding rule that fronts the mirroring collectors, for
    /// example: &#39;projects/123456789/regions/us-central1/forwardingRules/my-rule&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardingRule is required")]
    public required TerraformValue<string> ForwardingRule
    {
        get => GetArgument<TerraformValue<string>>("forwarding_rule");
        set => SetArgument("forwarding_rule", value);
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
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The cloud location of the deployment, e.g. &#39;us-central1-a&#39; or &#39;asia-south1-b&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The deployment group that this deployment is a part of, for example:
    /// &#39;projects/123456789/locations/global/mirroringDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringDeploymentGroup is required")]
    public required TerraformValue<string> MirroringDeploymentGroup
    {
        get => GetArgument<TerraformValue<string>>("mirroring_deployment_group");
        set => SetArgument("mirroring_deployment_group", value);
    }

    /// <summary>
    /// The ID to use for the new deployment, which will become the final
    /// component of the deployment&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringDeploymentId is required")]
    public required TerraformValue<string> MirroringDeploymentId
    {
        get => GetArgument<TerraformValue<string>>("mirroring_deployment_id");
        set => SetArgument("mirroring_deployment_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The resource name of this deployment, for example:
    /// &#39;projects/123456789/locations/us-central1-a/mirroringDeployments/my-dep&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. linking a new association to the parent group).
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The current state of the deployment.
    /// See https://google.aip.dev/216.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// OUT_OF_SYNC
    /// DELETE_FAILED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityMirroringDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityMirroringDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
