using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_organization Terraform data source.
/// Retrieves information about a aws_organizations_organization.
/// </summary>
public partial class AwsOrganizationsOrganizationDataSource(string name) : TerraformDataSource("aws_organizations_organization", name)
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
    /// The aws_service_access_principals attribute.
    /// </summary>
    public TerraformSet<string> AwsServiceAccessPrincipals
        => AsReference("aws_service_access_principals");

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledPolicyTypes
        => AsReference("enabled_policy_types");

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformValue<string> FeatureSet
        => AsReference("feature_set");

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
