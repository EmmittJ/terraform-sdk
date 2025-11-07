using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_instance_logging_configuration resource.
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfiguration : TerraformResource
{
    public AwsVerifiedaccessInstanceLoggingConfiguration(string name) : base("aws_verifiedaccess_instance_logging_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? VerifiedaccessInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => this.WithProperty("verifiedaccess_instance_id", value);
    }

}
