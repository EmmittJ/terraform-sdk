using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPipelineContentConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformProperty("bucket")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageClass { get; set; }

}

/// <summary>
/// Block type for content_config_permissions in .
/// Nesting mode: set
/// </summary>
public partial class AwsElastictranscoderPipelineContentConfigPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformProperty("access")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformProperty("grantee")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformProperty("grantee_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GranteeType { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPipelineNotificationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The completed attribute.
    /// </summary>
    [TerraformProperty("completed")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Completed { get; set; }

    /// <summary>
    /// The error attribute.
    /// </summary>
    [TerraformProperty("error")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Error { get; set; }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    [TerraformProperty("progressing")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Progressing { get; set; }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    [TerraformProperty("warning")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Warning { get; set; }

}

/// <summary>
/// Block type for thumbnail_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsElastictranscoderPipelineThumbnailConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformProperty("bucket")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageClass { get; set; }

}

/// <summary>
/// Block type for thumbnail_config_permissions in .
/// Nesting mode: set
/// </summary>
public partial class AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformProperty("access")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformProperty("grantee")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformProperty("grantee_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GranteeType { get; set; }

}

/// <summary>
/// Manages a aws_elastictranscoder_pipeline resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsElastictranscoderPipeline : TerraformResource
{
    public AwsElastictranscoderPipeline(string name) : base("aws_elastictranscoder_pipeline", name)
    {
    }

    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("aws_kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AwsKmsKeyArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    [TerraformProperty("input_bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InputBucket { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    [TerraformProperty("output_bucket")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OutputBucket { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Role { get; set; }

    /// <summary>
    /// Block for content_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    [TerraformProperty("content_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineContentConfigBlock>>? ContentConfig { get; set; }

    /// <summary>
    /// Block for content_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("content_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineContentConfigPermissionsBlock>>? ContentConfigPermissions { get; set; }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformProperty("notifications")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineNotificationsBlock>>? Notifications { get; set; }

    /// <summary>
    /// Block for thumbnail_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    [TerraformProperty("thumbnail_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigBlock>>? ThumbnailConfig { get; set; }

    /// <summary>
    /// Block for thumbnail_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("thumbnail_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>>? ThumbnailConfigPermissions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
