using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2DefaultCreditSpecificationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_ec2_default_credit_specification resource.
/// </summary>
public class AwsEc2DefaultCreditSpecification : TerraformResource
{
    public AwsEc2DefaultCreditSpecification(string name) : base("aws_ec2_default_credit_specification", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cpu_credits");
        SetOutput("instance_family");
        SetOutput("region");
    }

    /// <summary>
    /// The cpu_credits attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuCredits is required")]
    public required TerraformProperty<string> CpuCredits
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cpu_credits");
        set => SetProperty("cpu_credits", value);
    }

    /// <summary>
    /// The instance_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceFamily is required")]
    public required TerraformProperty<string> InstanceFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_family");
        set => SetProperty("instance_family", value);
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
    public AwsEc2DefaultCreditSpecificationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
