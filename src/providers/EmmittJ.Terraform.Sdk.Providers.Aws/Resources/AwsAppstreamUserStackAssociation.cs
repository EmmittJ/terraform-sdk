using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_user_stack_association resource.
/// </summary>
public partial class AwsAppstreamUserStackAssociation : TerraformResource
{
    public AwsAppstreamUserStackAssociation(string name) : base("aws_appstream_user_stack_association", name)
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The send_email_notification attribute.
    /// </summary>
    [TerraformProperty("send_email_notification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SendEmailNotification { get; set; }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    [TerraformProperty("stack_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StackName { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserName { get; set; }

}
