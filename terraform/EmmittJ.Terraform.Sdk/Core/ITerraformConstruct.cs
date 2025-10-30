namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Base interface for all Terraform constructs (variables, resources, data sources, etc.).
/// </summary>
public interface ITerraformConstruct : ITerraformResolvable
{
    /// <summary>
    /// Gets the expression that references this construct in HCL.
    /// Examples: "var.region", "aws_vpc.main", "data.aws_ami.ubuntu"
    /// </summary>
    /// <returns>The expression that represents a reference to this construct.</returns>
    internal TerraformExpression GetReferenceExpression();
}
