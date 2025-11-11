using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_docdb_orderable_db_instance.
/// </summary>
public class AwsDocdbOrderableDbInstanceDataSource : TerraformDataSource
{
    public AwsDocdbOrderableDbInstanceDataSource(string name) : base("aws_docdb_orderable_db_instance", name)
    {
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EngineVersion { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [TerraformPropertyName("instance_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> InstanceClass { get; set; } = default!;

    /// <summary>
    /// The license_model attribute.
    /// </summary>
    [TerraformPropertyName("license_model")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LicenseModel { get; set; }

    /// <summary>
    /// The preferred_instance_classes attribute.
    /// </summary>
    [TerraformPropertyName("preferred_instance_classes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? PreferredInstanceClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The vpc attribute.
    /// </summary>
    [TerraformPropertyName("vpc")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Vpc { get; set; } = default!;

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AvailabilityZones => new TerraformReference(this, "availability_zones");

}
