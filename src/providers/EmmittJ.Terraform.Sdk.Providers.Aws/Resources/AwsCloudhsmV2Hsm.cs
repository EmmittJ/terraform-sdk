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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The hsm_eni_id attribute.
    /// </summary>
    public TerraformValue<string> HsmEniId
    {
        get => new TerraformReference<string>(this, "hsm_eni_id");
    }

    /// <summary>
    /// The hsm_id attribute.
    /// </summary>
    public TerraformValue<string> HsmId
    {
        get => new TerraformReference<string>(this, "hsm_id");
    }

    /// <summary>
    /// The hsm_state attribute.
    /// </summary>
    public TerraformValue<string> HsmState
    {
        get => new TerraformReference<string>(this, "hsm_state");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudhsmV2HsmTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudhsmV2HsmTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
