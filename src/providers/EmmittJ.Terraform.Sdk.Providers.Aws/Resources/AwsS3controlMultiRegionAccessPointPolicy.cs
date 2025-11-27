using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for details in AwsS3controlMultiRegionAccessPointPolicy.
/// Nesting mode: list
/// </summary>
public class AwsS3controlMultiRegionAccessPointPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    public required TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsS3controlMultiRegionAccessPointPolicy.
/// Nesting mode: single
/// </summary>
public class AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_s3control_multi_region_access_point_policy Terraform resource.
/// Manages a aws_s3control_multi_region_access_point_policy resource.
/// </summary>
public partial class AwsS3controlMultiRegionAccessPointPolicy(string name) : TerraformResource("aws_s3control_multi_region_access_point_policy", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The established attribute.
    /// </summary>
    public TerraformValue<string> Established
    {
        get => new TerraformReference<string>(this, "established");
    }

    /// <summary>
    /// The proposed attribute.
    /// </summary>
    public TerraformValue<string> Proposed
    {
        get => new TerraformReference<string>(this, "proposed");
    }

    /// <summary>
    /// Details block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Details is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Details block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Details block(s) allowed")]
    public required TerraformList<AwsS3controlMultiRegionAccessPointPolicyDetailsBlock> Details
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlMultiRegionAccessPointPolicyDetailsBlock>>("details");
        set => SetArgument("details", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsS3controlMultiRegionAccessPointPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
