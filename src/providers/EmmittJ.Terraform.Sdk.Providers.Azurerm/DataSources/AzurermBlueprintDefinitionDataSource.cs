using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBlueprintDefinitionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermBlueprintDefinitionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_blueprint_definition Terraform data source.
/// Retrieves information about a azurerm_blueprint_definition.
/// </summary>
public partial class AzurermBlueprintDefinitionDataSource(string name) : TerraformDataSource("azurerm_blueprint_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformValue<string> ScopeId
    {
        get => new TerraformReference<string>(this, "scope_id");
        set => SetArgument("scope_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The target_scope attribute.
    /// </summary>
    public TerraformValue<string> TargetScope
    {
        get => new TerraformReference<string>(this, "target_scope");
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
    {
        get => new TerraformReference<string>(this, "time_created");
    }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformList<string> Versions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "versions").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBlueprintDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBlueprintDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
