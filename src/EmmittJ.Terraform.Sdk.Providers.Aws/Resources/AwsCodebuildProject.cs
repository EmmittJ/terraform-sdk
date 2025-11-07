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
    /// Maximum number of additional automatic retries after a failed build. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? AutoRetryLimit
    {
        get => GetProperty<TerraformProperty<double>>("auto_retry_limit");
        set => this.WithProperty("auto_retry_limit", value);
    }

    /// <summary>
    /// The badge_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BadgeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("badge_enabled");
        set => this.WithProperty("badge_enabled", value);
    }

    /// <summary>
    /// The build_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? BuildTimeout
    {
        get => GetProperty<TerraformProperty<double>>("build_timeout");
        set => this.WithProperty("build_timeout", value);
    }

    /// <summary>
    /// The concurrent_build_limit attribute.
    /// </summary>
    public TerraformProperty<double>? ConcurrentBuildLimit
    {
        get => GetProperty<TerraformProperty<double>>("concurrent_build_limit");
        set => this.WithProperty("concurrent_build_limit", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key");
        set => this.WithProperty("encryption_key", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_visibility attribute.
    /// </summary>
    public TerraformProperty<string>? ProjectVisibility
    {
        get => GetProperty<TerraformProperty<string>>("project_visibility");
        set => this.WithProperty("project_visibility", value);
    }

    /// <summary>
    /// The queued_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? QueuedTimeout
    {
        get => GetProperty<TerraformProperty<double>>("queued_timeout");
        set => this.WithProperty("queued_timeout", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_access_role attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceAccessRole
    {
        get => GetProperty<TerraformProperty<string>>("resource_access_role");
        set => this.WithProperty("resource_access_role", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVersion
    {
        get => GetProperty<TerraformProperty<string>>("source_version");
        set => this.WithProperty("source_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
