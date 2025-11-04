using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_controltower_controls.
/// </summary>
public class AwsControltowerControlsDataSource : TerraformDataSource
{
    public AwsControltowerControlsDataSource(string name) : base("aws_controltower_controls", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("enabled_controls");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_identifier attribute.
    /// </summary>
    public string? TargetIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_identifier")?.Value;
        set => this.WithProperty("target_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled_controls attribute.
    /// </summary>
    public TerraformExpression EnabledControls => this["enabled_controls"];

}
