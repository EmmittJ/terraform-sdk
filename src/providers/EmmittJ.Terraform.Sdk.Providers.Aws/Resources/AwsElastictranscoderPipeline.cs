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
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        set => SetProperty("storage_class", value);
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
        set => SetProperty("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformProperty<string>? Grantee
    {
        set => SetProperty("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformProperty<string>? GranteeType
    {
        set => SetProperty("grantee_type", value);
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
        set => SetProperty("completed", value);
    }

    /// <summary>
    /// The error attribute.
    /// </summary>
    public TerraformProperty<string>? Error
    {
        set => SetProperty("error", value);
    }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    public TerraformProperty<string>? Progressing
    {
        set => SetProperty("progressing", value);
    }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    public TerraformProperty<string>? Warning
    {
        set => SetProperty("warning", value);
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
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        set => SetProperty("storage_class", value);
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
        set => SetProperty("access", value);
    }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    public TerraformProperty<string>? Grantee
    {
        set => SetProperty("grantee", value);
    }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    public TerraformProperty<string>? GranteeType
    {
        set => SetProperty("grantee_type", value);
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
        SetOutput("arn");
        SetOutput("aws_kms_key_arn");
        SetOutput("id");
        SetOutput("input_bucket");
        SetOutput("name");
        SetOutput("output_bucket");
        SetOutput("region");
        SetOutput("role");
    }

    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> AwsKmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_kms_key_arn");
        set => SetProperty("aws_kms_key_arn", value);
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
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    public required TerraformProperty<string> InputBucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("input_bucket");
        set => SetProperty("input_bucket", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    public TerraformProperty<string> OutputBucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_bucket");
        set => SetProperty("output_bucket", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role");
        set => SetProperty("role", value);
    }

    /// <summary>
    /// Block for content_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    public List<AwsElastictranscoderPipelineContentConfigBlock>? ContentConfig
    {
        set => SetProperty("content_config", value);
    }

    /// <summary>
    /// Block for content_config_permissions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPipelineContentConfigPermissionsBlock>? ContentConfigPermissions
    {
        set => SetProperty("content_config_permissions", value);
    }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    public List<AwsElastictranscoderPipelineNotificationsBlock>? Notifications
    {
        set => SetProperty("notifications", value);
    }

    /// <summary>
    /// Block for thumbnail_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    public List<AwsElastictranscoderPipelineThumbnailConfigBlock>? ThumbnailConfig
    {
        set => SetProperty("thumbnail_config", value);
    }

    /// <summary>
    /// Block for thumbnail_config_permissions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>? ThumbnailConfigPermissions
    {
        set => SetProperty("thumbnail_config_permissions", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
