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
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("capacity_units")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CapacityUnits => new TerraformReference(this, "capacity_units");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    [TerraformPropertyName("document_metadata_configuration_updates")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> DocumentMetadataConfigurationUpdates => new TerraformReference(this, "document_metadata_configuration_updates");

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformPropertyName("edition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Edition => new TerraformReference(this, "edition");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformPropertyName("error_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ErrorMessage => new TerraformReference(this, "error_message");

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    [TerraformPropertyName("index_statistics")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IndexStatistics => new TerraformReference(this, "index_statistics");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServerSideEncryptionConfiguration => new TerraformReference(this, "server_side_encryption_configuration");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdatedAt => new TerraformReference(this, "updated_at");

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    [TerraformPropertyName("user_context_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserContextPolicy => new TerraformReference(this, "user_context_policy");

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    [TerraformPropertyName("user_group_resolution_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserGroupResolutionConfiguration => new TerraformReference(this, "user_group_resolution_configuration");

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    [TerraformPropertyName("user_token_configurations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserTokenConfigurations => new TerraformReference(this, "user_token_configurations");

}
