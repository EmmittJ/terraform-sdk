namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents lifecycle meta-argument configuration for resources.
/// Controls resource creation, destruction, and change detection behavior.
/// </summary>
/// <remarks>
/// <para>Spec: <see href="https://developer.hashicorp.com/terraform/language/meta-arguments/lifecycle"/></para>
/// </remarks>
public class TerraformLifecycleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lifecycle";

    /// <summary>
    /// Initializes a new instance of the TerraformLifecycleConfig class.
    /// </summary>
    public TerraformLifecycleBlock()
    {
    }

    /// <summary>
    /// Gets or sets whether to create the replacement object before destroying the old one.
    /// </summary>
    public TerraformValue<bool>? CreateBeforeDestroy
    {
        get => GetArgument<TerraformValue<bool>?>("create_before_destroy");
        set => SetArgument("create_before_destroy", value);
    }

    /// <summary>
    /// Gets or sets whether to prevent destruction of this resource.
    /// </summary>
    public TerraformValue<bool>? PreventDestroy
    {
        get => GetArgument<TerraformValue<bool>?>("prevent_destroy");
        set => SetArgument("prevent_destroy", value);
    }

    /// <summary>
    /// Gets or sets a list of attribute names to ignore when planning updates.
    /// </summary>
    public TerraformList<string>? IgnoreChanges
    {
        get => GetArgument<TerraformList<string>?>("ignore_changes");
        set => SetArgument("ignore_changes", value);
    }

    /// <summary>
    /// Gets or sets whether to replace this resource if any of its arguments change.
    /// </summary>
    public TerraformValue<bool>? ReplaceTriggeredBy
    {
        get => GetArgument<TerraformValue<bool>?>("replace_triggered_by");
        set => SetArgument("replace_triggered_by", value);
    }
}
