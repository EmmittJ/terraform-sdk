using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_athena_named_query.
/// </summary>
public partial class AwsAthenaNamedQueryDataSource : TerraformDataSource
{
    public AwsAthenaNamedQueryDataSource(string name) : base("aws_athena_named_query", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workgroup attribute.
    /// </summary>
    [TerraformProperty("workgroup")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Workgroup { get; set; }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [TerraformProperty("database")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Database { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    [TerraformProperty("querystring")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Querystring { get; }

}
