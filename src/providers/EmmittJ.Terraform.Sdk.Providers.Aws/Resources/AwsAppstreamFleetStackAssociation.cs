using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_fleet_stack_association resource.
/// </summary>
public class AwsAppstreamFleetStackAssociation : TerraformResource
{
    public AwsAppstreamFleetStackAssociation(string name) : base("aws_appstream_fleet_stack_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fleet_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("stack_name");
    }

    /// <summary>
    /// The fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FleetName is required")]
    public required TerraformProperty<string> FleetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fleet_name");
        set => SetProperty("fleet_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    public required TerraformProperty<string> StackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_name");
        set => SetProperty("stack_name", value);
    }

}
