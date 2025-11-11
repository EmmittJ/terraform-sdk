using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_timestreamwrite_table.
/// </summary>
public partial class AwsTimestreamwriteTableDataSource : TerraformDataSource
{
    public AwsTimestreamwriteTableDataSource(string name) : base("aws_timestreamwrite_table", name)
    {
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    [TerraformProperty("last_updated_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedTime { get; }

    /// <summary>
    /// The magnetic_store_write_properties attribute.
    /// </summary>
    [TerraformProperty("magnetic_store_write_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MagneticStoreWriteProperties { get; }

    /// <summary>
    /// The retention_properties attribute.
    /// </summary>
    [TerraformProperty("retention_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RetentionProperties { get; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Schema { get; }

    /// <summary>
    /// The table_status attribute.
    /// </summary>
    [TerraformProperty("table_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TableStatus { get; }

}
