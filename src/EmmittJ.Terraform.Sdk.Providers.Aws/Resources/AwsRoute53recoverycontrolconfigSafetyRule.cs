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
    public TerraformProperty<List<string>>? AssertedControls
    {
        get => GetProperty<TerraformProperty<List<string>>>("asserted_controls");
        set => this.WithProperty("asserted_controls", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ControlPanelArn
    {
        get => GetProperty<TerraformProperty<string>>("control_panel_arn");
        set => this.WithProperty("control_panel_arn", value);
    }

    /// <summary>
    /// The gating_controls attribute.
    /// </summary>
    public TerraformProperty<List<string>>? GatingControls
    {
        get => GetProperty<TerraformProperty<List<string>>>("gating_controls");
        set => this.WithProperty("gating_controls", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_controls attribute.
    /// </summary>
    public TerraformProperty<List<string>>? TargetControls
    {
        get => GetProperty<TerraformProperty<List<string>>>("target_controls");
        set => this.WithProperty("target_controls", value);
    }

    /// <summary>
    /// The wait_period_ms attribute.
    /// </summary>
    public TerraformProperty<double>? WaitPeriodMs
    {
        get => GetProperty<TerraformProperty<double>>("wait_period_ms");
        set => this.WithProperty("wait_period_ms", value);
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
