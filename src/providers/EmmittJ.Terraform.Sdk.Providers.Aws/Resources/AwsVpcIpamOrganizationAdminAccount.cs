using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc_ipam_organization_admin_account Terraform resource.
/// Manages a aws_vpc_ipam_organization_admin_account resource.
/// </summary>
public partial class AwsVpcIpamOrganizationAdminAccount(string name) : TerraformResource("aws_vpc_ipam_organization_admin_account", name)
{
    /// <summary>
    /// The delegated_admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedAdminAccountId is required")]
    public required TerraformValue<string> DelegatedAdminAccountId
    {
        get => GetArgument<TerraformValue<string>>("delegated_admin_account_id");
        set => SetArgument("delegated_admin_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
