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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "aws_service_access_principals").ResolveNodes(ctx));
        set => SetArgument("aws_service_access_principals", value);
    }

    /// <summary>
    /// The enabled_policy_types attribute.
    /// </summary>
    public TerraformSet<string>? EnabledPolicyTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_policy_types").ResolveNodes(ctx));
        set => SetArgument("enabled_policy_types", value);
    }

    /// <summary>
    /// The feature_set attribute.
    /// </summary>
    public TerraformValue<string>? FeatureSet
    {
        get => new TerraformReference<string>(this, "feature_set");
        set => SetArgument("feature_set", value);
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
    /// The accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Accounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The master_account_arn attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountArn
    {
        get => new TerraformReference<string>(this, "master_account_arn");
    }

    /// <summary>
    /// The master_account_email attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountEmail
    {
        get => new TerraformReference<string>(this, "master_account_email");
    }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountId
    {
        get => new TerraformReference<string>(this, "master_account_id");
    }

    /// <summary>
    /// The master_account_name attribute.
    /// </summary>
    public TerraformValue<string> MasterAccountName
    {
        get => new TerraformReference<string>(this, "master_account_name");
    }

    /// <summary>
    /// The non_master_accounts attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NonMasterAccounts
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "non_master_accounts").ResolveNodes(ctx));
    }

    /// <summary>
    /// The roots attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Roots
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "roots").ResolveNodes(ctx));
    }

}
