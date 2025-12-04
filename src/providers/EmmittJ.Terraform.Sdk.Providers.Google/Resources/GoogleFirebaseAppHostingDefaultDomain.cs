using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaseAppHostingDefaultDomain.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaseAppHostingDefaultDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_firebase_app_hosting_default_domain Terraform resource.
/// Manages a google_firebase_app_hosting_default_domain resource.
/// </summary>
public partial class GoogleFirebaseAppHostingDefaultDomain(string name) : TerraformResource("google_firebase_app_hosting_default_domain", name)
{
    /// <summary>
    /// The ID of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    public required TerraformValue<string> Backend
    {
        get => GetArgument<TerraformValue<string>>("backend");
        set => SetArgument("backend", value);
    }

    /// <summary>
    /// Whether the domain is disabled. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Id of the domain. For default domain, it should be {{backend}}--{{project_id}}.{{location}}.hosted.app
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => GetArgument<TerraformValue<string>>("domain_id");
        set => SetArgument("domain_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location of the Backend that this Domain is associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time at which the domain was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Server-computed checksum based on other values; may be sent
    /// on update or delete to ensure operation is done on expected resource.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Identifier. The resource name of the domain, e.g.
    /// &#39;projects/{project}/locations/{locationId}/backends/{backendId}/domains/{domainId}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// System-assigned, unique identifier.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Time at which the domain was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaseAppHostingDefaultDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaseAppHostingDefaultDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
