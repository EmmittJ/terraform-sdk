using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_vpc_endpoint_service_private_dns_verification resource.
/// </summary>
public class AwsVpcEndpointServicePrivateDnsVerification : TerraformResource
{
    public AwsVpcEndpointServicePrivateDnsVerification(string name) : base("aws_vpc_endpoint_service_private_dns_verification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformProperty<string> ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForVerification
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_verification");
        set => this.WithProperty("wait_for_verification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcEndpointServicePrivateDnsVerificationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
