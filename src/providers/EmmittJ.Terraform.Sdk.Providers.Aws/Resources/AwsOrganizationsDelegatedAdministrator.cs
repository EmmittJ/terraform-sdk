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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    public required TerraformValue<string> ServicePrincipal
    {
        get => new TerraformReference<string>(this, "service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    public TerraformValue<string> DelegationEnabledDate
    {
        get => new TerraformReference<string>(this, "delegation_enabled_date");
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformValue<string> JoinedMethod
    {
        get => new TerraformReference<string>(this, "joined_method");
    }

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformValue<string> JoinedTimestamp
    {
        get => new TerraformReference<string>(this, "joined_timestamp");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
