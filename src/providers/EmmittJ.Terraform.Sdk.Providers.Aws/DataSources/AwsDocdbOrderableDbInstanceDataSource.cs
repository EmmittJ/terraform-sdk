using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_orderable_db_instance.
/// </summary>
public partial class AwsDocdbOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsDocdbOrderableDbInstanceDataSource(string name) : base("aws_docdb_orderable_db_instance", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [TerraformProperty("instance_class")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformProperty("license_model")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LicenseModel { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformProperty("preferred_instance_classes")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    [TerraformProperty("vpc")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Vpc { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformProperty("availability_zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AvailabilityZones { get; }

}
