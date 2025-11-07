using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_guardduty_finding_ids.
/// </summary>
public class AwsGuarddutyFindingIdsDataSource : TerraformDataSource
{
    public AwsGuarddutyFindingIdsDataSource(string name) : base("aws_guardduty_finding_ids", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("finding_ids");
        this.DeclareOutput("has_findings");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id");
        set => this.WithProperty("detector_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The finding_ids attribute.
    /// </summary>
    public TerraformExpression FindingIds => this["finding_ids"];

    /// <summary>
    /// The has_findings attribute.
    /// </summary>
    public TerraformExpression HasFindings => this["has_findings"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
