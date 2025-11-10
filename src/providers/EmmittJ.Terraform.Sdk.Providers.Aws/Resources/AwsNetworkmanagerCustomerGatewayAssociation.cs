using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerCustomerGatewayAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_networkmanager_customer_gateway_association resource.
/// </summary>
public class AwsNetworkmanagerCustomerGatewayAssociation : TerraformResource
{
    public AwsNetworkmanagerCustomerGatewayAssociation(string name) : base("aws_networkmanager_customer_gateway_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("customer_gateway_arn");
        SetOutput("device_id");
        SetOutput("global_network_id");
        SetOutput("id");
        SetOutput("link_id");
    }

    /// <summary>
    /// The customer_gateway_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerGatewayArn is required")]
    public required TerraformProperty<string> CustomerGatewayArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_gateway_arn");
        set => SetProperty("customer_gateway_arn", value);
    }

    /// <summary>
    /// The device_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceId is required")]
    public required TerraformProperty<string> DeviceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_id");
        set => SetProperty("device_id", value);
    }

    /// <summary>
    /// The global_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalNetworkId is required")]
    public required TerraformProperty<string> GlobalNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("global_network_id");
        set => SetProperty("global_network_id", value);
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
    /// The link_id attribute.
    /// </summary>
    public TerraformProperty<string> LinkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("link_id");
        set => SetProperty("link_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerCustomerGatewayAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
