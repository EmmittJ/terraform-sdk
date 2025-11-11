using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_units in .
/// Nesting mode: list
/// </summary>
public partial class AwsKendraIndexCapacityUnitsBlock : TerraformBlockBase
{
    /// <summary>
    /// The query_capacity_units attribute.
    /// </summary>
    [TerraformProperty("query_capacity_units")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> QueryCapacityUnits { get; set; }

    /// <summary>
    /// The storage_capacity_units attribute.
    /// </summary>
    [TerraformProperty("storage_capacity_units")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> StorageCapacityUnits { get; set; }

}

/// <summary>
/// Block type for document_metadata_configuration_updates in .
/// Nesting mode: set
/// </summary>
public partial class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKendraIndexServerSideEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKendraIndexTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_group_resolution_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsKendraIndexUserGroupResolutionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The user_group_resolution_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserGroupResolutionMode is required")]
    [TerraformProperty("user_group_resolution_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserGroupResolutionMode { get; set; }

}

/// <summary>
/// Block type for user_token_configurations in .
/// Nesting mode: list
/// </summary>
public partial class AwsKendraIndexUserTokenConfigurationsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_kendra_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKendraIndex : TerraformResource
{
    public AwsKendraIndex(string name) : base("aws_kendra_index", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformProperty("edition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Edition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    [TerraformProperty("user_context_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserContextPolicy { get; set; }

    /// <summary>
    /// Block for capacity_units.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityUnits block(s) allowed")]
    [TerraformProperty("capacity_units")]
    public TerraformList<TerraformBlock<AwsKendraIndexCapacityUnitsBlock>>? CapacityUnits { get; set; }

    /// <summary>
    /// Block for document_metadata_configuration_updates.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 DocumentMetadataConfigurationUpdates block(s) allowed")]
    [TerraformProperty("document_metadata_configuration_updates")]
    public TerraformSet<TerraformBlock<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>>? DocumentMetadataConfigurationUpdates { get; set; }

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [TerraformProperty("server_side_encryption_configuration")]
    public TerraformList<TerraformBlock<AwsKendraIndexServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsKendraIndexTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_group_resolution_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserGroupResolutionConfiguration block(s) allowed")]
    [TerraformProperty("user_group_resolution_configuration")]
    public TerraformList<TerraformBlock<AwsKendraIndexUserGroupResolutionConfigurationBlock>>? UserGroupResolutionConfiguration { get; set; }

    /// <summary>
    /// Block for user_token_configurations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserTokenConfigurations block(s) allowed")]
    [TerraformProperty("user_token_configurations")]
    public TerraformList<TerraformBlock<AwsKendraIndexUserTokenConfigurationsBlock>>? UserTokenConfigurations { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    [TerraformProperty("index_statistics")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IndexStatistics { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdatedAt { get; }

}
