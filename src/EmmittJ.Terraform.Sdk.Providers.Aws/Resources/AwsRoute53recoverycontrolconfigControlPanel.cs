using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoverycontrolconfig_control_panel resource.
/// </summary>
public class AwsRoute53recoverycontrolconfigControlPanel : TerraformResource
{
    public AwsRoute53recoverycontrolconfigControlPanel(string name) : base("aws_route53recoverycontrolconfig_control_panel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_control_panel");
        this.DeclareOutput("routing_control_count");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_arn");
        set => this.WithProperty("cluster_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_control_panel attribute.
    /// </summary>
    public TerraformExpression DefaultControlPanel => this["default_control_panel"];

    /// <summary>
    /// The routing_control_count attribute.
    /// </summary>
    public TerraformExpression RoutingControlCount => this["routing_control_count"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
