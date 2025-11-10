using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsGlueSecurityConfigurationEncryptionConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_glue_security_configuration resource.
/// </summary>
public class AwsGlueSecurityConfiguration : TerraformResource
{
    public AwsGlueSecurityConfiguration(string name) : base("aws_glue_security_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsGlueSecurityConfigurationEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsGlueSecurityConfigurationEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

}
