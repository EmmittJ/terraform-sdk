namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for all Terraform constructs (variables, resources, data sources, etc.).
/// </summary>
public interface ITerraformConstruct
{
    /// <summary>
    /// Gets the expression that references this construct in HCL.
    /// Examples: "var.region", "aws_vpc.main", "data.aws_ami.ubuntu"
    /// </summary>
    /// <returns>The expression that represents a reference to this construct.</returns>
    internal TerraformExpression GetReferenceExpression();

    /// <summary>
    /// Compiles this construct to its HCL representation.
    /// </summary>
    /// <returns>The HCL string for this construct.</returns>
    string ToHcl(int indent = 0);
}
