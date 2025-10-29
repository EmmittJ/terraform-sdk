namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Container for Terraform constructs, similar to Infrastructure in Azure.Provisioning.
/// Manages variables, resources, data sources, and builds the final Terraform configuration.
/// </summary>
public class TerraformConfiguration(string name = "main")
{
    private readonly List<ITerraformConstruct> _constructs = [];
    private readonly string _name = name;

    /// <summary>
    /// Gets the name of this configuration.
    /// </summary>
    public string Name => _name;

    /// <summary>
    /// Adds a construct (variable, resource, data source, etc.) to this configuration.
    /// </summary>
    public void Add(ITerraformConstruct construct)
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
    public IReadOnlyList<ITerraformConstruct> Constructs => _constructs.AsReadOnly();

    /// <summary>
    /// Compiles all constructs to HCL using two-pass resolution.
    /// Pass 1: Prepare - collect dependencies, validate structure
    /// Pass 2: Resolve - generate HCL
    /// </summary>
    public string ToHcl()
    {
        var context = new TerraformContext(this);

        // Pass 1: Prepare - collect dependencies, track references
        foreach (var construct in _constructs)
        {
            if (construct is ITerraformResolvable resolvable)
            {
                context.Prepare(resolvable);
            }
        }

        // Pass 2: Resolve - generate HCL
        var sb = new System.Text.StringBuilder();

        foreach (var construct in _constructs)
        {
            if (construct is ITerraformResolvable resolvable)
            {
                sb.Append(context.Resolve(resolvable));
            }
            else
            {
                // Fallback for non-resolvable constructs
                sb.Append(construct.ToHcl());
            }
            sb.AppendLine();
        }

        return sb.ToString();
    }

    /// <summary>
    /// Validates the configuration (checks for required values, circular dependencies, etc.).
    /// </summary>
    public void Validate()
    {
        // TODO: Implement validation logic
        // - Check for required properties
        // - Detect circular dependencies
        // - Validate references
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
