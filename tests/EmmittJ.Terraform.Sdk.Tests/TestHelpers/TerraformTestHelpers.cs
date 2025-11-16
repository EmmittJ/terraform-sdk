namespace EmmittJ.Terraform.Sdk.Tests.TestHelpers;

/// <summary>
/// Shared helper methods for Terraform SDK tests.
/// </summary>
public static class TerraformTestHelpers
{
    /// <summary>
    /// Creates a test context with a default stack.
    /// </summary>
    public static ITerraformContext CreateContext(string stackName = "test")
    {
        var stack = new TerraformStack { Name = stackName };
        return new TerraformContext(stack);
    }

    /// <summary>
    /// Renders a block to HCL using the SDK's formatting rules.
    /// This mirrors how TerraformStack.ToHcl() renders blocks.
    /// </summary>
    public static string RenderBlock(TerraformBlock block, ITerraformContext context)
    {
        var nodes = block.ResolveNodes(context);
        var sb = new System.Text.StringBuilder();
        foreach (var node in nodes)
        {
            sb.Append(node.ToHcl(context));
        }
        return sb.ToString();
    }

    /// <summary>
    /// Renders a block to HCL with a fresh context.
    /// </summary>
    public static string RenderBlock(TerraformBlock block, string stackName = "test")
    {
        var context = CreateContext(stackName);
        return RenderBlock(block, context);
    }
}
