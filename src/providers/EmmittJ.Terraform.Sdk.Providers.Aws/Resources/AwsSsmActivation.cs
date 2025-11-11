using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_activation resource.
/// </summary>
public partial class AwsSsmActivation : TerraformResource
{
    public AwsSsmActivation(string name) : base("aws_ssm_activation", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ExpirationDate { get; set; }

    /// <summary>
    /// The iam_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRole is required")]
    [TerraformProperty("iam_role")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IamRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The registration_limit attribute.
    /// </summary>
    [TerraformProperty("registration_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RegistrationLimit { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The activation_code attribute.
    /// </summary>
    [TerraformProperty("activation_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ActivationCode { get; }

    /// <summary>
    /// The expired attribute.
    /// </summary>
    [TerraformProperty("expired")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Expired { get; }

    /// <summary>
    /// The registration_count attribute.
    /// </summary>
    [TerraformProperty("registration_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RegistrationCount { get; }

}
