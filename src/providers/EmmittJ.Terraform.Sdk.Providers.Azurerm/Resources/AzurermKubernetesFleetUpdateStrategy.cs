using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for stage in AzurermKubernetesFleetUpdateStrategy.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateStrategyStageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stage";

    /// <summary>
    /// The after_stage_wait_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? AfterStageWaitInSeconds
    {
        get => new TerraformReference<double>(this, "after_stage_wait_in_seconds");
        set => SetArgument("after_stage_wait_in_seconds", value);
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
    /// Group block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Group block(s) required")]
    public required TerraformList<AzurermKubernetesFleetUpdateStrategyStageBlockGroupBlock> Group
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesFleetUpdateStrategyStageBlockGroupBlock>>("group");
        set => SetArgument("group", value);
    }

}

/// <summary>
/// Block type for group in AzurermKubernetesFleetUpdateStrategyStageBlock.
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesFleetUpdateStrategyStageBlockGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesFleetUpdateStrategy.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFleetUpdateStrategyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_fleet_update_strategy Terraform resource.
/// Manages a azurerm_kubernetes_fleet_update_strategy resource.
/// </summary>
public partial class AzurermKubernetesFleetUpdateStrategy(string name) : TerraformResource("azurerm_kubernetes_fleet_update_strategy", name)
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
    /// The kubernetes_fleet_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetManagerId is required")]
    public required TerraformValue<string> KubernetesFleetManagerId
    {
        get => new TerraformReference<string>(this, "kubernetes_fleet_manager_id");
        set => SetArgument("kubernetes_fleet_manager_id", value);
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
    /// Stage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Stage block(s) required")]
    public required TerraformList<AzurermKubernetesFleetUpdateStrategyStageBlock> Stage
    {
        get => GetRequiredArgument<TerraformList<AzurermKubernetesFleetUpdateStrategyStageBlock>>("stage");
        set => SetArgument("stage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesFleetUpdateStrategyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesFleetUpdateStrategyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
