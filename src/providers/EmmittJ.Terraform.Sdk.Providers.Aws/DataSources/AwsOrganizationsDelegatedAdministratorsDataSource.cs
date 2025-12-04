using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_delegated_administrators Terraform data source.
/// Retrieves information about a aws_organizations_delegated_administrators.
/// </summary>
public partial class AwsOrganizationsDelegatedAdministratorsDataSource(string name) : TerraformDataSource("aws_organizations_delegated_administrators", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformValue<string>? ServicePrincipal
    {
        get => GetArgument<TerraformValue<string>>("service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DelegatedAdministrators
        => AsReference("delegated_administrators");

}
