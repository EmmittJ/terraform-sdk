using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_serverlessapplicationrepository_application.
/// </summary>
public partial class AwsServerlessapplicationrepositoryApplicationDataSource : TerraformDataSource
{
    public AwsServerlessapplicationrepositoryApplicationDataSource(string name) : base("aws_serverlessapplicationrepository_application", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

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
    /// The semantic_version attribute.
    /// </summary>
    [TerraformProperty("semantic_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SemanticVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The required_capabilities attribute.
    /// </summary>
    [TerraformProperty("required_capabilities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> RequiredCapabilities { get; }

    /// <summary>
    /// The source_code_url attribute.
    /// </summary>
    [TerraformProperty("source_code_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceCodeUrl { get; }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformProperty("template_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TemplateUrl { get; }

}
