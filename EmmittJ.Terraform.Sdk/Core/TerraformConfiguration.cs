namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Container for Terraform constructs, similar to Infrastructure in Azure.Provisioning.
/// Manages variables, resources, data sources, and builds the final Terraform configuration.
/// </summary>
public class TerraformConfiguration(string name = "main")
{
    private readonly List<TerraformConstruct> _constructs = [];
    private readonly string _name = name;

    /// <summary>
    /// Gets the name of this configuration.
    /// </summary>
    public string Name => _name;

    /// <summary>
    /// Gets or sets the terraform {} block configuration.
    /// This configures Terraform itself, including backend, required providers, and other settings.
    /// When set, it will be automatically added to the constructs list.
    /// </summary>
    public TerraformConfigurationBlock? Terraform
    {
        get => _terraform;
        set => _terraform = value;
    }
    private TerraformConfigurationBlock? _terraform;

    /// <summary>
    /// Adds a construct (variable, resource, data source, etc.) to this configuration.
    /// </summary>
    public void Add(TerraformConstruct construct)
    {
        if (construct == null)
        {
            throw new ArgumentNullException(nameof(construct));
        }

        _constructs.Add(construct);
    }

    /// <summary>
    /// Gets all constructs in this configuration.
    /// </summary>
    public IReadOnlyList<TerraformConstruct> Constructs => _constructs.AsReadOnly();

    /// <summary>
    /// Compiles all constructs to HCL using two-pass resolution.
    /// Pass 1: Prepare - collect dependencies, validate structure
    /// Pass 2: Resolve - generate HCL
    /// </summary>
    public string ToHcl()
    {
        var context = new TerraformContext(this);

        // Pass 1: Prepare - collect dependencies, track references
        _terraform?.Prepare(context);

        foreach (var construct in _constructs)
        {
            using (context.SetCurrentConstruct(construct))
            {
                if (construct is ITerraformPreparable preparable)
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
            sb.Append(_terraform.ToHcl(context));
            sb.AppendLine();
        }

        // Render all constructs
        foreach (var construct in _constructs)
        {
            sb.Append(construct.Resolve(context));
            sb.AppendLine();
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

        // Build dependency graph by preparing all constructs
        var context = new TerraformContext(this);
        _terraform?.Prepare(context);

        foreach (var construct in _constructs)
        {
            using (context.SetCurrentConstruct(construct))
            {
                if (construct is ITerraformPreparable preparable)
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
                            construct));
                    }
                }
            }
        }

        // Check for circular dependencies
        var cycles = context.DependencyGraph.FindCycles();
        foreach (var cycle in cycles)
        {
            var cycleDescription = string.Join(" -> ", cycle.Select(GetConstructName));
            errors.Add(new ValidationError(
                $"Circular dependency detected: {cycleDescription} -> {GetConstructName(cycle[0])}",
                ValidationSeverity.Error));
        }

        // Check for duplicate names
        var nameGroups = _constructs
            .Select(c => new { Construct = c, Name = TryGetConstructName(c), Type = c.GetType() })
            .Where(x => x.Name != null)
            .GroupBy(x => new { x.Type, x.Name })
            .Where(g => g.Count() > 1);

        foreach (var group in nameGroups)
        {
            var typeName = group.Key.Type.Name;
            errors.Add(new ValidationError(
                $"Duplicate {typeName} name: '{group.Key.Name}'",
                ValidationSeverity.Error,
                group.First().Construct,
                "Name"));
        }

        // Validate reference targets exist within the configuration
        var allConstructs = _constructs.ToHashSet();
        foreach (var construct in _constructs)
        {
            var dependencies = context.DependencyGraph.GetDependsOn(construct);
            foreach (var dependency in dependencies)
            {
                if (!allConstructs.Contains(dependency))
                {
                    errors.Add(new ValidationError(
                        $"{GetConstructName(construct)} references {GetConstructName(dependency)} which is not in the configuration",
                        ValidationSeverity.Error,
                        construct));
                }
            }
        }

        return new ValidationResult(errors);
    }

    /// <summary>
    /// Gets a string representation of a construct for error messages.
    /// </summary>
    private static string GetConstructName(TerraformConstruct construct)
    {
        var type = construct.GetType().Name;
        var name = TryGetConstructName(construct);
        return name != null ? $"{type}({name})" : type;
    }

    /// <summary>
    /// Tries to get the name property from a construct.
    /// </summary>
    private static string? TryGetConstructName(TerraformConstruct construct)
    {
        var nameProperty = construct.GetType().GetProperty("Name");
        return nameProperty?.GetValue(construct) as string;
    }

    /// <summary>
    /// Writes the configuration to a file.
    /// </summary>
    public void WriteToFile(string filePath)
    {
        var hcl = ToHcl();
        File.WriteAllText(filePath, hcl);
    }
}
