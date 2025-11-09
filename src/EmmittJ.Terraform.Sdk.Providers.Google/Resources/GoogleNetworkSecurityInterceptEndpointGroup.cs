using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_security_intercept_endpoint_group resource.
/// </summary>
public class GoogleNetworkSecurityInterceptEndpointGroup : TerraformResource
{
    public GoogleNetworkSecurityInterceptEndpointGroup(string name) : base("google_network_security_intercept_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associations");
        this.DeclareOutput("connected_deployment_group");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User-provided description of the endpoint group.
    /// Used as additional context for the endpoint group.
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
    /// The deployment group that this endpoint group is connected to, for example:
    /// &#39;projects/123456789/locations/global/interceptDeploymentGroups/my-dg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    public TerraformProperty<string>? InterceptDeploymentGroup
    {
        get => GetProperty<TerraformProperty<string>>("intercept_deployment_group");
        set => this.WithProperty("intercept_deployment_group", value);
    }

    /// <summary>
    /// The ID to use for the endpoint group, which will become the final component
    /// of the endpoint group&#39;s resource name.
    /// </summary>
    public TerraformProperty<string>? InterceptEndpointGroupId
    {
        get => GetProperty<TerraformProperty<string>>("intercept_endpoint_group_id");
        set => this.WithProperty("intercept_endpoint_group_id", value);
    }

    /// <summary>
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The cloud location of the endpoint group, currently restricted to &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// List of associations to this endpoint group.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

    /// <summary>
    /// The endpoint group&#39;s view of a connected deployment group.
    /// </summary>
    public TerraformExpression ConnectedDeploymentGroup => this["connected_deployment_group"];

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
    /// The resource name of this endpoint group, for example:
    /// &#39;projects/123456789/locations/global/interceptEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/122 for more details.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the resource does not match the user&#39;s intended state,
    /// and the system is working to reconcile them. This is part of the normal
    /// operation (e.g. adding a new association to the group).
    /// See https://google.aip.dev/128.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The current state of the endpoint group.
    /// See https://google.aip.dev/216.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ACTIVE
    /// CLOSED
    /// CREATING
    /// DELETING
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
