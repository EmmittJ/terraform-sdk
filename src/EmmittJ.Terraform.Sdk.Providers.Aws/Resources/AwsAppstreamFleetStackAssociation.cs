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
    }

    /// <summary>
    /// The fleet_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FleetName is required")]
    public required TerraformProperty<string> FleetName
    {
        get => GetProperty<TerraformProperty<string>>("fleet_name");
        set => this.WithProperty("fleet_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    public required TerraformProperty<string> StackName
    {
        get => GetProperty<TerraformProperty<string>>("stack_name");
        set => this.WithProperty("stack_name", value);
    }

}
