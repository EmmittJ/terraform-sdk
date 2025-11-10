using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTcpRouteRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesTcpRouteTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_tcp_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesTcpRoute : TerraformResource
{
    public GoogleNetworkServicesTcpRoute(string name) : base("google_network_services_tcp_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("self_link");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("gateways");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("meshes");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Gateways defines a list of gateways this TcpRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public List<TerraformProperty<string>> Gateways
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("gateways");
        set => SetProperty("gateways", value);
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
    /// Set of label tags associated with the TcpRoute resource.
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
    /// Meshes defines a list of meshes this TcpRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;
    /// The attached Mesh should be of a type SIDECAR
    /// </summary>
    public List<TerraformProperty<string>> Meshes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("meshes");
        set => SetProperty("meshes", value);
    }

    /// <summary>
    /// Name of the TcpRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public List<GoogleNetworkServicesTcpRouteRulesBlock>? Rules
    {
        set => SetProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesTcpRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the TcpRoute was created in UTC.
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
    /// Time the TcpRoute was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
