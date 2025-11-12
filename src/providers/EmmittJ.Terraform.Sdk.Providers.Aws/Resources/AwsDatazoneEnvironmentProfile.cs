using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for user_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatazoneEnvironmentProfileUserParametersBlock() : TerraformBlock("user_parameters")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Manages a aws_datazone_environment_profile resource.
/// </summary>
public partial class AwsDatazoneEnvironmentProfile : TerraformResource
{
    public AwsDatazoneEnvironmentProfile(string name) : base("aws_datazone_environment_profile", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The aws_account_region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsAccountRegion is required")]
    [TerraformProperty("aws_account_region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AwsAccountRegion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    [TerraformProperty("domain_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainIdentifier { get; set; }

    /// <summary>
    /// The environment_blueprint_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintIdentifier is required")]
    [TerraformProperty("environment_blueprint_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnvironmentBlueprintIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectIdentifier is required")]
    [TerraformProperty("project_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for user_parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("user_parameters")]
    public TerraformList<AwsDatazoneEnvironmentProfileUserParametersBlock> UserParameters { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
