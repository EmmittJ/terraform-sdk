using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rules in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkServicesTlsRouteRulesBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkServicesTlsRouteTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_services_tls_route resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkServicesTlsRoute : TerraformResource
{
    public GoogleNetworkServicesTlsRoute(string name) : base("google_network_services_tls_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("self_link");
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
    /// Gateways defines a list of gateways this TlsRoute is attached to, as one of the routing rules to route the requests served by the gateway.
    /// Each gateway reference should match the pattern: projects/*/locations/global/gateways/&amp;lt;gateway_name&amp;gt;
    /// </summary>
    public List<TerraformProperty<string>>? Gateways
    {
        get => GetProperty<List<TerraformProperty<string>>>("gateways");
        set => this.WithProperty("gateways", value);
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
    /// Meshes defines a list of meshes this TlsRoute is attached to, as one of the routing rules to route the requests served by the mesh.
    /// Each mesh reference should match the pattern: projects/*/locations/global/meshes/&amp;lt;mesh_name&amp;gt;
    /// The attached Mesh should be of a type SIDECAR
    /// </summary>
    public List<TerraformProperty<string>>? Meshes
    {
        get => GetProperty<List<TerraformProperty<string>>>("meshes");
        set => this.WithProperty("meshes", value);
    }

    /// <summary>
    /// Name of the TlsRoute resource.
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
    public List<GoogleNetworkServicesTlsRouteRulesBlock>? Rules
    {
        get => GetProperty<List<GoogleNetworkServicesTlsRouteRulesBlock>>("rules");
        set => this.WithProperty("rules", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkServicesTlsRouteTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleNetworkServicesTlsRouteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time the TlsRoute was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Time the TlsRoute was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
