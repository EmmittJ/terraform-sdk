using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for portal_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsoadminApplicationPortalOptionsBlock() : TerraformBlock("portal_options")
{
    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformProperty("visibility")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Visibility { get; set; }

}

/// <summary>
/// Manages a aws_ssoadmin_application resource.
/// </summary>
public partial class AwsSsoadminApplication : TerraformResource
{
    public AwsSsoadminApplication(string name) : base("aws_ssoadmin_application", name)
    {
    }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationProviderArn is required")]
    [TerraformProperty("application_provider_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationProviderArn { get; set; }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformProperty("client_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientToken { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformProperty("instance_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceArn { get; set; }

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
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for portal_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("portal_options")]
    public TerraformList<AwsSsoadminApplicationPortalOptionsBlock> PortalOptions { get; set; } = new();

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    [TerraformProperty("application_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationAccount { get; }

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformProperty("application_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApplicationArn { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
