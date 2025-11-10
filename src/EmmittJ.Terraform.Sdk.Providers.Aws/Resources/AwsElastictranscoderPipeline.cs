using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineContentConfigBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => WithProperty("storage_class", value);
    }

}

/// <summary>
/// Block type for content_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineContentConfigPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Access
    {
        get => GetProperty<List<TerraformProperty<string>>>("access");
        set => WithProperty("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformProperty<string>? Grantee
    {
        get => GetProperty<TerraformProperty<string>>("grantee");
        set => WithProperty("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformProperty<string>? GranteeType
    {
        get => GetProperty<TerraformProperty<string>>("grantee_type");
        set => WithProperty("grantee_type", value);
    }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineNotificationsBlock : TerraformBlock
{
    /// <summary>
    /// The completed attribute.
    /// </summary>
    public TerraformProperty<string>? Completed
    {
        get => GetProperty<TerraformProperty<string>>("completed");
        set => WithProperty("completed", value);
    }

    /// <summary>
    /// The error attribute.
    /// </summary>
    public TerraformProperty<string>? Error
    {
        get => GetProperty<TerraformProperty<string>>("error");
        set => WithProperty("error", value);
    }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    public TerraformProperty<string>? Progressing
    {
        get => GetProperty<TerraformProperty<string>>("progressing");
        set => WithProperty("progressing", value);
    }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    public TerraformProperty<string>? Warning
    {
        get => GetProperty<TerraformProperty<string>>("warning");
        set => WithProperty("warning", value);
    }

}

/// <summary>
/// Block type for thumbnail_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => WithProperty("storage_class", value);
    }

}

/// <summary>
/// Block type for thumbnail_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Access
    {
        get => GetProperty<List<TerraformProperty<string>>>("access");
        set => WithProperty("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformProperty<string>? Grantee
    {
        get => GetProperty<TerraformProperty<string>>("grantee");
        set => WithProperty("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformProperty<string>? GranteeType
    {
        get => GetProperty<TerraformProperty<string>>("grantee_type");
        set => WithProperty("grantee_type", value);
    }

}

/// <summary>
/// Manages a aws_elastictranscoder_pipeline resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElastictranscoderPipeline : TerraformResource
{
    public AwsElastictranscoderPipeline(string name) : base("aws_elastictranscoder_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AwsKmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("aws_kms_key_arn");
        set => this.WithProperty("aws_kms_key_arn", value);
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
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    public required TerraformProperty<string> InputBucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("input_bucket");
        set => this.WithProperty("input_bucket", value);
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
    /// The output_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? OutputBucket
    {
        get => GetProperty<TerraformProperty<string>>("output_bucket");
        set => this.WithProperty("output_bucket", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// Block for content_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    public List<AwsElastictranscoderPipelineContentConfigBlock>? ContentConfig
    {
        get => GetProperty<List<AwsElastictranscoderPipelineContentConfigBlock>>("content_config");
        set => this.WithProperty("content_config", value);
    }

    /// <summary>
    /// Block for content_config_permissions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPipelineContentConfigPermissionsBlock>? ContentConfigPermissions
    {
        get => GetProperty<HashSet<AwsElastictranscoderPipelineContentConfigPermissionsBlock>>("content_config_permissions");
        set => this.WithProperty("content_config_permissions", value);
    }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public List<AwsElastictranscoderPipelineNotificationsBlock>? Notifications
    {
        get => GetProperty<List<AwsElastictranscoderPipelineNotificationsBlock>>("notifications");
        set => this.WithProperty("notifications", value);
    }

    /// <summary>
    /// Block for thumbnail_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    public List<AwsElastictranscoderPipelineThumbnailConfigBlock>? ThumbnailConfig
    {
        get => GetProperty<List<AwsElastictranscoderPipelineThumbnailConfigBlock>>("thumbnail_config");
        set => this.WithProperty("thumbnail_config", value);
    }

    /// <summary>
    /// Block for thumbnail_config_permissions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>? ThumbnailConfigPermissions
    {
        get => GetProperty<HashSet<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>>("thumbnail_config_permissions");
        set => this.WithProperty("thumbnail_config_permissions", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
