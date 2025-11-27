using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_authentication_profile Terraform resource.
/// Manages a aws_redshift_authentication_profile resource.
/// </summary>
public partial class AwsRedshiftAuthenticationProfile(string name) : TerraformResource("aws_redshift_authentication_profile", name)
{
    /// <summary>
    /// The authentication_profile_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileContent is required")]
    public required TerraformValue<string> AuthenticationProfileContent
    {
        get => new TerraformReference<string>(this, "authentication_profile_content");
        set => SetArgument("authentication_profile_content", value);
    }

    /// <summary>
    /// The authentication_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileName is required")]
    public required TerraformValue<string> AuthenticationProfileName
    {
        get => new TerraformReference<string>(this, "authentication_profile_name");
        set => SetArgument("authentication_profile_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
