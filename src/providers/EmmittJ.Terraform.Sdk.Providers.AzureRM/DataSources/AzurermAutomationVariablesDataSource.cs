using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_automation_variables.
/// </summary>
public class AzurermAutomationVariablesDataSource : TerraformDataSource
{
    public AzurermAutomationVariablesDataSource(string name) : base("azurerm_automation_variables", name)
    {
    }

    /// <summary>
    /// The automation_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountId is required")]
    [TerraformArgument("automation_account_id")]
    public required TerraformValue<string> AutomationAccountId
    {
        get => new TerraformReference<string>(this, "automation_account_id");
        set => SetArgument("automation_account_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationVariablesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The bool attribute.
    /// </summary>
    [TerraformArgument("bool")]
    public TerraformList<object> Bool
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "bool").ResolveNodes(ctx));
    }

    /// <summary>
    /// The datetime attribute.
    /// </summary>
    [TerraformArgument("datetime")]
    public TerraformList<object> Datetime
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "datetime").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformArgument("encrypted")]
    public TerraformList<object> Encrypted
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "encrypted").ResolveNodes(ctx));
    }

    /// <summary>
    /// The int attribute.
    /// </summary>
    [TerraformArgument("int")]
    public TerraformList<object> Int
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "int").ResolveNodes(ctx));
    }

    /// <summary>
    /// The null attribute.
    /// </summary>
    [TerraformArgument("null")]
    public TerraformList<object> Null
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "null").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [TerraformArgument("object")]
    public TerraformList<object> Object
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "object").ResolveNodes(ctx));
    }

    /// <summary>
    /// The string attribute.
    /// </summary>
    [TerraformArgument("string")]
    public TerraformList<object> String
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "string").ResolveNodes(ctx));
    }

}
