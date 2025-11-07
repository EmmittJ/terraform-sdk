using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_listener resource.
/// </summary>
public class AwsGlobalacceleratorCustomRoutingListener : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingListener(string name) : base("aws_globalaccelerator_custom_routing_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The accelerator_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AcceleratorArn
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_arn");
        set => this.WithProperty("accelerator_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
