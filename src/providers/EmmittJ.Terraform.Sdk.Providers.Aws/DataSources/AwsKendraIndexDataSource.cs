using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_index.
/// </summary>
public class AwsKendraIndexDataSource : TerraformDataSource
{
    public AwsKendraIndexDataSource(string name) : base("aws_kendra_index", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("capacity_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CapacityUnits => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "capacity_units");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    [TerraformPropertyName("document_metadata_configuration_updates")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> DocumentMetadataConfigurationUpdates => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "document_metadata_configuration_updates");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Edition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edition");

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
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServerSideEncryptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "server_side_encryption_configuration");

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

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    [TerraformPropertyName("user_context_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserContextPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_context_policy");

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    [TerraformPropertyName("user_group_resolution_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserGroupResolutionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_group_resolution_configuration");

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    [TerraformPropertyName("user_token_configurations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserTokenConfigurations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_token_configurations");

}
