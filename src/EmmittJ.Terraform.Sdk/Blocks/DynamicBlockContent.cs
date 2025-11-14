namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Helper class for creating untyped dynamic block content when you don't have a generated block type.
/// This class provides a way to dynamically configure properties on a dynamic block's content
/// without needing a strongly-typed nested block class.
/// </summary>
/// <example>
/// // Create dynamic block for "setting" without a SettingBlock class
/// var content = new DynamicBlockContent("setting");
/// content.SetPropertyValue("namespace", TerraformExpression.Identifier("setting.value.namespace"));
/// content.SetPropertyValue("name", TerraformExpression.Identifier("setting.value.name"));
/// var dynamicBlock = new TerraformDynamicBlock(content, var.settings);
/// </example>
public class DynamicBlockContent : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType { get; }

    /// <summary>
    /// Creates a new DynamicBlockContent with the specified block type.
    /// </summary>
    /// <param name="blockType">The type of block being generated (e.g., "setting", "ingress", "egress")</param>
    public DynamicBlockContent(string blockType)
    {
        BlockType = blockType ?? throw new ArgumentNullException(nameof(blockType));
    }
}
