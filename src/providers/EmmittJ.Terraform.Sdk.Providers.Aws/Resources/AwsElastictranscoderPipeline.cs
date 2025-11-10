using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineContentConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Bucket { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bucket");

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageClass { get; set; }

}

/// <summary>
/// Block type for content_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineContentConfigPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformPropertyName("access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformPropertyName("grantee")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformPropertyName("grantee_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GranteeType { get; set; }

}

/// <summary>
/// Block type for notifications in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineNotificationsBlock : ITerraformBlock
{
    /// <summary>
    /// The completed attribute.
    /// </summary>
    [TerraformPropertyName("completed")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Completed { get; set; }

    /// <summary>
    /// The error attribute.
    /// </summary>
    [TerraformPropertyName("error")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Error { get; set; }

    /// <summary>
    /// The progressing attribute.
    /// </summary>
    [TerraformPropertyName("progressing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Progressing { get; set; }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    [TerraformPropertyName("warning")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Warning { get; set; }

}

/// <summary>
/// Block type for thumbnail_config in .
/// Nesting mode: list
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformPropertyName("bucket")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Bucket { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "bucket");

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageClass { get; set; }

}

/// <summary>
/// Block type for thumbnail_config_permissions in .
/// Nesting mode: set
/// </summary>
public class AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// The access attribute.
    /// </summary>
    [TerraformPropertyName("access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Access { get; set; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformPropertyName("grantee")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Grantee { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [TerraformPropertyName("grantee_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GranteeType { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? AwsKmsKeyArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The input_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputBucket is required")]
    [TerraformPropertyName("input_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputBucket { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    [TerraformPropertyName("output_bucket")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OutputBucket { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_bucket");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Role { get; set; }

    /// <summary>
    /// Block for content_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentConfig block(s) allowed")]
    [TerraformPropertyName("content_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineContentConfigBlock>>? ContentConfig { get; set; } = new();

    /// <summary>
    /// Block for content_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("content_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineContentConfigPermissionsBlock>>? ContentConfigPermissions { get; set; } = new();

    /// <summary>
    /// Block for notifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notifications block(s) allowed")]
    [TerraformPropertyName("notifications")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineNotificationsBlock>>? Notifications { get; set; } = new();

    /// <summary>
    /// Block for thumbnail_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfig block(s) allowed")]
    [TerraformPropertyName("thumbnail_config")]
    public TerraformList<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigBlock>>? ThumbnailConfig { get; set; } = new();

    /// <summary>
    /// Block for thumbnail_config_permissions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("thumbnail_config_permissions")]
    public TerraformSet<TerraformBlock<AwsElastictranscoderPipelineThumbnailConfigPermissionsBlock>>? ThumbnailConfigPermissions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
