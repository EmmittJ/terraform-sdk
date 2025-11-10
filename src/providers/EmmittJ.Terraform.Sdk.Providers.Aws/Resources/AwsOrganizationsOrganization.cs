using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_organization resource.
/// </summary>
public class AwsOrganizationsOrganization : TerraformResource
{
    public AwsOrganizationsOrganization(string name) : base("aws_organizations_organization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accounts");
        SetOutput("arn");
        SetOutput("master_account_arn");
        SetOutput("master_account_email");
        SetOutput("master_account_id");
        SetOutput("master_account_name");
        SetOutput("non_master_accounts");
        SetOutput("roots");
        SetOutput("aws_service_access_principals");
        SetOutput("enabled_policy_types");
        SetOutput("feature_set");
        SetOutput("id");
    }

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AwsServiceAccessPrincipals
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("aws_service_access_principals");
        set => SetProperty("aws_service_access_principals", value);
    }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> EnabledPolicyTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("enabled_policy_types");
        set => SetProperty("enabled_policy_types", value);
    }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformProperty<string> FeatureSet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("feature_set");
        set => SetProperty("feature_set", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformExpression Accounts => this["accounts"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    public TerraformExpression MasterAccountArn => this["master_account_arn"];

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    public TerraformExpression MasterAccountEmail => this["master_account_email"];

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformExpression MasterAccountId => this["master_account_id"];

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    public TerraformExpression MasterAccountName => this["master_account_name"];

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    public TerraformExpression NonMasterAccounts => this["non_master_accounts"];

    /// <summary>
    /// The roots attribute.
    /// </summary>
    public TerraformExpression Roots => this["roots"];

}
