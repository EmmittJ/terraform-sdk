using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2DefaultCreditSpecification.
/// Nesting mode: single
/// </summary>
public class AwsEc2DefaultCreditSpecificationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_ec2_default_credit_specification Terraform resource.
/// Manages a aws_ec2_default_credit_specification resource.
/// </summary>
public partial class AwsEc2DefaultCreditSpecification(string name) : TerraformResource("aws_ec2_default_credit_specification", name)
{
    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCredits is required")]
    public required TerraformValue<string> CpuCredits
    {
        get => new TerraformReference<string>(this, "cpu_credits");
        set => SetArgument("cpu_credits", value);
    }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFamily is required")]
    public required TerraformValue<string> InstanceFamily
    {
        get => new TerraformReference<string>(this, "instance_family");
        set => SetArgument("instance_family", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2DefaultCreditSpecificationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2DefaultCreditSpecificationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
