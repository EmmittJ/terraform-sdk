using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAutomationVariablesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAutomationVariablesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_automation_variables Terraform data source.
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public partial class AzurermAutomationVariablesDataSource(string name) : TerraformDataSource("azurerm_automation_variables", name)
{
    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
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
    /// The bool attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BoolAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "bool").ResolveNodes(ctx));
    }

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Datetime
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "datetime").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Encrypted
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encrypted").ResolveNodes(ctx));
    }

    /// <summary>
    /// The int attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IntAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "int").ResolveNodes(ctx));
    }

    /// <summary>
    /// The null attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NullAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "null").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ObjectAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "object").ResolveNodes(ctx));
    }

    /// <summary>
    /// The string attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StringAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "string").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAutomationVariablesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAutomationVariablesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
