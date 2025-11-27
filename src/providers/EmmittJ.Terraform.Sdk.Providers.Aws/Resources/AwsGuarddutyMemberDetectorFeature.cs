using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for additional_configuration in AwsGuarddutyMemberDetectorFeature.
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyMemberDetectorFeatureAdditionalConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_configuration";

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
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_guardduty_member_detector_feature Terraform resource.
/// Manages a aws_guardduty_member_detector_feature resource.
/// </summary>
public partial class AwsGuarddutyMemberDetectorFeature(string name) : TerraformResource("aws_guardduty_member_detector_feature", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => new TerraformReference<string>(this, "detector_id");
        set => SetArgument("detector_id", value);
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// AdditionalConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGuarddutyMemberDetectorFeatureAdditionalConfigurationBlock>? AdditionalConfiguration
    {
        get => GetArgument<TerraformList<AwsGuarddutyMemberDetectorFeatureAdditionalConfigurationBlock>>("additional_configuration");
        set => SetArgument("additional_configuration", value);
    }

}
