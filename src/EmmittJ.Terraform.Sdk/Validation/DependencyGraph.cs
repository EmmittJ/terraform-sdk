namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a dependency graph for Terraform blocks.
/// Tracks what each block depends on (depends_on relationship).
/// Provides cycle detection and topological sorting.
/// </summary>
public sealed class DependencyGraph
{
    // Maps each block to the set of blocks it depends on
    // e.g., subnet depends on vpc: _dependsOn[subnet] = { vpc }
    private readonly Dictionary<TerraformBlock, HashSet<TerraformBlock>> _dependsOn = new();

    /// <summary>
    /// Gets all blocks in the dependency graph.
    /// </summary>
    public IReadOnlyCollection<TerraformBlock> Blocks => _dependsOn.Keys;

    /// <summary>
    /// Adds a block to the graph.
    /// </summary>
    /// <param name="block">The block to add.</param>
    public void AddBlock(TerraformBlock block)
    {
        if (!_dependsOn.ContainsKey(block))
        {
            _dependsOn[block] = new HashSet<TerraformBlock>();
        }
    }

    /// <summary>
    /// Records that a block depends on another block.
    /// Think: "dependent depends_on dependency"
    /// Example: subnet depends_on vpc
    /// </summary>
    /// <param name="dependent">The block that has the dependency (e.g., subnet).</param>
    /// <param name="dependency">The block being depended upon (e.g., vpc).</param>
    public void AddDependency(TerraformBlock dependent, TerraformBlock dependency)
    {
        ArgumentNullException.ThrowIfNull(dependent);
        ArgumentNullException.ThrowIfNull(dependency);

        // Ensure both blocks exist in the graph
        AddBlock(dependent);
        AddBlock(dependency);

        // Record: dependent depends_on dependency
        _dependsOn[dependent].Add(dependency);
    }

    /// <summary>
    /// Gets all blocks that this block depends on (its depends_on list).
    /// </summary>
    /// <param name="block">The block to get dependencies for.</param>
    /// <returns>The set of blocks that this block depends on.</returns>
    public IReadOnlySet<TerraformBlock> GetDependsOn(TerraformBlock block)
    {
        return _dependsOn.TryGetValue(block, out var deps)
            ? deps
            : new HashSet<TerraformBlock>();
    }

    /// <summary>
    /// Gets all blocks that depend on this block (reverse lookup).
    /// Useful for understanding impact of changes.
    /// </summary>
    /// <param name="block">The block to find dependents for.</param>
    /// <returns>The set of blocks that depend on this block.</returns>
    public IReadOnlySet<TerraformBlock> GetDependents(TerraformBlock block)
    {
        var dependents = new HashSet<TerraformBlock>();
        foreach (var (dependent, dependencies) in _dependsOn)
        {
            if (dependencies.Contains(block))
            {
                dependents.Add(dependent);
            }
        }
        return dependents;
    }

    /// <summary>
    /// Checks if the graph contains any circular dependencies.
    /// </summary>
    /// <returns>True if cycles exist, false otherwise.</returns>
    public bool HasCycles()
    {
        return FindCycles().Any();
    }

    /// <summary>
    /// Finds all circular dependency chains in the graph.
    /// </summary>
    /// <returns>A collection of circular dependency chains.</returns>
    public IReadOnlyList<IReadOnlyList<TerraformBlock>> FindCycles()
    {
        var cycles = new List<IReadOnlyList<TerraformBlock>>();
        var visited = new HashSet<TerraformBlock>();
        var recursionStack = new HashSet<TerraformBlock>();
        var path = new List<TerraformBlock>();

        foreach (var block in _dependsOn.Keys)
        {
            if (!visited.Contains(block))
            {
                FindCyclesRecursive(block, visited, recursionStack, path, cycles);
            }
        }

        return cycles;
    }

    private void FindCyclesRecursive(
        TerraformBlock block,
        HashSet<TerraformBlock> visited,
        HashSet<TerraformBlock> recursionStack,
        List<TerraformBlock> path,
        List<IReadOnlyList<TerraformBlock>> cycles)
    {
        visited.Add(block);
        recursionStack.Add(block);
        path.Add(block);

        // Follow the depends_on edges
        foreach (var dependency in _dependsOn[block])
        {
            if (!visited.Contains(dependency))
            {
                FindCyclesRecursive(dependency, visited, recursionStack, path, cycles);
            }
            else if (recursionStack.Contains(dependency))
            {
                // Found a cycle - extract the cycle from the path
                var cycleStart = path.IndexOf(dependency);
                var cycle = path.Skip(cycleStart).ToList();
                cycles.Add(cycle);
            }
        }

        path.RemoveAt(path.Count - 1);
        recursionStack.Remove(block);
    }

    /// <summary>
    /// Performs a topological sort of the blocks.
    /// Returns blocks in dependency order (dependencies before dependents).
    /// </summary>
    /// <returns>Topologically sorted blocks.</returns>
    /// <exception cref="TerraformStackException">Thrown if the graph contains cycles.</exception>
    public IReadOnlyList<TerraformBlock> TopologicalSort()
    {
        if (HasCycles())
        {
            var cycles = FindCycles();
            var cycleDescription = string.Join(", ", cycles.First().Select(GetBlockName));
            throw new TerraformStackException(
                $"Cannot perform topological sort: circular dependency detected: {cycleDescription}");
        }

        var result = new List<TerraformBlock>();
        var visited = new HashSet<TerraformBlock>();

        foreach (var block in _dependsOn.Keys)
        {
            if (!visited.Contains(block))
            {
                TopologicalSortRecursive(block, visited, result);
            }
        }

        return result;
    }

    private void TopologicalSortRecursive(
        TerraformBlock block,
        HashSet<TerraformBlock> visited,
        List<TerraformBlock> result)
    {
        visited.Add(block);

        // Visit all dependencies first (things this block depends on)
        foreach (var dependency in _dependsOn[block])
        {
            if (!visited.Contains(dependency))
            {
                TopologicalSortRecursive(dependency, visited, result);
            }
        }

        // Add this block after all its dependencies
        result.Add(block);
    }

    /// <summary>
    /// Gets a string representation of a block for error messages.
    /// </summary>
    private static string GetBlockName(TerraformBlock block)
    {
        return block.BlockLabels.Length > 0
            ? $"{block.BlockType}.{string.Join(".", block.BlockLabels)}"
            : block.BlockType;
    }

    /// <summary>
    /// Gets a human-readable description of the dependency graph.
    /// </summary>
    public string GetDescription()
    {
        var lines = new List<string>
        {
            $"Dependency Graph: {_dependsOn.Count} blocks",
            ""
        };

        foreach (var block in _dependsOn.Keys.OrderBy(GetBlockName))
        {
            var deps = _dependsOn[block];
            if (deps.Any())
            {
                var depNames = string.Join(", ", deps.Select(GetBlockName));
                lines.Add($"  {GetBlockName(block)} depends_on: {depNames}");
            }
            else
            {
                lines.Add($"  {GetBlockName(block)} (no dependencies)");
            }
        }

        return string.Join(Environment.NewLine, lines);
    }
}
