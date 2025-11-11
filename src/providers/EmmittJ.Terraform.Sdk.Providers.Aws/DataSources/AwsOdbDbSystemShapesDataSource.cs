using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_db_system_shapes.
/// </summary>
public partial class AwsOdbDbSystemShapesDataSource : TerraformDataSource
{
    public AwsOdbDbSystemShapesDataSource(string name) : base("aws_odb_db_system_shapes", name)
    {
    }

    /// <summary>
    /// The physical ID of the AZ, for example, use1-az4. This ID persists across accounts.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityZoneId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The list of shapes and their properties. Information about a hardware system model (shape) that&#39;s available for an Exadata infrastructure.The shape determines resources, such as CPU cores, memory, and storage, to allocate to the Exadata infrastructure.
    /// </summary>
    [TerraformProperty("db_system_shapes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DbSystemShapes { get; }

}
