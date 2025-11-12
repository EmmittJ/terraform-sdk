namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Represents a deployable Terraform stack containing related infrastructure constructs.
/// Similar to Infrastructure in Azure.Provisioning or Stack in AWS CDK/Pulumi.
/// Manages variables, resources, data sources, and generates Terraform HCL configuration.
/// </summary>
public class TerraformStack
{
    private readonly List<TerraformBlock> _constructs = [];

    /// <summary>
    /// Gets the name of this configuration.
    /// </summary>
    public string Name { get; set; } = "main";

    /// <summary>
    /// Gets or sets the terraform {} block configuration.
    /// This configures Terraform itself, including backend, required providers, and other settings.
    /// When set, it will be automatically added to the constructs list.
    /// </summary>
    public TerraformSettings? Terraform
    {
        get => _terraform;
        set => _terraform = value;
    }
    private TerraformSettings? _terraform;

    /// <summary>
    /// Adds a construct (variable, resource, data source, etc.) to this configuration.
    /// </summary>
    public void Add(TerraformBlock construct)
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
    public IReadOnlyList<TerraformBlock> Constructs => _constructs.AsReadOnly();

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
            if (_constructs.Count > 0)
            {
                sb.AppendLine();
            }
        }

        // Render all constructs by resolving them to expressions first
        foreach (var construct in _constructs)
        {
            var expression = construct.Resolve(context);
            sb.Append(expression.ToHcl(context));
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
            if (_terraform.Cloud?.Workspaces != null)
            {
                var workspaces = _terraform.Cloud.Workspaces;
                var hasName = !string.IsNullOrWhiteSpace(workspaces.Name);
                var hasTags = workspaces.Tags != null && workspaces.Tags.Count > 0;

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
            .OfType<NamedTerraformConstruct>()
            .GroupBy(c => new { c.BlockType, c.ConstructName })
            .Where(g => g.Count() > 1);

        foreach (var group in nameGroups)
        {
            errors.Add(new ValidationError(
                $"Duplicate {group.Key.BlockType} name: '{group.Key.ConstructName}'",
                ValidationSeverity.Error,
                group.First(),
                "ConstructName"));
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
    /// Gets a string representation of a block for error messages.
    /// </summary>
    private static string GetConstructName(TerraformBlock construct)
    {
        // Try to get BlockType property
        var blockTypeProperty = construct.GetType().GetProperty("BlockType");
        var blockType = blockTypeProperty?.GetValue(construct) as string ?? construct.GetType().Name;

        // Try to get ConstructName property (from NamedTerraformConstruct or similar)
        var nameProperty = construct.GetType().GetProperty("ConstructName");
        if (nameProperty != null)
        {
            var name = nameProperty.GetValue(construct);
            if (name != null)
            {
                return $"{blockType}.{name}";
            }
        }

        return blockType;
    }
}
