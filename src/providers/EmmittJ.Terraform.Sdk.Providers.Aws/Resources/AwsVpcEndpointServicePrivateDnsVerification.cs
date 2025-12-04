using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsVpcEndpointServicePrivateDnsVerification.
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_vpc_endpoint_service_private_dns_verification Terraform resource.
/// Manages a aws_vpc_endpoint_service_private_dns_verification resource.
/// </summary>
public partial class AwsVpcEndpointServicePrivateDnsVerification(string name) : TerraformResource("aws_vpc_endpoint_service_private_dns_verification", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformValue<bool>? WaitForVerification
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_verification");
        set => SetArgument("wait_for_verification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
