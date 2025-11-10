using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsGuarddutyDetectorDatasourcesBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_guardduty_detector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGuarddutyDetector : TerraformResource
{
    public AwsGuarddutyDetector(string name) : base("aws_guardduty_detector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("account_id");
        SetOutput("arn");
        SetOutput("enable");
        SetOutput("finding_publishing_frequency");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    public TerraformProperty<bool> Enable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable");
        set => SetProperty("enable", value);
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformProperty<string> FindingPublishingFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("finding_publishing_frequency");
        set => SetProperty("finding_publishing_frequency", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public List<AwsGuarddutyDetectorDatasourcesBlock>? Datasources
    {
        set => SetProperty("datasources", value);
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
