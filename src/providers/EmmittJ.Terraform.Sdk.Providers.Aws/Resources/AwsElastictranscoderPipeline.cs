using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineContentConfigBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Bucket { get; set; } = default!;

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageClass { get; set; }

}

/// <summary>
/// Block type for content_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineContentConfigPermissionsBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformPropertyName("access")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformPropertyName("grantee")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformPropertyName("grantee_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GranteeType { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineNotificationsBlock
{
    /// <summary>
    /// The completed attribute.
    /// </summary>
    [TerraformPropertyName("completed")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Completed { get; set; }

    /// <summary>
    /// The error attribute.
    /// </summary>
    [TerraformPropertyName("error")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Error { get; set; }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    [TerraformPropertyName("progressing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Progressing { get; set; }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    [TerraformPropertyName("warning")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Warning { get; set; }

}

/// <summary>
/// Block type for thumbnail_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Bucket { get; set; } = default!;

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageClass { get; set; }

}

/// <summary>
/// Block type for thumbnail_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformPropertyName("access")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformPropertyName("grantee")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformPropertyName("grantee_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GranteeType { get; set; }

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
    }

    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("aws_kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AwsKmsKeyArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    [TerraformPropertyName("input_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InputBucket { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    [TerraformPropertyName("output_bucket")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OutputBucket { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Role { get; set; }

    /// <summary>
    /// Block for content_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    [TerraformPropertyName("content_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineContentConfigBlock>>? ContentConfig { get; set; }

    /// <summary>
    /// Block for content_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("content_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineContentConfigPermissionsBlock>>? ContentConfigPermissions { get; set; }

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformPropertyName("notifications")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineNotificationsBlock>>? Notifications { get; set; }

    /// <summary>
    /// Block for thumbnail_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    [TerraformPropertyName("thumbnail_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigBlock>>? ThumbnailConfig { get; set; }

    /// <summary>
    /// Block for thumbnail_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("thumbnail_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>>? ThumbnailConfigPermissions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
