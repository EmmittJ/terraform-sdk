namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a deployable Terraform stack containing related infrastructure blocks.
/// Similar to Infrastructure in Azure.Provisioning or Stack in AWS CDK/Pulumi.
/// Manages variables, resources, data sources, and generates Terraform HCL configuration.
/// </summary>
public class TerraformStack
{
    private readonly List<TerraformBlock> _blocks = [];

    /// <summary>
    /// Gets the name of this configuration.
    /// </summary>
    public string Name { get; set; } = "main";

    /// <summary>
    /// Gets or sets the terraform {} block configuration.
    /// This configures Terraform itself, including backend, required providers, and other settings.
    /// When set, it will be automatically added to the blocks list.
    /// </summary>
    public TerraformSettingsBlock? Terraform
    {
        get => _terraform;
        set => _terraform = value;
    }
    private TerraformSettingsBlock? _terraform;

    /// <summary>
    /// Adds a block (variable, resource, data source, etc.) to this configuration.
    /// </summary>
    public void Add(TerraformBlock block)
    {
        if (block == null)
        {
            throw new ArgumentNullException(nameof(block));
        }

        _blocks.Add(block);
    }

    /// <summary>
    /// Gets all blocks in this configuration.
    /// </summary>
    public IReadOnlyList<TerraformBlock> Blocks => _blocks.AsReadOnly();

    /// <summary>
    /// Compiles all blocks to HCL.
    /// </summary>
    public string ToHcl()
    {
        var context = new TerraformContext(this);
        var sb = new System.Text.StringBuilder();

        // Render terraform block first if present
        if (_terraform != null)
        {
            var terraformNodes = _terraform.ResolveNodes(context);
            foreach (var node in terraformNodes)
            {
                sb.Append(node.ToHcl(context));
            }

            if (_blocks.Count > 0)
            {
                sb.AppendLine();
            }
        }

        // Render all blocks using node resolution with blank lines between blocks
        for (var i = 0; i < _blocks.Count; i++)
        {
            var block = _blocks[i];

            // All blocks resolve to nodes - top-level blocks will resolve to TerraformBlockNode
            var nodes = block.ResolveNodes(context);
            foreach (var node in nodes)
            {
                sb.Append(node.ToHcl(context));
                sb.AppendLine();
            }

            // Add blank line between blocks (but not after the last one)
            if (i < _blocks.Count - 1)
            {
                sb.AppendLine();
            }
        }

        return sb.ToString();
    }
}
