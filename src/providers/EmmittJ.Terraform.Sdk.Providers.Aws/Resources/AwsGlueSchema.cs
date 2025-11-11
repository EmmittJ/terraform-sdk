using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_schema resource.
/// </summary>
public partial class AwsGlueSchema : TerraformResource
{
    public AwsGlueSchema(string name) : base("aws_glue_schema", name)
    {
    }

    /// <summary>
    /// The compatibility attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Compatibility is required")]
    [TerraformProperty("compatibility")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Compatibility { get; set; }

    /// <summary>
    /// The data_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFormat is required")]
    [TerraformProperty("data_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFormat { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registry_arn attribute.
    /// </summary>
    [TerraformProperty("registry_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RegistryArn { get; set; }

    /// <summary>
    /// The schema_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaDefinition is required")]
    [TerraformProperty("schema_definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SchemaDefinition { get; set; }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaName is required")]
    [TerraformProperty("schema_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SchemaName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The latest_schema_version attribute.
    /// </summary>
    [TerraformProperty("latest_schema_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LatestSchemaVersion { get; }

    /// <summary>
    /// The next_schema_version attribute.
    /// </summary>
    [TerraformProperty("next_schema_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NextSchemaVersion { get; }

    /// <summary>
    /// The registry_name attribute.
    /// </summary>
    [TerraformProperty("registry_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RegistryName { get; }

    /// <summary>
    /// The schema_checkpoint attribute.
    /// </summary>
    [TerraformProperty("schema_checkpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> SchemaCheckpoint { get; }

}
