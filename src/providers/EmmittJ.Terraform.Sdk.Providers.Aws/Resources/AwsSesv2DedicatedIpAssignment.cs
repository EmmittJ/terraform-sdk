using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsSesv2DedicatedIpAssignmentTimeoutsBlock : TerraformBlock
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
/// Manages a aws_sesv2_dedicated_ip_assignment resource.
/// </summary>
public class AwsSesv2DedicatedIpAssignment : TerraformResource
{
    public AwsSesv2DedicatedIpAssignment(string name) : base("aws_sesv2_dedicated_ip_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("destination_pool_name");
        SetOutput("id");
        SetOutput("ip");
        SetOutput("region");
    }

    /// <summary>
    /// The destination_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPoolName is required")]
    public required TerraformProperty<string> DestinationPoolName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_pool_name");
        set => SetProperty("destination_pool_name", value);
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
    /// The ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ip is required")]
    public required TerraformProperty<string> Ip
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip");
        set => SetProperty("ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSesv2DedicatedIpAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
