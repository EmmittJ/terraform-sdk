using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsCustomDbEngineVersionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rds_custom_db_engine_version resource.
/// </summary>
public class AwsRdsCustomDbEngineVersion : TerraformResource
{
    public AwsRdsCustomDbEngineVersion(string name) : base("aws_rds_custom_db_engine_version", name)
    {
    }

    /// <summary>
    /// The database_installation_files_s3_bucket_name attribute.
    /// </summary>
    [TerraformPropertyName("database_installation_files_s3_bucket_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseInstallationFilesS3BucketName { get; set; }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    [TerraformPropertyName("database_installation_files_s3_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DatabaseInstallationFilesS3Prefix { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    [TerraformPropertyName("engine_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformPropertyName("filename")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    [TerraformPropertyName("manifest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Manifest { get; set; }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    [TerraformPropertyName("manifest_hash")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ManifestHash { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsCustomDbEngineVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The db_parameter_group_family attribute.
    /// </summary>
    [TerraformPropertyName("db_parameter_group_family")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbParameterGroupFamily => new TerraformReference(this, "db_parameter_group_family");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [TerraformPropertyName("major_engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MajorEngineVersion => new TerraformReference(this, "major_engine_version");

    /// <summary>
    /// The manifest_computed attribute.
    /// </summary>
    [TerraformPropertyName("manifest_computed")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManifestComputed => new TerraformReference(this, "manifest_computed");

}
