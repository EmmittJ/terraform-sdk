using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_security_mirroring_endpoint_group_association resource.
/// </summary>
public class GoogleNetworkSecurityMirroringEndpointGroupAssociation : TerraformResource
{
    public GoogleNetworkSecurityMirroringEndpointGroupAssociation(string name) : base("google_network_security_mirroring_endpoint_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("locations");
        SetOutput("locations_details");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("mirroring_endpoint_group");
        SetOutput("mirroring_endpoint_group_association_id");
        SetOutput("network");
        SetOutput("project");
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
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The cloud location of the association, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The endpoint group that this association is connected to, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    public required TerraformProperty<string> MirroringEndpointGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mirroring_endpoint_group");
        set => SetProperty("mirroring_endpoint_group", value);
    }

    /// <summary>
    /// The ID to use for the new association, which will become the final
    /// component of the endpoint group&#39;s resource name. If not provided, the
    /// server will generate a unique ID.
    /// </summary>
    public TerraformProperty<string> MirroringEndpointGroupAssociationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mirroring_endpoint_group_association_id");
        set => SetProperty("mirroring_endpoint_group_association_id", value);
    }

    /// <summary>
    /// The VPC network that is associated. for example:
    /// &#39;projects/123456789/global/networks/my-network&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityMirroringEndpointGroupAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The list of locations where the association is configured. This information
    /// is retrieved from the linked endpoint group.
    /// </summary>
    public TerraformExpression Locations => this["locations"];

    /// <summary>
    /// The list of locations where the association is present. This information
    /// is retrieved from the linked endpoint group, and not configured as part
    /// of the association itself.
    /// </summary>
    public TerraformExpression LocationsDetails => this["locations_details"];

    /// <summary>
    /// The resource name of this endpoint group association, for example:
    /// &#39;projects/123456789/locations/global/mirroringEndpointGroupAssociations/my-eg-association&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This part of the normal
    /// operation (e.g. adding a new location to the target deployment group).
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

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
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The timestamp when the resource was most recently updated.
    /// See https://google.aip.dev/148#timestamps.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
