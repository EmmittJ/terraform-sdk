using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformProperty<double> FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => WithProperty("from_port", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public HashSet<TerraformProperty<string>>? Protocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("protocols");
        set => WithProperty("protocols", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => WithProperty("to_port", value);
    }

}

/// <summary>
/// Block type for endpoint_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointId
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_id");
        set => WithProperty("endpoint_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformProperty<string> ListenerArn
    {
        get => GetProperty<TerraformProperty<string>>("listener_arn");
        set => this.WithProperty("listener_arn", value);
    }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    public HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>? DestinationConfiguration
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>>("destination_configuration");
        set => this.WithProperty("destination_configuration", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>>("endpoint_configuration");
        set => this.WithProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
