using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_network_services_http_route resource.
/// </summary>
public class GoogleNetworkServicesHttpRoute : TerraformResource
{
    public GoogleNetworkServicesHttpRoute(string name) : base("google_network_services_http_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Gateways defines a list of gateways this HttpRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public TerraformProperty<List<string>>? Gateways
    {
        get => GetProperty<TerraformProperty<List<string>>>("gateways");
        set => this.WithProperty("gateways", value);
    }

    /// <summary>
    /// Set of hosts that should match against the HTTP host header to select a HttpRoute to process the request.
    /// </summary>
    public TerraformProperty<List<string>>? Hostnames
    {
        get => GetProperty<TerraformProperty<List<string>>>("hostnames");
        set => this.WithProperty("hostnames", value);
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
    /// Set of label tags associated with the HttpRoute resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Meshes defines a list of meshes this HttpRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;.
    /// The attached Mesh should be of a type SIDECAR.
    /// </summary>
    public TerraformProperty<List<string>>? Meshes
    {
        get => GetProperty<TerraformProperty<List<string>>>("meshes");
        set => this.WithProperty("meshes", value);
    }

    /// <summary>
    /// Name of the HttpRoute resource.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Time the HttpRoute was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the HttpRoute was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
