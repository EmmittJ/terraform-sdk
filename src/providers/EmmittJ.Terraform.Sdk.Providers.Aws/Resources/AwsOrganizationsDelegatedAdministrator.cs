using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_delegated_administrator Terraform resource.
/// Manages a aws_organizations_delegated_administrator resource.
/// </summary>
public partial class AwsOrganizationsDelegatedAdministrator(string name) : TerraformResource("aws_organizations_delegated_administrator", name)
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    public required TerraformValue<string> ServicePrincipal
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    public TerraformValue<string> DelegationEnabledDate
        => CreateReference("delegation_enabled_date");

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformValue<string> JoinedMethod
        => CreateReference("joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformValue<string> JoinedTimestamp
        => CreateReference("joined_timestamp");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
