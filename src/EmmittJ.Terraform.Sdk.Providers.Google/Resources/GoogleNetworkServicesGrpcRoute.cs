using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesGrpcRouteRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesGrpcRouteTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_grpc_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesGrpcRoute : TerraformResource
{
    public GoogleNetworkServicesGrpcRoute(string name) : base("google_network_services_grpc_route", name)
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
    /// List of gateways this GrpcRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// </summary>
    public List<TerraformProperty<string>>? Gateways
    {
        get => GetProperty<List<TerraformProperty<string>>>("gateways");
        set => this.WithProperty("gateways", value);
    }

    /// <summary>
    /// Required. Service hostnames with an optional port for which this route describes traffic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostnames is required")]
    public List<TerraformProperty<string>>? Hostnames
    {
        get => GetProperty<List<TerraformProperty<string>>>("hostnames");
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
    /// Set of label tags associated with the GrpcRoute resource.
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
    /// Location (region) of the GRPCRoute resource to be created. Only the value &#39;global&#39; is currently allowed; defaults to &#39;global&#39; if omitted.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// List of meshes this GrpcRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// </summary>
    public List<TerraformProperty<string>>? Meshes
    {
        get => GetProperty<List<TerraformProperty<string>>>("meshes");
        set => this.WithProperty("meshes", value);
    }

    /// <summary>
    /// Name of the GrpcRoute resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public List<GoogleNetworkServicesGrpcRouteRulesBlock>? Rules
    {
        get => GetProperty<List<GoogleNetworkServicesGrpcRouteRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesGrpcRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesGrpcRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the GrpcRoute was created in UTC.
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
    /// Time the GrpcRoute was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
