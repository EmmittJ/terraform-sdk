using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_registration_code Terraform data source.
/// Retrieves information about a aws_iot_registration_code.
/// </summary>
public partial class AwsIotRegistrationCodeDataSource(string name) : TerraformDataSource("aws_iot_registration_code", name)
{
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

    /// <summary>
    /// The registration_code attribute.
    /// </summary>
    public TerraformValue<string> RegistrationCode
    {
        get => new TerraformReference<string>(this, "registration_code");
    }

}
