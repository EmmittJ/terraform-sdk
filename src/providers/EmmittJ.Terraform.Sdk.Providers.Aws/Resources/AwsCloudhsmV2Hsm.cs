using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudhsmV2HsmTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_cloudhsm_v2_hsm resource.
/// </summary>
public class AwsCloudhsmV2Hsm : TerraformResource
{
    public AwsCloudhsmV2Hsm(string name) : base("aws_cloudhsm_v2_hsm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("hsm_eni_id");
        SetOutput("hsm_id");
        SetOutput("hsm_state");
        SetOutput("availability_zone");
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("ip_address");
        SetOutput("region");
        SetOutput("subnet_id");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudhsmV2HsmTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The hsm_eni_id attribute.
    /// </summary>
    public TerraformExpression HsmEniId => this["hsm_eni_id"];

    /// <summary>
    /// The hsm_id attribute.
    /// </summary>
    public TerraformExpression HsmId => this["hsm_id"];

    /// <summary>
    /// The hsm_state attribute.
    /// </summary>
    public TerraformExpression HsmState => this["hsm_state"];

}
