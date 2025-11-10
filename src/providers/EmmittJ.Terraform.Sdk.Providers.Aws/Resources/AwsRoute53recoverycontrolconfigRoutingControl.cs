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
        SetOutput("arn");
        SetOutput("status");
        SetOutput("cluster_arn");
        SetOutput("control_panel_arn");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformProperty<string> ClusterArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_arn");
        set => SetProperty("cluster_arn", value);
    }

    /// <summary>
    /// The control_panel_arn attribute.
    /// </summary>
    public TerraformProperty<string> ControlPanelArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_panel_arn");
        set => SetProperty("control_panel_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
