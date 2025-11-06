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
    public string? FleetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_name")?.Value;
        set => this.WithProperty("fleet_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    public string? StackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_name")?.Value;
        set => this.WithProperty("stack_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
