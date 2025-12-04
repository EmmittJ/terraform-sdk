using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityMirroringEndpointGroupAssociation.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_mirroring_endpoint_group_association Terraform resource.
/// Manages a google_network_security_mirroring_endpoint_group_association resource.
/// </summary>
public partial class GoogleNetworkSecurityMirroringEndpointGroupAssociation(string name) : TerraformResource("google_network_security_mirroring_endpoint_group_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The cloud location of the association, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The endpoint group that this association is connected to, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    public required TerraformValue<string> MirroringEndpointGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("mirroring_endpoint_group");
        set => SetArgument("mirroring_endpoint_group", value);
    }

    /// <summary>
    /// The ID to use for the new association, which will become the final
    /// component of the endpoint group&#39;s resource name. If not provided, the
    /// server will generate a unique ID.
    /// </summary>
    public TerraformValue<string>? MirroringEndpointGroupAssociationId
    {
        get => GetArgument<TerraformValue<string>>("mirroring_endpoint_group_association_id");
        set => SetArgument("mirroring_endpoint_group_association_id", value);
    }

    /// <summary>
    /// The VPC network that is associated. for example:
    /// &#39;projects/123456789/global/networks/my-network&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
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
    /// The list of locations where the association is configured. This information
    /// is retrieved from the linked endpoint group.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Locations
        => AsReference("locations");

    /// <summary>
    /// The list of locations where the association is present. This information
    /// is retrieved from the linked endpoint group, and not configured as part
    /// of the association itself.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformList<TerraformMap<object>> LocationsDetails
        => AsReference("locations_details");

    /// <summary>
    /// The resource name of this endpoint group association, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroupAssociations/my-eg-association&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. adding a new location to the target deployment group).
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Current state of the endpoint group association.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
    /// CLOSED
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
    public GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
