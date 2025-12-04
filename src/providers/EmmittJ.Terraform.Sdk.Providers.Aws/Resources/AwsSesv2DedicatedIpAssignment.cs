using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSesv2DedicatedIpAssignment.
/// Nesting mode: single
/// </summary>
public class AwsSesv2DedicatedIpAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_sesv2_dedicated_ip_assignment Terraform resource.
/// Manages a aws_sesv2_dedicated_ip_assignment resource.
/// </summary>
public partial class AwsSesv2DedicatedIpAssignment(string name) : TerraformResource("aws_sesv2_dedicated_ip_assignment", name)
{
    /// <summary>
    /// The destination_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPoolName is required")]
    public required TerraformValue<string> DestinationPoolName
    {
        get => GetArgument<TerraformValue<string>>("destination_pool_name");
        set => SetArgument("destination_pool_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ip is required")]
    public required TerraformValue<string> Ip
    {
        get => GetArgument<TerraformValue<string>>("ip");
        set => SetArgument("ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSesv2DedicatedIpAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSesv2DedicatedIpAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
