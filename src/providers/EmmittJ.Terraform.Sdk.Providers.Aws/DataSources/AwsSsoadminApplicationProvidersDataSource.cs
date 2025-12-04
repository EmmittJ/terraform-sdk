using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_application_providers Terraform data source.
/// Retrieves information about a aws_ssoadmin_application_providers.
/// </summary>
public partial class AwsSsoadminApplicationProvidersDataSource(string name) : TerraformDataSource("aws_ssoadmin_application_providers", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The application_providers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApplicationProviders
        => AsReference("application_providers");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
