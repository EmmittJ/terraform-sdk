using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_object_access_control resource.
/// </summary>
public class GoogleStorageObjectAccessControl : TerraformResource
{
    public GoogleStorageObjectAccessControl(string name) : base("google_storage_object_access_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("domain");
        this.DeclareOutput("email");
        this.DeclareOutput("entity_id");
        this.DeclareOutput("generation");
        this.DeclareOutput("project_team");
    }

    /// <summary>
    /// The name of the bucket.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
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
    public TerraformLiteralProperty<string>? Entity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entity");
        set => this.WithProperty("entity", value);
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
    /// The name of the object to apply the access control to.
    /// </summary>
    public TerraformLiteralProperty<string>? Object
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object");
        set => this.WithProperty("object", value);
    }

    /// <summary>
    /// The access permission for the entity. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;READER&amp;quot;]
    /// </summary>
    public TerraformLiteralProperty<string>? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role");
        set => this.WithProperty("role", value);
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
