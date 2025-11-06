namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a dependency graph for Terraform constructs.
/// Tracks what each construct depends on (depends_on relationship).
/// Provides cycle detection and topological sorting.
/// </summary>
public sealed class DependencyGraph
{
    // Maps each construct to the set of constructs it depends on
    // e.g., subnet depends on vpc: _dependsOn[subnet] = { vpc }
    private readonly Dictionary<TerraformConstruct, HashSet<TerraformConstruct>> _dependsOn = new();

    /// <summary>
    /// Gets all constructs in the dependency graph.
    /// </summary>
    public IReadOnlyCollection<TerraformConstruct> Constructs => _dependsOn.Keys;

    /// <summary>
    /// Adds a construct to the graph.
    /// </summary>
    /// <param name="construct">The construct to add.</param>
    public void AddConstruct(TerraformConstruct construct)
    {
        if (!_dependsOn.ContainsKey(construct))
        {
            _dependsOn[construct] = new HashSet<TerraformConstruct>();
        }
    }

    /// <summary>
    /// Records that a construct depends on another construct.
    /// Think: "dependent depends_on dependency"
    /// Example: subnet depends_on vpc
    /// </summary>
    /// <param name="dependent">The construct that has the dependency (e.g., subnet).</param>
    /// <param name="dependency">The construct being depended upon (e.g., vpc).</param>
    public void AddDependency(TerraformConstruct dependent, TerraformConstruct dependency)
    {
        ArgumentNullException.ThrowIfNull(dependent);
        ArgumentNullException.ThrowIfNull(dependency);

        // Ensure both constructs exist in the graph
        AddConstruct(dependent);
        AddConstruct(dependency);

        // Record: dependent depends_on dependency
        _dependsOn[dependent].Add(dependency);
    }

    /// <summary>
    /// Gets all constructs that this construct depends on (its depends_on list).
    /// </summary>
    /// <param name="construct">The construct to get dependencies for.</param>
    /// <returns>The set of constructs that this construct depends on.</returns>
    public IReadOnlySet<TerraformConstruct> GetDependsOn(TerraformConstruct construct)
    {
        return _dependsOn.TryGetValue(construct, out var deps)
            ? deps
            : new HashSet<TerraformConstruct>();
    }

    /// <summary>
    /// Gets all constructs that depend on this construct (reverse lookup).
    /// Useful for understanding impact of changes.
    /// </summary>
    /// <param name="construct">The construct to find dependents for.</param>
    /// <returns>The set of constructs that depend on this construct.</returns>
    public IReadOnlySet<TerraformConstruct> GetDependents(TerraformConstruct construct)
    {
        var dependents = new HashSet<TerraformConstruct>();
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
    public IReadOnlyList<IReadOnlyList<TerraformConstruct>> FindCycles()
    {
        var cycles = new List<IReadOnlyList<TerraformConstruct>>();
        var visited = new HashSet<TerraformConstruct>();
        var recursionStack = new HashSet<TerraformConstruct>();
        var path = new List<TerraformConstruct>();

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
        TerraformConstruct construct,
        HashSet<TerraformConstruct> visited,
        HashSet<TerraformConstruct> recursionStack,
        List<TerraformConstruct> path,
        List<IReadOnlyList<TerraformConstruct>> cycles)
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
    /// Performs a topological sort of the constructs.
    /// Returns constructs in dependency order (dependencies before dependents).
    /// </summary>
    /// <returns>Topologically sorted constructs.</returns>
    /// <exception cref="TerraformStackException">Thrown if the graph contains cycles.</exception>
    public IReadOnlyList<TerraformConstruct> TopologicalSort()
    {
        if (HasCycles())
        {
            var cycles = FindCycles();
            var cycleDescription = string.Join(", ", cycles.First().Select(GetConstructName));
            throw new TerraformStackException(
                $"Cannot perform topological sort: circular dependency detected: {cycleDescription}");
        }

        var result = new List<TerraformConstruct>();
        var visited = new HashSet<TerraformConstruct>();

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
        TerraformConstruct construct,
        HashSet<TerraformConstruct> visited,
        List<TerraformConstruct> result)
    {
        visited.Add(construct);

        // Visit all dependencies first (things this construct depends on)
        foreach (var dependency in _dependsOn[construct])
        {
            if (!visited.Contains(dependency))
            {
                TopologicalSortRecursive(dependency, visited, result);
            }
        }

        // Add this construct after all its dependencies
        result.Add(construct);
    }

    /// <summary>
    /// Gets a string representation of a construct for error messages.
    /// </summary>
    private static string GetConstructName(TerraformConstruct construct)
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
            $"Dependency Graph: {_dependsOn.Count} constructs",
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
