using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_registration in .
/// Nesting mode: set
/// </summary>
public partial class AwsQuicksightKeyRegistrationKeyRegistrationBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_key attribute.
    /// </summary>
    [TerraformProperty("default_key")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> DefaultKey { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    [TerraformProperty("key_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyArn { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_key_registration resource.
/// </summary>
public partial class AwsQuicksightKeyRegistration : TerraformResource
{
    public AwsQuicksightKeyRegistration(string name) : base("aws_quicksight_key_registration", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for key_registration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("key_registration")]
    public TerraformSet<TerraformBlock<AwsQuicksightKeyRegistrationKeyRegistrationBlock>>? KeyRegistration { get; set; }

}
