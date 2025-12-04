using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_organization Terraform resource.
/// Manages a aws_organizations_organization resource.
/// </summary>
public partial class AwsOrganizationsOrganization(string name) : TerraformResource("aws_organizations_organization", name)
{
    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    public TerraformSet<string>? AwsServiceAccessPrincipals
    {
        get => GetArgument<TerraformSet<string>>("aws_service_access_principals");
        set => SetArgument("aws_service_access_principals", value);
    }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public TerraformSet<string>? EnabledPolicyTypes
    {
        get => GetArgument<TerraformSet<string>>("enabled_policy_types");
        set => SetArgument("enabled_policy_types", value);
    }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformValue<string>? FeatureSet
    {
        get => GetArgument<TerraformValue<string>>("feature_set");
        set => SetArgument("feature_set", value);
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
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
        => AsReference("accounts");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountArn
        => AsReference("master_account_arn");

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountEmail
        => AsReference("master_account_email");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountId
        => AsReference("master_account_id");

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountName
        => AsReference("master_account_name");

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NonMasterAccounts
        => AsReference("non_master_accounts");

    /// <summary>
    /// The roots attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Roots
        => AsReference("roots");

}
