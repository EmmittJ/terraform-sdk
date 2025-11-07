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
    }

    /// <summary>
    /// The authentication_profile_content attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationProfileContent
    {
        get => GetProperty<TerraformProperty<string>>("authentication_profile_content");
        set => this.WithProperty("authentication_profile_content", value);
    }

    /// <summary>
    /// The authentication_profile_name attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationProfileName
    {
        get => GetProperty<TerraformProperty<string>>("authentication_profile_name");
        set => this.WithProperty("authentication_profile_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
