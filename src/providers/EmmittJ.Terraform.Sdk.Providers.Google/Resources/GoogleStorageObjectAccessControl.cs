using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleStorageObjectAccessControl.
/// Nesting mode: single
/// </summary>
public class GoogleStorageObjectAccessControlTimeoutsBlock : TerraformBlock
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
/// Represents a google_storage_object_access_control Terraform resource.
/// Manages a google_storage_object_access_control resource.
/// </summary>
public partial class GoogleStorageObjectAccessControl(string name) : TerraformResource("google_storage_object_access_control", name)
{
    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The entity holding the permission, in one of the following forms:
    ///   * user-{{userId}}
    ///   * user-{{email}} (such as &amp;quot;user-liz@example.com&amp;quot;)
    ///   * group-{{groupId}}
    ///   * group-{{email}} (such as &amp;quot;group-example@googlegroups.com&amp;quot;)
    ///   * domain-{{domain}} (such as &amp;quot;domain-example.com&amp;quot;)
    ///   * project-team-{{projectId}}
    ///   * allUsers
    ///   * allAuthenticatedUsers
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entity is required")]
    public required TerraformValue<string> Entity
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity");
        set => SetArgument("entity", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the object to apply the access control to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetRequiredArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    public TerraformValue<string> Domain
        => CreateReference("domain");

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The ID for the entity
    /// </summary>
    public TerraformValue<string> EntityId
        => CreateReference("entity_id");

    /// <summary>
    /// The content generation of the object, if applied to an object.
    /// </summary>
    public TerraformValue<double> Generation
        => CreateReference("generation");

    /// <summary>
    /// The project team associated with the entity
    /// </summary>
    public TerraformList<TerraformMap<object>> ProjectTeam
        => CreateReference("project_team");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageObjectAccessControlTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageObjectAccessControlTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
