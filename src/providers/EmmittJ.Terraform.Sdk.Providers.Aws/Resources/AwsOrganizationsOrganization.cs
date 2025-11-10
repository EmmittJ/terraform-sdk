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
        this.WithOutput("accounts");
        this.WithOutput("arn");
        this.WithOutput("master_account_arn");
        this.WithOutput("master_account_email");
        this.WithOutput("master_account_id");
        this.WithOutput("master_account_name");
        this.WithOutput("non_master_accounts");
        this.WithOutput("roots");
    }

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AwsServiceAccessPrincipals
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("aws_service_access_principals");
        set => this.WithProperty("aws_service_access_principals", value);
    }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EnabledPolicyTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_policy_types");
        set => this.WithProperty("enabled_policy_types", value);
    }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformProperty<string>? FeatureSet
    {
        get => GetProperty<TerraformProperty<string>>("feature_set");
        set => this.WithProperty("feature_set", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
