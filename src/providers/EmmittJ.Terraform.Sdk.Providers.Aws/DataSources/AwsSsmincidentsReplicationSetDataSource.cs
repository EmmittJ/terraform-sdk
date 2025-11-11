using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_replication_set.
/// </summary>
public partial class AwsSsmincidentsReplicationSetDataSource : TerraformDataSource
{
    public AwsSsmincidentsReplicationSetDataSource(string name) : base("aws_ssmincidents_replication_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The deletion_protected attribute.
    /// </summary>
    [TerraformProperty("deletion_protected")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtected { get; }

    /// <summary>
    /// The last_modified_by attribute.
    /// </summary>
    [TerraformProperty("last_modified_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedBy { get; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Region { get; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Regions { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
