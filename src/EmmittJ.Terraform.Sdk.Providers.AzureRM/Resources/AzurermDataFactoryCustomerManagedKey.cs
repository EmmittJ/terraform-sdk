using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_factory_customer_managed_key resource.
/// </summary>
public class AzurermDataFactoryCustomerManagedKey : TerraformResource
{
    public AzurermDataFactoryCustomerManagedKey(string name) : base("azurerm_data_factory_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerManagedKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key_id");
        set => this.WithProperty("customer_managed_key_id", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataFactoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_factory_id");
        set => this.WithProperty("data_factory_id", value);
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
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_assigned_identity_id");
        set => this.WithProperty("user_assigned_identity_id", value);
    }

}
