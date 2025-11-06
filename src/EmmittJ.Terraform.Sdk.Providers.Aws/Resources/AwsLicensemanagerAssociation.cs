using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_association resource.
/// </summary>
public class AwsLicensemanagerAssociation : TerraformResource
{
    public AwsLicensemanagerAssociation(string name) : base("aws_licensemanager_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The license_configuration_arn attribute.
    /// </summary>
    public string? LicenseConfigurationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_configuration_arn")?.Value;
        set => this.WithProperty("license_configuration_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
