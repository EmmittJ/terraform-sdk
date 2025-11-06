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
    public string? AcceleratorArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accelerator_arn")?.Value;
        set => this.WithProperty("accelerator_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
