using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for rollout_operation in GoogleComputePreviewFeature.
/// Nesting mode: list
/// </summary>
public class GoogleComputePreviewFeatureRolloutOperationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout_operation";

    /// <summary>
    /// RolloutInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutInput block(s) allowed")]
    public TerraformList<GoogleComputePreviewFeatureRolloutOperationBlockRolloutInputBlock>? RolloutInput
    {
        get => GetArgument<TerraformList<GoogleComputePreviewFeatureRolloutOperationBlockRolloutInputBlock>>("rollout_input");
        set => SetArgument("rollout_input", value);
    }

}

/// <summary>
/// Block type for rollout_input in GoogleComputePreviewFeatureRolloutOperationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputePreviewFeatureRolloutOperationBlockRolloutInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rollout_input";

    /// <summary>
    /// Predefined rollout plans. Possible values: [&amp;quot;ROLLOUT_PLAN_FAST_ROLLOUT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PredefinedRolloutPlan is required")]
    public required TerraformValue<string> PredefinedRolloutPlan
    {
        get => GetArgument<TerraformValue<string>>("predefined_rollout_plan");
        set => SetArgument("predefined_rollout_plan", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputePreviewFeature.
/// Nesting mode: single
/// </summary>
public class GoogleComputePreviewFeatureTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_preview_feature Terraform resource.
/// Manages a google_compute_preview_feature resource.
/// </summary>
public partial class GoogleComputePreviewFeature(string name) : TerraformResource("google_compute_preview_feature", name)
{
    /// <summary>
    /// The activation status of the preview feature. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;ACTIVATION_STATE_UNSPECIFIED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActivationStatus is required")]
    public required TerraformValue<string> ActivationStatus
    {
        get => GetArgument<TerraformValue<string>>("activation_status");
        set => SetArgument("activation_status", value);
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
    /// The name of the preview feature.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// RolloutOperation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RolloutOperation block(s) allowed")]
    public TerraformList<GoogleComputePreviewFeatureRolloutOperationBlock>? RolloutOperation
    {
        get => GetArgument<TerraformList<GoogleComputePreviewFeatureRolloutOperationBlock>>("rollout_operation");
        set => SetArgument("rollout_operation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputePreviewFeatureTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputePreviewFeatureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
