using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_account resource.
/// </summary>
public class AwsSecurityhubAccount : TerraformResource
{
    public AwsSecurityhubAccount(string name) : base("aws_securityhub_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The auto_enable_controls attribute.
    /// </summary>
    public bool? AutoEnableControls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_enable_controls")?.Value;
        set => this.WithProperty("auto_enable_controls", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The control_finding_generator attribute.
    /// </summary>
    public string? ControlFindingGenerator
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_finding_generator")?.Value;
        set => this.WithProperty("control_finding_generator", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_default_standards attribute.
    /// </summary>
    public bool? EnableDefaultStandards
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_default_standards")?.Value;
        set => this.WithProperty("enable_default_standards", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
