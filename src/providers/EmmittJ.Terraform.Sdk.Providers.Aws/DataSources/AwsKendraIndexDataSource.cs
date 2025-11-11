using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_index.
/// </summary>
public partial class AwsKendraIndexDataSource : TerraformDataSource
{
    public AwsKendraIndexDataSource(string name) : base("aws_kendra_index", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [TerraformProperty("capacity_units")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CapacityUnits { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    [TerraformProperty("document_metadata_configuration_updates")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> DocumentMetadataConfigurationUpdates { get; }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    [TerraformProperty("edition")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Edition { get; }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    [TerraformProperty("index_statistics")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IndexStatistics { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RoleArn { get; }

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServerSideEncryptionConfiguration { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    [TerraformProperty("user_context_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserContextPolicy { get; }

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    [TerraformProperty("user_group_resolution_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserGroupResolutionConfiguration { get; }

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    [TerraformProperty("user_token_configurations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> UserTokenConfigurations { get; }

}
