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
    /// Compiles all constructs to HCL.
    /// </summary>
    public string ToHcl()
    {
        var sb = new System.Text.StringBuilder();

        foreach (var construct in _constructs)
        {
            sb.Append(construct.ToHcl());
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
