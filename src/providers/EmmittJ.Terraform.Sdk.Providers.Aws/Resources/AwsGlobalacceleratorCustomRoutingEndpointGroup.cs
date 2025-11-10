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
        set => SetProperty("from_port", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocols is required")]
    public HashSet<TerraformProperty<string>>? Protocols
    {
        set => SetProperty("protocols", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ToPort is required")]
    public required TerraformProperty<double> ToPort
    {
        set => SetProperty("to_port", value);
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
        set => SetProperty("endpoint_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_endpoint_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorCustomRoutingEndpointGroup : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingEndpointGroup(string name) : base("aws_globalaccelerator_custom_routing_endpoint_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint_group_region");
        SetOutput("id");
        SetOutput("listener_arn");
    }

    /// <summary>
    /// The endpoint_group_region attribute.
    /// </summary>
    public TerraformProperty<string> EndpointGroupRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_group_region");
        set => SetProperty("endpoint_group_region", value);
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
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    public required TerraformProperty<string> ListenerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("listener_arn");
        set => SetProperty("listener_arn", value);
    }

    /// <summary>
    /// Block for destination_configuration.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    public HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupDestinationConfigurationBlock>? DestinationConfiguration
    {
        set => SetProperty("destination_configuration", value);
    }

    /// <summary>
    /// Block for endpoint_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsGlobalacceleratorCustomRoutingEndpointGroupEndpointConfigurationBlock>? EndpointConfiguration
    {
        set => SetProperty("endpoint_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingEndpointGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
