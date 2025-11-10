using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityMirroringDeploymentGroupTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_network_security_mirroring_deployment_group resource.
/// </summary>
public class GoogleNetworkSecurityMirroringDeploymentGroup : TerraformResource
{
    public GoogleNetworkSecurityMirroringDeploymentGroup(string name) : base("google_network_security_mirroring_deployment_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("connected_endpoint_groups");
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("locations");
        this.WithOutput("name");
        this.WithOutput("reconciling");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// User-provided description of the deployment group.
    /// Used as additional context for the deployment group.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The cloud location of the deployment group, currently restricted to &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID to use for the new deployment group, which will become the final
    /// component of the deployment group&#39;s resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringDeploymentGroupId is required")]
    public required TerraformProperty<string> MirroringDeploymentGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mirroring_deployment_group_id");
        set => this.WithProperty("mirroring_deployment_group_id", value);
    }

    /// <summary>
    /// The network that will be used for all child deployments, for example:
    /// &#39;projects/{project}/global/networks/{network}&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecurityMirroringDeploymentGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkSecurityMirroringDeploymentGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The list of endpoint groups that are connected to this resource.
    /// </summary>
    public TerraformExpression ConnectedEndpointGroups => this["connected_endpoint_groups"];

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
    /// The list of locations where the deployment group is present.
    /// </summary>
    public TerraformExpression Locations => this["locations"];

    /// <summary>
    /// The resource name of this deployment group, for example:
    /// &#39;projects/123456789/locations/global/mirroringDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This is part of the normal
    /// operation (e.g. adding a new deployment to the group)
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the deployment group.
    /// See https://google.aip.dev/216.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CREATING
    /// DELETING
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
