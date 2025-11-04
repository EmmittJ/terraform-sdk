using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_safety_rule resource.
/// </summary>
public class AwsRoute53recoverycontrolconfigSafetyRule : TerraformResource
{
    public AwsRoute53recoverycontrolconfigSafetyRule(string name) : base("aws_route53recoverycontrolconfig_safety_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The asserted_controls attribute.
    /// </summary>
    public List<string>? AssertedControls
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("asserted_controls")?.Value;
        set => this.WithProperty("asserted_controls", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    public string? ControlPanelArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_panel_arn")?.Value;
        set => this.WithProperty("control_panel_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public List<string>? GatingControls
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("gating_controls")?.Value;
        set => this.WithProperty("gating_controls", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_controls attribute.
    /// </summary>
    public List<string>? TargetControls
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("target_controls")?.Value;
        set => this.WithProperty("target_controls", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    public double? WaitPeriodMs
    {
        get => GetProperty<TerraformLiteralProperty<double>>("wait_period_ms")?.Value;
        set => this.WithProperty("wait_period_ms", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
