using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermChaosStudioExperiment.
/// Nesting mode: list
/// </summary>
public class AzurermChaosStudioExperimentIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

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
/// Block type for selectors in AzurermChaosStudioExperiment.
/// Nesting mode: list
/// </summary>
public class AzurermChaosStudioExperimentSelectorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selectors";

    /// <summary>
    /// The chaos_studio_target_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChaosStudioTargetIds is required")]
    public TerraformList<string>? ChaosStudioTargetIds
    {
        get => GetArgument<TerraformList<string>>("chaos_studio_target_ids");
        set => SetArgument("chaos_studio_target_ids", value);
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

}


/// <summary>
/// Block type for steps in AzurermChaosStudioExperiment.
/// Nesting mode: list
/// </summary>
public class AzurermChaosStudioExperimentStepsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "steps";

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
    /// Branch block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Branch is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Branch block(s) required")]
    public required TerraformList<AzurermChaosStudioExperimentStepsBlockBranchBlock> Branch
    {
        get => GetRequiredArgument<TerraformList<AzurermChaosStudioExperimentStepsBlockBranchBlock>>("branch");
        set => SetArgument("branch", value);
    }

}

/// <summary>
/// Block type for branch in AzurermChaosStudioExperimentStepsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermChaosStudioExperimentStepsBlockBranchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "branch";

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
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    public required TerraformList<AzurermChaosStudioExperimentStepsBlockBranchBlockActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AzurermChaosStudioExperimentStepsBlockBranchBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for actions in AzurermChaosStudioExperimentStepsBlockBranchBlock.
/// Nesting mode: list
/// </summary>
public class AzurermChaosStudioExperimentStepsBlockBranchBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// The action_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionType is required")]
    public required TerraformValue<string> ActionType
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_type");
        set => SetArgument("action_type", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The selector_name attribute.
    /// </summary>
    public TerraformValue<string>? SelectorName
    {
        get => GetArgument<TerraformValue<string>>("selector_name");
        set => SetArgument("selector_name", value);
    }

    /// <summary>
    /// The urn attribute.
    /// </summary>
    public TerraformValue<string>? Urn
    {
        get => GetArgument<TerraformValue<string>>("urn");
        set => SetArgument("urn", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermChaosStudioExperiment.
/// Nesting mode: single
/// </summary>
public class AzurermChaosStudioExperimentTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_chaos_studio_experiment Terraform resource.
/// Manages a azurerm_chaos_studio_experiment resource.
/// </summary>
public partial class AzurermChaosStudioExperiment(string name) : TerraformResource("azurerm_chaos_studio_experiment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermChaosStudioExperimentIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermChaosStudioExperimentIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Selectors block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Selectors is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Selectors block(s) required")]
    public required TerraformList<AzurermChaosStudioExperimentSelectorsBlock> Selectors
    {
        get => GetRequiredArgument<TerraformList<AzurermChaosStudioExperimentSelectorsBlock>>("selectors");
        set => SetArgument("selectors", value);
    }

    /// <summary>
    /// Steps block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Steps is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Steps block(s) required")]
    public required TerraformList<AzurermChaosStudioExperimentStepsBlock> Steps
    {
        get => GetRequiredArgument<TerraformList<AzurermChaosStudioExperimentStepsBlock>>("steps");
        set => SetArgument("steps", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermChaosStudioExperimentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermChaosStudioExperimentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
