using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_delegated_services Terraform data source.
/// Retrieves information about a aws_organizations_delegated_services.
/// </summary>
public partial class AwsOrganizationsDelegatedServicesDataSource(string name) : TerraformDataSource("aws_organizations_delegated_services", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The delegated_services attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DelegatedServices
        => AsReference("delegated_services");

}
