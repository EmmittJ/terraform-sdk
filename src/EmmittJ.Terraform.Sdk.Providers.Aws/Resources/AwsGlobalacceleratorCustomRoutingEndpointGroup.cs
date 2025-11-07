using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_endpoint_group resource.
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingEndpointGroup(string name) : base("aws_globalaccelerator_custom_routing_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointGroupRegion
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_group_region");
        set => this.WithProperty("endpoint_group_region", value);
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
    /// The listener_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ListenerArn
    {
        get => GetProperty<TerraformProperty<string>>("listener_arn");
        set => this.WithProperty("listener_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
