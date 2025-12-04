using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for field in AzurermAutomationConnectionType.
/// Nesting mode: list
/// </summary>
public class AzurermAutomationConnectionTypeFieldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field";

    /// <summary>
    /// The is_encrypted attribute.
    /// </summary>
    public TerraformValue<bool>? IsEncrypted
    {
        get => GetArgument<TerraformValue<bool>>("is_encrypted");
        set => SetArgument("is_encrypted", value);
    }

    /// <summary>
    /// The is_optional attribute.
    /// </summary>
    public TerraformValue<bool>? IsOptional
    {
        get => GetArgument<TerraformValue<bool>>("is_optional");
        set => SetArgument("is_optional", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAutomationConnectionType.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationConnectionTypeTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_automation_connection_type Terraform resource.
/// Manages a azurerm_automation_connection_type resource.
/// </summary>
public partial class AzurermAutomationConnectionType(string name) : TerraformResource("azurerm_automation_connection_type", name)
{
    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The is_global attribute.
    /// </summary>
    public TerraformValue<bool>? IsGlobal
    {
        get => GetArgument<TerraformValue<bool>>("is_global");
        set => SetArgument("is_global", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Field block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Field block(s) required")]
    public required TerraformList<AzurermAutomationConnectionTypeFieldBlock> Field
    {
        get => GetRequiredArgument<TerraformList<AzurermAutomationConnectionTypeFieldBlock>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationConnectionTypeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationConnectionTypeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
