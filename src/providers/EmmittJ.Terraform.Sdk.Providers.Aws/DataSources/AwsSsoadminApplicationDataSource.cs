using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssoadmin_application.
/// </summary>
public partial class AwsSsoadminApplicationDataSource : TerraformDataSource
{
    public AwsSsoadminApplicationDataSource(string name) : base("aws_ssoadmin_application", name)
    {
    }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    [TerraformProperty("application_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    [TerraformProperty("application_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationAccount { get; }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [TerraformProperty("application_provider_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationProviderArn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [TerraformProperty("instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceArn { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The portal_options attribute.
    /// </summary>
    [TerraformProperty("portal_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PortalOptions { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
