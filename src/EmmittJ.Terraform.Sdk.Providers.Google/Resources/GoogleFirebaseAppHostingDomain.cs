using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for serve in .
/// Nesting mode: list
/// </summary>
public class GoogleFirebaseAppHostingDomainServeBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingDomainTimeoutsBlock : TerraformBlock
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
/// Manages a google_firebase_app_hosting_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirebaseAppHostingDomain : TerraformResource
{
    public GoogleFirebaseAppHostingDomain(string name) : base("google_firebase_app_hosting_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("custom_domain_status");
        this.DeclareOutput("delete_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("purge_time");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformProperty<string> Backend
    {
        get => GetProperty<TerraformProperty<string>>("backend");
        set => this.WithProperty("backend", value);
    }

    /// <summary>
    /// Id of the domain to create.
    /// Must be a valid domain name, such as &amp;quot;foo.com&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformProperty<string> DomainId
    {
        get => GetProperty<TerraformProperty<string>>("domain_id");
        set => this.WithProperty("domain_id", value);
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
    /// The location of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    /// Block for serve.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serve block(s) allowed")]
    public List<GoogleFirebaseAppHostingDomainServeBlock>? Serve
    {
        get => GetProperty<List<GoogleFirebaseAppHostingDomainServeBlock>>("serve");
        set => this.WithProperty("serve", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaseAppHostingDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirebaseAppHostingDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Time at which the domain was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The status of a custom domain&#39;s linkage to the Backend.
    /// </summary>
    public TerraformExpression CustomDomainStatus => this["custom_domain_status"];

    /// <summary>
    /// Time at which the domain was deleted.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

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
    /// Time at which a soft-deleted domain will be purged, rendering in
    /// permanently deleted.
    /// </summary>
    public TerraformExpression PurgeTime => this["purge_time"];

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time at which the domain was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
