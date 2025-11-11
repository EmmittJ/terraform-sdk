using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssm_document.
/// </summary>
public partial class AwsSsmDocumentDataSource : TerraformDataSource
{
    public AwsSsmDocumentDataSource(string name) : base("aws_ssm_document", name)
    {
    }

    /// <summary>
    /// The document_format attribute.
    /// </summary>
    [TerraformProperty("document_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DocumentFormat { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformProperty("document_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DocumentVersion { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Content { get; }

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    [TerraformProperty("document_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DocumentType { get; }

}
