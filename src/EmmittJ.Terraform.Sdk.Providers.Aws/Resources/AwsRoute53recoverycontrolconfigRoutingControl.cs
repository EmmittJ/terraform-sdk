using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_routing_control resource.
/// </summary>
public class AwsRoute53recoverycontrolconfigRoutingControl : TerraformResource
{
    public AwsRoute53recoverycontrolconfigRoutingControl(string name) : base("aws_route53recoverycontrolconfig_routing_control", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    public string? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn")?.Value;
        set => this.WithProperty("cluster_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
