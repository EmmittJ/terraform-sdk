using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_account_suppression_attributes Terraform resource.
/// Manages a aws_sesv2_account_suppression_attributes resource.
/// </summary>
public partial class AwsSesv2AccountSuppressionAttributes(string name) : TerraformResource("aws_sesv2_account_suppression_attributes", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The suppressed_reasons attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SuppressedReasons is required")]
    public required TerraformSet<string> SuppressedReasons
    {
        get => GetRequiredArgument<TerraformSet<string>>("suppressed_reasons");
        set => SetArgument("suppressed_reasons", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
