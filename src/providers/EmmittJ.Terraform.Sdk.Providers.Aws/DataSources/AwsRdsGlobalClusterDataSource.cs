using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_global_cluster.
/// </summary>
public partial class AwsRdsGlobalClusterDataSource : TerraformDataSource
{
    public AwsRdsGlobalClusterDataSource(string name) : base("aws_rds_global_cluster", name)
    {
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [TerraformProperty("database_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseName { get; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_lifecycle_support attribute.
    /// </summary>
    [TerraformProperty("engine_lifecycle_support")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineLifecycleSupport { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The members attribute.
    /// </summary>
    [TerraformProperty("members")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Members { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
