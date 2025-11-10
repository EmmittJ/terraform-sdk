using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_units in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexCapacityUnitsBlock : ITerraformBlock
{
    /// <summary>
    /// The query_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("query_capacity_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> QueryCapacityUnits { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "query_capacity_units");

    /// <summary>
    /// The storage_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("storage_capacity_units")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> StorageCapacityUnits { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "storage_capacity_units");

}

/// <summary>
/// Block type for document_metadata_configuration_updates in .
/// Nesting mode: set
/// </summary>
public class AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for server_side_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexServerSideEncryptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKendraIndexTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for user_group_resolution_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserGroupResolutionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The user_group_resolution_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserGroupResolutionMode is required")]
    [TerraformPropertyName("user_group_resolution_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserGroupResolutionMode { get; set; }

}

/// <summary>
/// Block type for user_token_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsKendraIndexUserTokenConfigurationsBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_kendra_index resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKendraIndex : TerraformResource
{
    public AwsKendraIndex(string name) : base("aws_kendra_index", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Edition { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    [TerraformPropertyName("user_context_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserContextPolicy { get; set; }

    /// <summary>
    /// Block for capacity_units.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityUnits block(s) allowed")]
    [TerraformPropertyName("capacity_units")]
    public TerraformList<TerraformBlock<AwsKendraIndexCapacityUnitsBlock>>? CapacityUnits { get; set; } = new();

    /// <summary>
    /// Block for document_metadata_configuration_updates.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 DocumentMetadataConfigurationUpdates block(s) allowed")]
    [TerraformPropertyName("document_metadata_configuration_updates")]
    public TerraformSet<TerraformBlock<AwsKendraIndexDocumentMetadataConfigurationUpdatesBlock>>? DocumentMetadataConfigurationUpdates { get; set; } = new();

    /// <summary>
    /// Block for server_side_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("server_side_encryption_configuration")]
    public TerraformList<TerraformBlock<AwsKendraIndexServerSideEncryptionConfigurationBlock>>? ServerSideEncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKendraIndexTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_group_resolution_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserGroupResolutionConfiguration block(s) allowed")]
    [TerraformPropertyName("user_group_resolution_configuration")]
    public TerraformList<TerraformBlock<AwsKendraIndexUserGroupResolutionConfigurationBlock>>? UserGroupResolutionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for user_token_configurations.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserTokenConfigurations block(s) allowed")]
    [TerraformPropertyName("user_token_configurations")]
    public TerraformList<TerraformBlock<AwsKendraIndexUserTokenConfigurationsBlock>>? UserTokenConfigurations { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ErrorMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "error_message");

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    [TerraformPropertyName("index_statistics")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IndexStatistics => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "index_statistics");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
