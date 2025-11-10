using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for details in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlMultiRegionAccessPointPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformProperty<string> Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => WithProperty("policy", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_s3control_multi_region_access_point_policy resource.
/// </summary>
public class AwsS3controlMultiRegionAccessPointPolicy : TerraformResource
{
    public AwsS3controlMultiRegionAccessPointPolicy(string name) : base("aws_s3control_multi_region_access_point_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("established");
        this.DeclareOutput("proposed");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Details block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Details block(s) allowed")]
    public List<AwsS3controlMultiRegionAccessPointPolicyDetailsBlock>? Details
    {
        get => GetProperty<List<AwsS3controlMultiRegionAccessPointPolicyDetailsBlock>>("details");
        set => this.WithProperty("details", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The established attribute.
    /// </summary>
    public TerraformExpression Established => this["established"];

    /// <summary>
    /// The proposed attribute.
    /// </summary>
    public TerraformExpression Proposed => this["proposed"];

}
