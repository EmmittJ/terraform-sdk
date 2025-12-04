using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudtrail_organization_delegated_admin_account Terraform resource.
/// Manages a aws_cloudtrail_organization_delegated_admin_account resource.
/// </summary>
public partial class AwsCloudtrailOrganizationDelegatedAdminAccount(string name) : TerraformResource("aws_cloudtrail_organization_delegated_admin_account", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => AsReference("email");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformValue<string> ServicePrincipal
        => AsReference("service_principal");

}
