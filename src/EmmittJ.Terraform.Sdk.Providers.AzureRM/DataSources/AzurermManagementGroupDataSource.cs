using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_management_group.
/// </summary>
public class AzurermManagementGroupDataSource : TerraformDataSource
{
    public AzurermManagementGroupDataSource(string name) : base("azurerm_management_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("all_management_group_ids");
        this.DeclareOutput("all_subscription_ids");
        this.DeclareOutput("management_group_ids");
        this.DeclareOutput("parent_management_group_id");
        this.DeclareOutput("subscription_ids");
        this.DeclareOutput("tenant_scoped_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    public TerraformExpression AllManagementGroupIds => this["all_management_group_ids"];

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    public TerraformExpression AllSubscriptionIds => this["all_subscription_ids"];

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    public TerraformExpression ManagementGroupIds => this["management_group_ids"];

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformExpression ParentManagementGroupId => this["parent_management_group_id"];

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformExpression SubscriptionIds => this["subscription_ids"];

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformExpression TenantScopedId => this["tenant_scoped_id"];

}
