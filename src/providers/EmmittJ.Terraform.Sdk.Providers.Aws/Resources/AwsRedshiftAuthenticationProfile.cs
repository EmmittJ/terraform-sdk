using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_authentication_profile resource.
/// </summary>
public class AwsRedshiftAuthenticationProfile : TerraformResource
{
    public AwsRedshiftAuthenticationProfile(string name) : base("aws_redshift_authentication_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication_profile_content");
        SetOutput("authentication_profile_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The authentication_profile_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileContent is required")]
    public required TerraformProperty<string> AuthenticationProfileContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_profile_content");
        set => SetProperty("authentication_profile_content", value);
    }

    /// <summary>
    /// The authentication_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProfileName is required")]
    public required TerraformProperty<string> AuthenticationProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_profile_name");
        set => SetProperty("authentication_profile_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

}
