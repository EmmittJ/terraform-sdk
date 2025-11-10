using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageDefaultObjectAccessControlTimeoutsBlock : TerraformBlock
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
/// Manages a google_storage_default_object_access_control resource.
/// </summary>
public class GoogleStorageDefaultObjectAccessControl : TerraformResource
{
    public GoogleStorageDefaultObjectAccessControl(string name) : base("google_storage_default_object_access_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("domain");
        SetOutput("email");
        SetOutput("entity_id");
        SetOutput("generation");
        SetOutput("project_team");
        SetOutput("bucket");
        SetOutput("entity");
        SetOutput("id");
        SetOutput("object");
        SetOutput("role");
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
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
    public required TerraformProperty<string> Entity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entity");
        set => SetProperty("entity", value);
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
    /// The name of the object, if applied to an object.
    /// </summary>
    public TerraformProperty<string> Object
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object");
        set => SetProperty("object", value);
    }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageDefaultObjectAccessControlTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The domain associated with the entity.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The email address associated with the entity.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The ID for the entity
    /// </summary>
    public TerraformExpression EntityId => this["entity_id"];

    /// <summary>
    /// The content generation of the object, if applied to an object.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

    /// <summary>
    /// The project team associated with the entity
    /// </summary>
    public TerraformExpression ProjectTeam => this["project_team"];

}
