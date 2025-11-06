using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_secure_source_manager_repository resource.
/// </summary>
public class GoogleSecureSourceManagerRepository : TerraformResource
{
    public GoogleSecureSourceManagerRepository(string name) : base("google_secure_source_manager_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("uris");
    }

    /// <summary>
    /// The deletion policy for the repository. Setting &#39;ABANDON&#39; allows the resource
    /// to be abandoned, rather than deleted. Setting &#39;DELETE&#39; deletes the resource
    /// and all its contents. Setting &#39;PREVENT&#39; prevents the resource from accidental deletion
    /// by erroring out during plan.
    /// Default is &#39;PREVENT&#39;.  Possible values are:
    ///   * DELETE
    ///   * PREVENT
    ///   * ABANDON
    /// </summary>
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description of the repository, which cannot exceed 500 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name of the instance in which the repository is hosted.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the Repository.
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
    /// The ID for the Repository.
    /// </summary>
    public string? RepositoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository_id")?.Value;
        set => this.WithProperty("repository_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Time the repository was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name for the Repository.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Unique identifier of the repository.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the repository was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// URIs for the repository.
    /// </summary>
    public TerraformExpression Uris => this["uris"];

}
