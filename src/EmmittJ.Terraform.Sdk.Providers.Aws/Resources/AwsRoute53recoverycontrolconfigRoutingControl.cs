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
    public TerraformProperty<string>? ClusterArn
    {
        get => GetProperty<TerraformProperty<string>>("cluster_arn");
        set => this.WithProperty("cluster_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
