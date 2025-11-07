using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_security_intercept_endpoint_group_association resource.
/// </summary>
public class GoogleNetworkSecurityInterceptEndpointGroupAssociation : TerraformResource
{
    public GoogleNetworkSecurityInterceptEndpointGroupAssociation(string name) : base("google_network_security_intercept_endpoint_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("locations");
        this.DeclareOutput("locations_details");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The endpoint group that this association is connected to, for example:
    /// &#39;projects/123456789/locations/global/interceptEndpointGroups/my-eg&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    public TerraformLiteralProperty<string>? InterceptEndpointGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("intercept_endpoint_group");
        set => this.WithProperty("intercept_endpoint_group", value);
    }

    /// <summary>
    /// The ID to use for the new association, which will become the final
    /// component of the endpoint group&#39;s resource name. If not provided, the
    /// server will generate a unique ID.
    /// </summary>
    public TerraformLiteralProperty<string>? InterceptEndpointGroupAssociationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("intercept_endpoint_group_association_id");
        set => this.WithProperty("intercept_endpoint_group_association_id", value);
    }

    /// <summary>
    /// Labels are key/value pairs that help to organize and filter resources.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The cloud location of the association, currently restricted to &#39;global&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The VPC network that is associated. for example:
    /// &#39;projects/123456789/global/networks/my-network&#39;.
    /// See https://google.aip.dev/124.
    /// </summary>
    public TerraformLiteralProperty<string>? Network
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network");
        set => this.WithProperty("network", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    /// &#39;projects/123456789/locations/global/interceptEndpointGroupAssociations/my-eg-association&#39;.
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
