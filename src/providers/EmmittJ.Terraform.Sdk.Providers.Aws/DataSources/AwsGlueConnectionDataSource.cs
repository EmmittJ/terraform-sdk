using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_glue_connection.
/// </summary>
public class AwsGlueConnectionDataSource : TerraformDataSource
{
    public AwsGlueConnectionDataSource(string name) : base("aws_glue_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    [TerraformPropertyName("athena_properties")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AthenaProperties => new TerraformReference(this, "athena_properties");

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CatalogId => new TerraformReference(this, "catalog_id");

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    [TerraformPropertyName("connection_properties")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ConnectionProperties => new TerraformReference(this, "connection_properties");

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformPropertyName("connection_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionType => new TerraformReference(this, "connection_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    [TerraformPropertyName("match_criteria")]
    // Output-only attribute - read-only reference
    public TerraformList<string> MatchCriteria => new TerraformReference(this, "match_criteria");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    [TerraformPropertyName("physical_connection_requirements")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PhysicalConnectionRequirements => new TerraformReference(this, "physical_connection_requirements");

}
