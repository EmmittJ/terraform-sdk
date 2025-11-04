using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_controltower_control resource.
/// </summary>
public class AwsControltowerControl : TerraformResource
{
    public AwsControltowerControl(string name) : base("aws_controltower_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The control_identifier attribute.
    /// </summary>
    public string? ControlIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_identifier")?.Value;
        set => this.WithProperty("control_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
