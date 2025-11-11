using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_connection.
/// </summary>
public partial class AwsGlueConnectionDataSource : TerraformDataSource
{
    public AwsGlueConnectionDataSource(string name) : base("aws_glue_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    [TerraformProperty("athena_properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> AthenaProperties { get; }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CatalogId { get; }

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    [TerraformProperty("connection_properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> ConnectionProperties { get; }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformProperty("connection_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionType { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    [TerraformProperty("match_criteria")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> MatchCriteria { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    [TerraformProperty("physical_connection_requirements")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PhysicalConnectionRequirements { get; }

}
