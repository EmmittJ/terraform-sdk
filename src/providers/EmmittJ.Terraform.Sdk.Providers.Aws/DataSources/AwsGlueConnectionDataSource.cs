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
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The athena_properties attribute.
    /// </summary>
    [TerraformPropertyName("athena_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AthenaProperties => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "athena_properties");

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CatalogId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "catalog_id");

    /// <summary>
    /// The connection_properties attribute.
    /// </summary>
    [TerraformPropertyName("connection_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ConnectionProperties => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "connection_properties");

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    [TerraformPropertyName("connection_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The match_criteria attribute.
    /// </summary>
    [TerraformPropertyName("match_criteria")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> MatchCriteria => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "match_criteria");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The physical_connection_requirements attribute.
    /// </summary>
    [TerraformPropertyName("physical_connection_requirements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PhysicalConnectionRequirements => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "physical_connection_requirements");

}
