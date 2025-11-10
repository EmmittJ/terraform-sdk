using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
public class AwsGuarddutyDetectorDatasourcesBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_guardduty_detector resource.
/// </summary>
public class AwsGuarddutyDetector : TerraformResource
{
    public AwsGuarddutyDetector(string name) : base("aws_guardduty_detector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_id");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    public TerraformProperty<bool>? Enable
    {
        get => GetProperty<TerraformProperty<bool>>("enable");
        set => this.WithProperty("enable", value);
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? FindingPublishingFrequency
    {
        get => GetProperty<TerraformProperty<string>>("finding_publishing_frequency");
        set => this.WithProperty("finding_publishing_frequency", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    public List<AwsGuarddutyDetectorDatasourcesBlock>? Datasources
    {
        get => GetProperty<List<AwsGuarddutyDetectorDatasourcesBlock>>("datasources");
        set => this.WithProperty("datasources", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformExpression AccountId => this["account_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
