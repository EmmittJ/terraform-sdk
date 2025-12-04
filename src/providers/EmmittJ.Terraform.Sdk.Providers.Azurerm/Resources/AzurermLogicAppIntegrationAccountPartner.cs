using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for business_identity in AzurermLogicAppIntegrationAccountPartner.
/// Nesting mode: set
/// </summary>
public class AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "business_identity";

    /// <summary>
    /// The qualifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Qualifier is required")]
    public required TerraformValue<string> Qualifier
    {
        get => GetArgument<TerraformValue<string>>("qualifier");
        set => SetArgument("qualifier", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLogicAppIntegrationAccountPartner.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_logic_app_integration_account_partner Terraform resource.
/// Manages a azurerm_logic_app_integration_account_partner resource.
/// </summary>
public partial class AzurermLogicAppIntegrationAccountPartner(string name) : TerraformResource("azurerm_logic_app_integration_account_partner", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    public required TerraformValue<string> IntegrationAccountName
    {
        get => GetArgument<TerraformValue<string>>("integration_account_name");
        set => SetArgument("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// BusinessIdentity block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BusinessIdentity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BusinessIdentity block(s) required")]
    public required TerraformSet<AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock> BusinessIdentity
    {
        get => GetRequiredArgument<TerraformSet<AzurermLogicAppIntegrationAccountPartnerBusinessIdentityBlock>>("business_identity");
        set => SetArgument("business_identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppIntegrationAccountPartnerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
