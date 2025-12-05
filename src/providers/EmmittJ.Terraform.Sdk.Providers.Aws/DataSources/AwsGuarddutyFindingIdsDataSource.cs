using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_guardduty_finding_ids Terraform data source.
/// Retrieves information about a aws_guardduty_finding_ids.
/// </summary>
public partial class AwsGuarddutyFindingIdsDataSource(string name) : TerraformDataSource("aws_guardduty_finding_ids", name)
{
    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    public required TerraformValue<string> DetectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("detector_id");
        set => SetArgument("detector_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The finding_ids attribute.
    /// </summary>
    public TerraformList<string> FindingIds
        => CreateReference("finding_ids");

    /// <summary>
    /// The has_findings attribute.
    /// </summary>
    public TerraformValue<bool> HasFindings
        => CreateReference("has_findings");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

}
