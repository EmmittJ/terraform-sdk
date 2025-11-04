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

}
