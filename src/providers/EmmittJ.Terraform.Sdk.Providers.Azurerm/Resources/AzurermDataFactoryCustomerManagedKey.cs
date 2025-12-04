using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataFactoryCustomerManagedKey.
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryCustomerManagedKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory_customer_managed_key Terraform resource.
/// Manages a azurerm_data_factory_customer_managed_key resource.
/// </summary>
public partial class AzurermDataFactoryCustomerManagedKey(string name) : TerraformResource("azurerm_data_factory_customer_managed_key", name)
{
    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerManagedKeyId is required")]
    public required TerraformValue<string> CustomerManagedKeyId
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key_id");
        set => SetArgument("customer_managed_key_id", value);
    }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    public required TerraformValue<string> DataFactoryId
    {
        get => GetArgument<TerraformValue<string>>("data_factory_id");
        set => SetArgument("data_factory_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryCustomerManagedKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
