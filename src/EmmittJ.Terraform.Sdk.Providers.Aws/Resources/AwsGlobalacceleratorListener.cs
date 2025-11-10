using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for port_range in .
/// Nesting mode: set
/// </summary>
public class AwsGlobalacceleratorListenerPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// The from_port attribute.
    /// </summary>
    public TerraformProperty<double>? FromPort
    {
        get => GetProperty<TerraformProperty<double>>("from_port");
        set => WithProperty("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformProperty<double>? ToPort
    {
        get => GetProperty<TerraformProperty<double>>("to_port");
        set => WithProperty("to_port", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorListenerTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_listener resource.
/// </summary>
public class AwsGlobalacceleratorListener : TerraformResource
{
    public AwsGlobalacceleratorListener(string name) : base("aws_globalaccelerator_listener", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorArn is required")]
    public required TerraformProperty<string> AcceleratorArn
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_arn");
        set => this.WithProperty("accelerator_arn", value);
    }

    /// <summary>
    /// The client_affinity attribute.
    /// </summary>
    public TerraformProperty<string>? ClientAffinity
    {
        get => GetProperty<TerraformProperty<string>>("client_affinity");
        set => this.WithProperty("client_affinity", value);
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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// Block for port_range.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortRange block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PortRange block(s) allowed")]
    public HashSet<AwsGlobalacceleratorListenerPortRangeBlock>? PortRange
    {
        get => GetProperty<HashSet<AwsGlobalacceleratorListenerPortRangeBlock>>("port_range");
        set => this.WithProperty("port_range", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorListenerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGlobalacceleratorListenerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
