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
    public TerraformSettings? Terraform
    {
        get => _terraform;
        set => _terraform = value;
    }
    private TerraformSettings? _terraform;

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
    /// Compiles all blocks to HCL using two-pass resolution.
    /// Pass 1: Prepare - collect dependencies, validate structure
    /// Pass 2: Resolve - generate HCL
    /// </summary>
    public string ToHcl()
    {
        var context = new TerraformContext(this);

        // Pass 1: Prepare - collect dependencies, track references
        _terraform?.Prepare(context);

        foreach (var block in _blocks)
        {
            using (context.SetCurrentBlock(block))
            {
                if (block is ITerraformPreparable preparable)
                {
                    preparable.Prepare(context);
                }
            }
        }

        // Pass 2: Resolve - generate HCL
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

        // Render all blocks using node resolution
        foreach (var block in _blocks)
        {
            // All blocks resolve to nodes - top-level blocks will resolve to TerraformBlockNode
            var nodes = block.ResolveNodes(context);
            foreach (var node in nodes)
            {
                sb.Append(node.ToHcl(context));
                sb.AppendLine();
            }
        }

        return sb.ToString();
    }

    /// <summary>
    /// Validates the configuration (checks for required values, circular dependencies, etc.).
    /// Returns a ValidationResult containing any errors or warnings found.
    /// </summary>
    public ValidationResult Validate()
    {
        var errors = new List<ValidationError>();

        // Validate terraform block constraints
        if (_terraform != null)
        {
            // Check cloud/backend mutual exclusivity
            if (_terraform.Cloud != null && _terraform.Backend != null)
            {
                errors.Add(new ValidationError(
                    "The 'cloud' and 'backend' blocks are mutually exclusive. Only one can be specified in the terraform block.",
                    ValidationSeverity.Error,
                    null,
                    "terraform"));
            }

            // Check workspaces tags/name mutual exclusivity
            if (_terraform.Cloud?.Workspaces is { } workspaces)
            {
                var hasName = workspaces.Name is not null;
                var hasTags = workspaces.Tags is not null;

                if (hasName && hasTags)
                {
                    errors.Add(new ValidationError(
                        "The 'name' and 'tags' attributes in the workspaces block are mutually exclusive. Only one can be specified.",
                        ValidationSeverity.Error,
                        null,
                        "terraform.cloud.workspaces"));
                }
            }
        }

        // Build dependency graph by preparing all blocks
        var context = new TerraformContext(this);
        _terraform?.Prepare(context);

        foreach (var block in _blocks)
        {
            using (context.SetCurrentBlock(block))
            {
                if (block is ITerraformPreparable preparable)
                {
                    try
                    {
                        preparable.Prepare(context);
                    }
                    catch (Exception ex)
                    {
                        errors.Add(new ValidationError(
                            $"Error during preparation: {ex.Message}",
                            ValidationSeverity.Error,
                            block));
                    }
                }
            }
        }

        // Check for circular dependencies
        var cycles = context.DependencyGraph.FindCycles();
        foreach (var cycle in cycles)
        {
            var cycleDescription = string.Join(" -> ", cycle.Select(GetBlockName));
            errors.Add(new ValidationError(
                $"Circular dependency detected: {cycleDescription} -> {GetBlockName(cycle[0])}",
                ValidationSeverity.Error));
        }

        // Check for duplicate names (resources, data sources, modules, etc.)
        var nameGroups = _blocks
            .Select(c => new
            {
                Block = c,
                BlockType = c.GetType().GetProperty("BlockType")?.GetValue(c) as string,
                Name = c.GetType().GetProperty("ResourceName")?.GetValue(c) as string
                    ?? c.GetType().GetProperty("DataSourceName")?.GetValue(c) as string
                    ?? c.GetType().GetProperty("Name")?.GetValue(c) as string
                    ?? c.GetType().GetProperty("BlockName")?.GetValue(c) as string
            })
            .Where(x => x.BlockType != null && x.Name != null)
            .GroupBy(x => new { x.BlockType, x.Name })
            .Where(g => g.Count() > 1);

        foreach (var group in nameGroups)
        {
            errors.Add(new ValidationError(
                $"Duplicate {group.Key.BlockType} name: '{group.Key.Name}'",
                ValidationSeverity.Error,
                group.First().Block,
                "Name"));
        }

        // Validate reference targets exist within the configuration
        var allBlocks = _blocks.ToHashSet();
        foreach (var block in _blocks)
        {
            var dependencies = context.DependencyGraph.GetDependsOn(block);
            foreach (var dependency in dependencies)
            {
                if (!allBlocks.Contains(dependency))
                {
                    errors.Add(new ValidationError(
                        $"{GetBlockName(block)} references {GetBlockName(dependency)} which is not in the configuration",
                        ValidationSeverity.Error,
                        block));
                }
            }
        }

        return new ValidationResult(errors);
    }

    /// <summary>
    /// Gets a string representation of a block for error messages.
    /// </summary>
    private static string GetBlockName(TerraformBlock block)
    {
        // Try to get BlockType property
        var blockTypeProperty = block.GetType().GetProperty("BlockType");
        var blockType = blockTypeProperty?.GetValue(block) as string ?? block.GetType().Name;

        // Try to get blockName property (from NamedTerraformblock or similar)
        var nameProperty = block.GetType().GetProperty("BlockName");
        if (nameProperty != null)
        {
            var name = nameProperty.GetValue(block);
            if (name != null)
            {
                return $"{blockType}.{name}";
            }
        }

        return blockType;
    }
}
