using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_organization.
/// </summary>
public class AwsOrganizationsOrganizationDataSource : TerraformDataSource
{
    public AwsOrganizationsOrganizationDataSource(string name) : base("aws_organizations_organization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accounts");
        this.DeclareOutput("arn");
        this.DeclareOutput("aws_service_access_principals");
        this.DeclareOutput("enabled_policy_types");
        this.DeclareOutput("feature_set");
        this.DeclareOutput("master_account_arn");
        this.DeclareOutput("master_account_email");
        this.DeclareOutput("master_account_id");
        this.DeclareOutput("master_account_name");
        this.DeclareOutput("non_master_accounts");
        this.DeclareOutput("roots");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
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
    /// The aws_service_access_principals attribute.
    /// </summary>
    public TerraformExpression AwsServiceAccessPrincipals => this["aws_service_access_principals"];

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public TerraformExpression EnabledPolicyTypes => this["enabled_policy_types"];

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformExpression FeatureSet => this["feature_set"];

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
