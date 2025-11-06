using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebase_app_hosting_default_domain resource.
/// </summary>
public class GoogleFirebaseAppHostingDefaultDomain : TerraformResource
{
    public GoogleFirebaseAppHostingDefaultDomain(string name) : base("google_firebase_app_hosting_default_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID of the Backend that this Domain is associated with
    /// </summary>
    public string? Backend
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend")?.Value;
        set => this.WithProperty("backend", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the domain is disabled. Defaults to false.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Id of the domain. For default domain, it should be {{backend}}--{{project_id}}.{{location}}.hosted.app
    /// </summary>
    public string? DomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_id")?.Value;
        set => this.WithProperty("domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location of the Backend that this Domain is associated with
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Time at which the domain was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The resource name of the domain, e.g.
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/domains/{domainId}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time at which the domain was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
