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
    public string? AuthenticationProfileContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_profile_content")?.Value;
        set => this.WithProperty("authentication_profile_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The authentication_profile_name attribute.
    /// </summary>
    public string? AuthenticationProfileName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_profile_name")?.Value;
        set => this.WithProperty("authentication_profile_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
