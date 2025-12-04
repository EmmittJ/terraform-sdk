using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsCloudhsmV2Hsm.
/// Nesting mode: single
/// </summary>
public class AwsCloudhsmV2HsmTimeoutsBlock : TerraformBlock
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
/// Represents a aws_cloudhsm_v2_hsm Terraform resource.
/// Manages a aws_cloudhsm_v2_hsm resource.
/// </summary>
public partial class AwsCloudhsmV2Hsm(string name) : TerraformResource("aws_cloudhsm_v2_hsm", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? AsReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address") ?? AsReference("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id") ?? AsReference("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The hsm_eni_id attribute.
    /// </summary>
    public TerraformValue<string> HsmEniId
        => AsReference("hsm_eni_id");

    /// <summary>
    /// The hsm_id attribute.
    /// </summary>
    public TerraformValue<string> HsmId
        => AsReference("hsm_id");

    /// <summary>
    /// The hsm_state attribute.
    /// </summary>
    public TerraformValue<string> HsmState
        => AsReference("hsm_state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudhsmV2HsmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudhsmV2HsmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
