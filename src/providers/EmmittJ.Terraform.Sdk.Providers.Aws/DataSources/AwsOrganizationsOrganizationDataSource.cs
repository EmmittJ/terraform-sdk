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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
        => CreateReference("accounts");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    public TerraformSet<string> AwsServiceAccessPrincipals
        => CreateReference("aws_service_access_principals");

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledPolicyTypes
        => CreateReference("enabled_policy_types");

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformValue<string> FeatureSet
        => CreateReference("feature_set");

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountArn
        => CreateReference("master_account_arn");

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountEmail
        => CreateReference("master_account_email");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountId
        => CreateReference("master_account_id");

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountName
        => CreateReference("master_account_name");

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NonMasterAccounts
        => CreateReference("non_master_accounts");

    /// <summary>
    /// The roots attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Roots
        => CreateReference("roots");

}
