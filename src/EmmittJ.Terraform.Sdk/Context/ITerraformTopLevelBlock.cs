namespace EmmittJ.Terraform.Sdk;

/// <summary>
/// Marker interface for top-level Terraform blocks that have identifiable labels.
/// Provides unified access to block identity without reflection.
/// Aligns with Terraform's configuration syntax terminology.
/// </summary>
/// <remarks>
/// Top-level blocks appear at the root of a Terraform configuration file.
/// Each has a block type keyword and optional labels.
/// For example: resource "aws_instance" "example" { }
/// - Block type: "resource"
/// - Labels: ["aws_instance", "example"]
///
/// This interface applies to: resource, data, module, variable, output, locals, terraform, provider, etc.
/// It does NOT apply to nested blocks like lifecycle, connection, provisioner, etc.
/// </remarks>
public interface ITerraformTopLevelBlock
{
    /// <summary>
    /// Gets the block type keyword (e.g., "resource", "data", "module", "variable", "output").
    /// Used for display and validation messages.
    /// </summary>
    string BlockType { get; }

    /// <summary>
    /// Gets the labels for this top-level block.
    /// For resources: ["aws_instance", "example"] from resource "aws_instance" "example"
    /// For data sources: ["aws_instance", "example"] from data "aws_instance" "example"
    /// For modules/variables/outputs: ["name"] (single label)
    /// </summary>
    string[] BlockLabels { get; }
}
