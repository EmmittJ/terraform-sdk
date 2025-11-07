using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_management_group_subscription_association resource.
/// </summary>
public class AzurermManagementGroupSubscriptionAssociation : TerraformResource
{
    public AzurermManagementGroupSubscriptionAssociation(string name) : base("azurerm_management_group_subscription_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The management_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
