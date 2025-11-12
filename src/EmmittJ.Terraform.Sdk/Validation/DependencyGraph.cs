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
    public IReadOnlyCollection<TerraformBlock> Constructs => _dependsOn.Keys;

    /// <summary>
    /// Adds a block to the graph.
    /// </summary>
    /// <param name="construct">The block to add.</param>
    public void AddConstruct(TerraformBlock construct)
    {
        if (!_dependsOn.ContainsKey(construct))
        {
            _dependsOn[construct] = new HashSet<TerraformBlock>();
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
        AddConstruct(dependent);
        AddConstruct(dependency);

        // Record: dependent depends_on dependency
        _dependsOn[dependent].Add(dependency);
    }

    /// <summary>
    /// Gets all blocks that this block depends on (its depends_on list).
    /// </summary>
    /// <param name="construct">The block to get dependencies for.</param>
    /// <returns>The set of blocks that this block depends on.</returns>
    public IReadOnlySet<TerraformBlock> GetDependsOn(TerraformBlock construct)
    {
        return _dependsOn.TryGetValue(construct, out var deps)
            ? deps
            : new HashSet<TerraformBlock>();
    }

    /// <summary>
    /// Gets all blocks that depend on this block (reverse lookup).
    /// Useful for understanding impact of changes.
    /// </summary>
    /// <param name="construct">The block to find dependents for.</param>
    /// <returns>The set of blocks that depend on this block.</returns>
    public IReadOnlySet<TerraformBlock> GetDependents(TerraformBlock construct)
    {
        var dependents = new HashSet<TerraformBlock>();
        foreach (var (dependent, dependencies) in _dependsOn)
        {
            if (dependencies.Contains(construct))
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

        foreach (var construct in _dependsOn.Keys)
        {
            if (!visited.Contains(construct))
            {
                FindCyclesRecursive(construct, visited, recursionStack, path, cycles);
            }
        }

        return cycles;
    }

    private void FindCyclesRecursive(
        TerraformBlock construct,
        HashSet<TerraformBlock> visited,
        HashSet<TerraformBlock> recursionStack,
        List<TerraformBlock> path,
        List<IReadOnlyList<TerraformBlock>> cycles)
    {
        visited.Add(construct);
        recursionStack.Add(construct);
        path.Add(construct);

        // Follow the depends_on edges
        foreach (var dependency in _dependsOn[construct])
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
        recursionStack.Remove(construct);
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
            var cycleDescription = string.Join(", ", cycles.First().Select(GetConstructName));
            throw new TerraformStackException(
                $"Cannot perform topological sort: circular dependency detected: {cycleDescription}");
        }

        var result = new List<TerraformBlock>();
        var visited = new HashSet<TerraformBlock>();

        foreach (var construct in _dependsOn.Keys)
        {
            if (!visited.Contains(construct))
            {
                TopologicalSortRecursive(construct, visited, result);
            }
        }

        return result;
    }

    private void TopologicalSortRecursive(
        TerraformBlock construct,
        HashSet<TerraformBlock> visited,
        List<TerraformBlock> result)
    {
        visited.Add(construct);

        // Visit all dependencies first (things this block depends on)
        foreach (var dependency in _dependsOn[construct])
        {
            if (!visited.Contains(dependency))
            {
                TopologicalSortRecursive(dependency, visited, result);
            }
        }

        // Add this block after all its dependencies
        result.Add(construct);
    }

    /// <summary>
    /// Gets a string representation of a block for error messages.
    /// </summary>
    private static string GetConstructName(TerraformBlock construct)
    {
        var type = construct.GetType().Name;
        var nameProperty = construct.GetType().GetProperty("Name");
        if (nameProperty != null)
        {
            var name = nameProperty.GetValue(construct);
            if (name != null)
            {
                return $"{type}({name})";
            }
        }
        return type;
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

        foreach (var construct in _dependsOn.Keys.OrderBy(GetConstructName))
        {
            var deps = _dependsOn[construct];
            if (deps.Any())
            {
                var depNames = string.Join(", ", deps.Select(GetConstructName));
                lines.Add($"  {GetConstructName(construct)} depends_on: {depNames}");
            }
            else
            {
                lines.Add($"  {GetConstructName(construct)} (no dependencies)");
            }
        }

        return string.Join(Environment.NewLine, lines);
    }
}
