using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for physical_connection_requirements in .
/// Nesting mode: list
/// </summary>
public partial class AwsGlueConnectionPhysicalConnectionRequirementsBlock : TerraformBlockBase
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityZone { get; set; }

    /// <summary>
    /// The security_group_id_list attribute.
    /// </summary>
    [TerraformProperty("security_group_id_list")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIdList { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

}

/// <summary>
/// Manages a aws_glue_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGlueConnection : TerraformResource
{
    public AwsGlueConnection(string name) : base("aws_glue_connection", name)
    {
    }

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    [TerraformProperty("athena_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AthenaProperties { get; set; }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    [TerraformProperty("connection_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ConnectionProperties { get; set; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformProperty("connection_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionType { get; set; }

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
    /// The match_criteria attribute.
    /// </summary>
    [TerraformProperty("match_criteria")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? MatchCriteria { get; set; }

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
    /// Block for physical_connection_requirements.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhysicalConnectionRequirements block(s) allowed")]
    [TerraformProperty("physical_connection_requirements")]
    public partial TerraformList<TerraformBlock<AwsGlueConnectionPhysicalConnectionRequirementsBlock>>? PhysicalConnectionRequirements { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
