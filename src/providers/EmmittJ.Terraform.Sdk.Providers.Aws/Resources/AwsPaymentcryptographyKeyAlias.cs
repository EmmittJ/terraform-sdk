using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_paymentcryptography_key_alias Terraform resource.
/// Manages a aws_paymentcryptography_key_alias resource.
/// </summary>
public partial class AwsPaymentcryptographyKeyAlias(string name) : TerraformResource("aws_paymentcryptography_key_alias", name)
{
    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasName is required")]
    public required TerraformValue<string> AliasName
    {
        get => GetRequiredArgument<TerraformValue<string>>("alias_name");
        set => SetArgument("alias_name", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KeyArn
    {
        get => GetArgument<TerraformValue<string>>("key_arn");
        set => SetArgument("key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
