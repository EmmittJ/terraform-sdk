using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_athena_named_query.
/// </summary>
public class AwsAthenaNamedQueryDataSource : TerraformDataSource
{
    public AwsAthenaNamedQueryDataSource(string name) : base("aws_athena_named_query", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The workgroup attribute.
    /// </summary>
    [TerraformPropertyName("workgroup")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Workgroup { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [TerraformPropertyName("database")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Database => new TerraformReference(this, "database");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    [TerraformPropertyName("querystring")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Querystring => new TerraformReference(this, "querystring");

}
