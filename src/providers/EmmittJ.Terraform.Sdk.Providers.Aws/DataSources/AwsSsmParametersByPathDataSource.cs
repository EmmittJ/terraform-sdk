using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_parameters_by_path.
/// </summary>
public partial class AwsSsmParametersByPathDataSource : TerraformDataSource
{
    public AwsSsmParametersByPathDataSource(string name) : base("aws_ssm_parameters_by_path", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Path { get; set; }

    /// <summary>
    /// The recursive attribute.
    /// </summary>
    [TerraformProperty("recursive")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Recursive { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The with_decryption attribute.
    /// </summary>
    [TerraformProperty("with_decryption")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WithDecryption { get; set; }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Arns { get; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Names { get; }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [TerraformProperty("types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Types { get; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [TerraformProperty("values")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Values { get; }

}
