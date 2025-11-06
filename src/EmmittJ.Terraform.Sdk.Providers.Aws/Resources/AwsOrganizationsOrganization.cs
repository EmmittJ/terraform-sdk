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
        this.DeclareOutput("accounts");
        this.DeclareOutput("arn");
        this.DeclareOutput("master_account_arn");
        this.DeclareOutput("master_account_email");
        this.DeclareOutput("master_account_id");
        this.DeclareOutput("master_account_name");
        this.DeclareOutput("non_master_accounts");
        this.DeclareOutput("roots");
    }

    /// <summary>
    /// The aws_service_access_principals attribute.
    /// </summary>
    public HashSet<string>? AwsServiceAccessPrincipals
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("aws_service_access_principals")?.Value;
        set => this.WithProperty("aws_service_access_principals", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public HashSet<string>? EnabledPolicyTypes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_policy_types")?.Value;
        set => this.WithProperty("enabled_policy_types", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public string? FeatureSet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature_set")?.Value;
        set => this.WithProperty("feature_set", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
