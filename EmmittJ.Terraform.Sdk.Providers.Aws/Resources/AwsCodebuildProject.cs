using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codebuild_project resource.
/// </summary>
public class AwsCodebuildProject : TerraformResource
{
    public AwsCodebuildProject(string name) : base("aws_codebuild_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("badge_url");
        this.DeclareOutput("public_project_alias");
    }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    public bool? BadgeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("badge_enabled")?.Value;
        set => this.WithProperty("badge_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    public double? BuildTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("build_timeout")?.Value;
        set => this.WithProperty("build_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    public double? ConcurrentBuildLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("concurrent_build_limit")?.Value;
        set => this.WithProperty("concurrent_build_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public string? EncryptionKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encryption_key")?.Value;
        set => this.WithProperty("encryption_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    public string? ProjectVisibility
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_visibility")?.Value;
        set => this.WithProperty("project_visibility", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    public double? QueuedTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("queued_timeout")?.Value;
        set => this.WithProperty("queued_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    public string? ResourceAccessRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_access_role")?.Value;
        set => this.WithProperty("resource_access_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public string? ServiceRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role")?.Value;
        set => this.WithProperty("service_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public string? SourceVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_version")?.Value;
        set => this.WithProperty("source_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The badge_url attribute.
    /// </summary>
    public TerraformExpression BadgeUrl => this["badge_url"];

    /// <summary>
    /// The public_project_alias attribute.
    /// </summary>
    public TerraformExpression PublicProjectAlias => this["public_project_alias"];

}
