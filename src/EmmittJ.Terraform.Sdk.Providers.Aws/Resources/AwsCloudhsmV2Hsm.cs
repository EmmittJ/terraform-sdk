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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
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
        this.DeclareOutput("hsm_eni_id");
        this.DeclareOutput("hsm_id");
        this.DeclareOutput("hsm_state");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudhsmV2HsmTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudhsmV2HsmTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
