using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleServiceNetworkingConnection.
/// Nesting mode: single
/// </summary>
public class GoogleServiceNetworkingConnectionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_service_networking_connection Terraform resource.
/// Manages a google_service_networking_connection resource.
/// </summary>
public partial class GoogleServiceNetworkingConnection(string name) : TerraformResource("google_service_networking_connection", name)
{
    /// <summary>
    /// When set to ABANDON, terraform will abandon management of the resource instead of deleting it. Prevents terraform apply failures with CloudSQL. Note: The resource will still exist.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of VPC network connected with service producers using VPC peering.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Named IP address range(s) of PEERING type reserved for this service provider. Note that invoking this method with a different range when connection is already established will not reallocate already provisioned service producer subnetworks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedPeeringRanges is required")]
    public TerraformList<string>? ReservedPeeringRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "reserved_peering_ranges").ResolveNodes(ctx));
        set => SetArgument("reserved_peering_ranges", value);
    }

    /// <summary>
    /// Provider peering service that is managing peering connectivity for a service provider organization. For Google services that support this functionality it is &#39;servicenetworking.googleapis.com&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// When set to true, enforce an update of the reserved peering ranges on the existing service networking connection in case of a new connection creation failure.
    /// </summary>
    public TerraformValue<bool>? UpdateOnCreationFail
    {
        get => new TerraformReference<bool>(this, "update_on_creation_fail");
        set => SetArgument("update_on_creation_fail", value);
    }

    /// <summary>
    /// The peering attribute.
    /// </summary>
    public TerraformValue<string> Peering
    {
        get => new TerraformReference<string>(this, "peering");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleServiceNetworkingConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleServiceNetworkingConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
