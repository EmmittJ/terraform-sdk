using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsCustomDbEngineVersionTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_rds_custom_db_engine_version resource.
/// </summary>
public partial class AwsRdsCustomDbEngineVersion : TerraformResource
{
    public AwsRdsCustomDbEngineVersion(string name) : base("aws_rds_custom_db_engine_version", name)
    {
    }

    /// <summary>
    /// The database_installation_files_s3_bucket_name attribute.
    /// </summary>
    [TerraformProperty("database_installation_files_s3_bucket_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseInstallationFilesS3BucketName { get; set; }

    /// <summary>
    /// The database_installation_files_s3_prefix attribute.
    /// </summary>
    [TerraformProperty("database_installation_files_s3_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseInstallationFilesS3Prefix { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    [TerraformProperty("engine_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The filename attribute.
    /// </summary>
    [TerraformProperty("filename")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filename { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    [TerraformProperty("manifest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Manifest { get; set; }

    /// <summary>
    /// The manifest_hash attribute.
    /// </summary>
    [TerraformProperty("manifest_hash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManifestHash { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformProperty("source_image_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceImageId { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRdsCustomDbEngineVersionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The db_parameter_group_family attribute.
    /// </summary>
    [TerraformProperty("db_parameter_group_family")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbParameterGroupFamily { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The major_engine_version attribute.
    /// </summary>
    [TerraformProperty("major_engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MajorEngineVersion { get; }

    /// <summary>
    /// The manifest_computed attribute.
    /// </summary>
    [TerraformProperty("manifest_computed")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ManifestComputed { get; }

}
